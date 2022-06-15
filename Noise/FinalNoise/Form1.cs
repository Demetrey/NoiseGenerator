using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace FinalNoise
{
    public partial class Form1 : Form
    {
        // Список для хранения обработанных изображений
        List<Bitmap> _pictures = new List<Bitmap>(101);
        Bitmap _btm;
        float _renderparam = 50;
        // Обработчик изображений
        readonly ImageProcessor _imageProcessor = new ImageProcessor();

        public Form1()
        {
            InitializeComponent();
            _imageProcessor.PBMaxNotify += onPBMaxChanged;
            _imageProcessor.PBValNotify += onPBValNotify;
            _imageProcessor.PBAllNotify += onPBAllNotify;
        }

        private void onPBMaxChanged(int val)
        {
            Invoke(new Action(() =>
            {
                pbIteration.Maximum = val;
            }));
        }

        private void onPBValNotify(int val)
        {
            Invoke(new Action(() =>
            {
                pbIteration.Value = val;
            }));
        }

        private void onPBAllNotify(int val)
        {
            Invoke(new Action(() =>
            {
                pbAll.Value = val;
                currentPersent.Text = $"{val}%";
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Noises.SelectedIndex = 0;
        }

        // Сброс значений некоторых элементов UI
        private void resetUI()
        {
            pbAll.Value = 0;
            pbAll.Maximum = 100;
            tbCurrentPersent.Text = "0";
            imgLine.Value = 0;
            currentPersent.Text = "0";
        }

        // Блокировка управления пользователю
        private void blockUI()
        {
            imgLine.Enabled = false;
            btnProcess.Enabled = false;
            btnApply.Enabled = false;
            btnOpenUrl.Enabled = false;
            btnOpenFile.Enabled = false;
        }

        // Разблокировка управления пользователю
        private void unlockUI()
        {
            imgLine.Enabled = true;
            btnProcess.Enabled = true;
            btnApply.Enabled = true;
            btnOpenUrl.Enabled = true;
            btnOpenFile.Enabled = true;
        }

        // Открытие файла на ПК
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    resetUI();
                    _pictures.Clear();
                    pictureResult.Image = null;
                    var bitmap = new Bitmap(openFileDialog1.FileName);
                    _btm = bitmap; // для передачи между методами
                    pictureStart.Image = bitmap;
                    btnApply.Enabled = true;
                    if(cbOneImg.Checked == false)
                        btnProcess.Enabled = true;
                    label6.Text = "Image Size: " + bitmap.Width.ToString() + 
                        "x" + bitmap.Height;
                }
                catch
                {
                    MessageBox.Show("Unable to open file", 
                                    "Error", 
                                    MessageBoxButtons.OK, 
                                    MessageBoxIcon.Error);
                }

            }
        }

        // Открытие файла по url
        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            if(tbUrl.Text != "" && tbUrl.Text != "URI")
            {
                try
                {
                    resetUI();
                    _pictures.Clear();
                    pictureResult.Image = null;
                    WebClient wc = new WebClient();
                    var bitmap = new Bitmap(wc.OpenRead(tbUrl.Text));
                    _btm = bitmap;
                    pictureStart.Image = bitmap;
                    btnApply.Enabled = true;
                    if (cbOneImg.Checked == false)
                        btnProcess.Enabled = true;
                    label6.Text = "Image Size: " + bitmap.Width.ToString() + "x" + bitmap.Height;
                }
                catch
                {
                    MessageBox.Show("Unable to open file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Изменение значения checkbox для выбора генирации одного изображения
        private void cbOneImg_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOneImg.Checked == true)
            {
                imgLine.Enabled = false;
                tbNoisePersent.Enabled = true;
                btnApply.Text = "Apply and Process";
                btnProcess.Enabled = false;
            }
            else
            {
                tbNoisePersent.Enabled = false;
                btnApply.Text = "Apply";
                if(_btm != null)
                    btnProcess.Enabled = true;
            }
        }

        // Обработка всех версий изображения
        private async void btnProcess_Click(object sender, EventArgs e)
        {
            // Для подсчета времени обработки
            var sw = Stopwatch.StartNew();
            resetUI();
            blockUI();
            _pictures.Clear();
            int alg = Noises.SelectedIndex;
            btnSelect.Enabled = false;
            tbCurrentPersent.Enabled = false;
            // Передача в другой поток задачи обработки
            await Task.Run(() => { 
                _pictures = _imageProcessor.Render(_btm, 
                                                 _renderparam, 
                                                 alg, 
                                                 isBlack: cbSap.Checked, 
                                                 isWhite: cbBlack.Checked); 
            });
            unlockUI();
            // После выполнения обработки
            btnSelect.Enabled = true;
            tbCurrentPersent.Enabled = true;
            btnSave.Enabled = true;
            imgLine.Enabled = true;
            pictureResult.Image = _pictures[imgLine.Value];
            sw.Stop();
            label5.Text = "Time: " + sw.Elapsed.ToString();
        }

        // Нажатие кнопки применить/применить и выполнить
        private async void btnApply_Click(object sender, EventArgs e)
        {
            // Получение данных о параметрах обработки
            _renderparam = (float)Convert.ToDouble(tbNoiseParam.Text);
            // Если включена опция обработки одного изображения
            if (cbOneImg.Checked == true)
            {
                var sw = Stopwatch.StartNew();
                btnSelect.Enabled = false;
                tbCurrentPersent.Enabled = false;
                _pictures.Clear();
                resetUI();
                int persents = Convert.ToInt32(tbNoisePersent.Text);
                if(persents > 100)
                {
                    persents = 100;
                    tbNoisePersent.Text = "100";
                }
                if(persents < 1)
                {
                    persents = 1;
                    tbNoisePersent.Text = "1";
                }
                blockUI();
                int alg = Noises.SelectedIndex;
                await Task.Run(() => { 
                    _pictures = _imageProcessor.Render(_btm, 
                                                     _renderparam, 
                                                     alg, 
                                                     persents, 
                                                     1, 
                                                     cbSap.Checked, 
                                                     cbBlack.Checked); 
                });
                unlockUI();
                imgLine.Enabled = false;
                pictureResult.Image = _pictures[1];
                btnProcess.Enabled = false;
                sw.Stop();
                label5.Text = "Time: " + sw.Elapsed.ToString();
                btnSave.Enabled = true;
                imgLine.Enabled = false;
            }
        }

        // Прокрутка trackbar
        private void line_Scroll(object sender, EventArgs e)
        {
            if (_pictures == null || _pictures.Count == 0)
                return;

            pictureResult.Image = _pictures[imgLine.Value];
            tbCurrentPersent.Text = imgLine.Value.ToString();
        }

        // Проверка ввода процентов шума
        private void tbNoisePersent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || (Char.IsControl(e.KeyChar)));
        }

        // Проверка ввода параметров шума
        private void tbNoiseParam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || 
                ((e.KeyChar == System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0])
                && (DS_Count(((TextBox)sender).Text) < 1)) || (Char.IsControl(e.KeyChar)));
        }

        // Получение данных о разделителе
        private int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }

        // Сохранение выходного изображения
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureResult.Image.Save(saveFileDialog1.FileName);
                }
                catch
                {
                    MessageBox.Show("Unable to save file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Переход к текущему проценту зашумления
        private void btnSelectPersent_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbCurrentPersent.Text) <= 100 && Convert.ToInt32(tbCurrentPersent.Text) >= 0)
            {
                imgLine.Value = Convert.ToInt32(tbCurrentPersent.Text);
                pictureResult.Image = _pictures[Convert.ToInt32(tbCurrentPersent.Text)];
            }
        }

        // Ввод процентов зашумления
        private void btnNoisePersent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.KeyChar) || (Char.IsControl(e.KeyChar)));
        }

        // Изменение вида шума (отлавливаем 3-й индекс)
        private void noises_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Noises.SelectedIndex == 3)
            {
                cbSap.Enabled = true;
                cbBlack.Enabled = true;
            }
            else
            {
                cbSap.Enabled = false;
                cbBlack.Enabled = false;
            }
        }

        private void cbSap_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSap.Checked == true)
                cbBlack.Checked = false;
        }

        private void cbBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBlack.Checked == true)
                cbSap.Checked = false;
        }
    }
}
