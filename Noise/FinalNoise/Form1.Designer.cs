namespace FinalNoise
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.pictureResult = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.pictureStart = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbIteration = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCurrentPersent = new System.Windows.Forms.TextBox();
            this.imgLine = new System.Windows.Forms.TrackBar();
            this.currentPersent = new System.Windows.Forms.Label();
            this.pbAll = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbBlack = new System.Windows.Forms.CheckBox();
            this.cbSap = new System.Windows.Forms.CheckBox();
            this.cbOneImg = new System.Windows.Forms.CheckBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.tbNoisePersent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoiseParam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Noises = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureStart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLine)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1247, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            this.groupBox1.Text = "View";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox7.Controls.Add(this.pictureResult);
            this.groupBox7.Location = new System.Drawing.Point(623, 18);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(621, 373);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resulting image";
            // 
            // pictureResult
            // 
            this.pictureResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureResult.Location = new System.Drawing.Point(3, 18);
            this.pictureResult.Name = "pictureResult";
            this.pictureResult.Size = new System.Drawing.Size(615, 352);
            this.pictureResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureResult.TabIndex = 0;
            this.pictureResult.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.pictureStart);
            this.groupBox6.Location = new System.Drawing.Point(3, 18);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(620, 373);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Source image";
            // 
            // pictureStart
            // 
            this.pictureStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureStart.Location = new System.Drawing.Point(3, 18);
            this.pictureStart.Name = "pictureStart";
            this.pictureStart.Size = new System.Drawing.Size(614, 352);
            this.pictureStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureStart.TabIndex = 0;
            this.pictureStart.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(0, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1247, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings and controls";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.pbIteration);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.btnSelect);
            this.groupBox5.Controls.Add(this.btnProcess);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tbCurrentPersent);
            this.groupBox5.Controls.Add(this.imgLine);
            this.groupBox5.Controls.Add(this.currentPersent);
            this.groupBox5.Controls.Add(this.pbAll);
            this.groupBox5.Location = new System.Drawing.Point(389, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(852, 182);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Iteration progress";
            // 
            // pbIteration
            // 
            this.pbIteration.Location = new System.Drawing.Point(681, 101);
            this.pbIteration.Name = "pbIteration";
            this.pbIteration.Size = new System.Drawing.Size(168, 23);
            this.pbIteration.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Image Size: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Time: ";
            // 
            // btnSelect
            // 
            this.btnSelect.Enabled = false;
            this.btnSelect.Location = new System.Drawing.Point(139, 53);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 30);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelectPersent_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnProcess.Enabled = false;
            this.btnProcess.Location = new System.Drawing.Point(3, 126);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(846, 30);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Process All";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "% of noise";
            // 
            // tbCurrentPersent
            // 
            this.tbCurrentPersent.Enabled = false;
            this.tbCurrentPersent.Location = new System.Drawing.Point(6, 57);
            this.tbCurrentPersent.Name = "tbCurrentPersent";
            this.tbCurrentPersent.Size = new System.Drawing.Size(55, 22);
            this.tbCurrentPersent.TabIndex = 3;
            this.tbCurrentPersent.Text = "0";
            this.tbCurrentPersent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnNoisePersent_KeyPress);
            // 
            // imgLine
            // 
            this.imgLine.Enabled = false;
            this.imgLine.LargeChange = 10;
            this.imgLine.Location = new System.Drawing.Point(6, 21);
            this.imgLine.Maximum = 100;
            this.imgLine.Name = "imgLine";
            this.imgLine.Size = new System.Drawing.Size(840, 56);
            this.imgLine.TabIndex = 2;
            this.imgLine.Scroll += new System.EventHandler(this.line_Scroll);
            // 
            // currentPersent
            // 
            this.currentPersent.AutoSize = true;
            this.currentPersent.BackColor = System.Drawing.Color.Transparent;
            this.currentPersent.Location = new System.Drawing.Point(421, 159);
            this.currentPersent.Name = "currentPersent";
            this.currentPersent.Size = new System.Drawing.Size(26, 16);
            this.currentPersent.TabIndex = 1;
            this.currentPersent.Text = "0%";
            // 
            // pbAll
            // 
            this.pbAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbAll.Location = new System.Drawing.Point(3, 156);
            this.pbAll.Name = "pbAll";
            this.pbAll.Size = new System.Drawing.Size(846, 23);
            this.pbAll.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbBlack);
            this.groupBox4.Controls.Add(this.cbSap);
            this.groupBox4.Controls.Add(this.cbOneImg);
            this.groupBox4.Controls.Add(this.btnApply);
            this.groupBox4.Controls.Add(this.tbNoisePersent);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tbNoiseParam);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(203, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 182);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Noise settings";
            // 
            // cbBlack
            // 
            this.cbBlack.AutoSize = true;
            this.cbBlack.Enabled = false;
            this.cbBlack.Location = new System.Drawing.Point(59, 96);
            this.cbBlack.Name = "cbBlack";
            this.cbBlack.Size = new System.Drawing.Size(63, 20);
            this.cbBlack.TabIndex = 7;
            this.cbBlack.Text = "Black";
            this.cbBlack.UseVisualStyleBackColor = true;
            this.cbBlack.CheckedChanged += new System.EventHandler(this.cbBlack_CheckedChanged);
            // 
            // cbSap
            // 
            this.cbSap.AutoSize = true;
            this.cbSap.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSap.Enabled = false;
            this.cbSap.Location = new System.Drawing.Point(3, 94);
            this.cbSap.Name = "cbSap";
            this.cbSap.Size = new System.Drawing.Size(180, 20);
            this.cbSap.TabIndex = 6;
            this.cbSap.Text = "SaP";
            this.cbSap.UseVisualStyleBackColor = true;
            this.cbSap.CheckedChanged += new System.EventHandler(this.cbSap_CheckedChanged);
            // 
            // cbOneImg
            // 
            this.cbOneImg.AutoSize = true;
            this.cbOneImg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cbOneImg.Location = new System.Drawing.Point(3, 129);
            this.cbOneImg.Name = "cbOneImg";
            this.cbOneImg.Size = new System.Drawing.Size(180, 20);
            this.cbOneImg.TabIndex = 5;
            this.cbOneImg.Text = "Create one image";
            this.cbOneImg.UseVisualStyleBackColor = true;
            this.cbOneImg.CheckedChanged += new System.EventHandler(this.cbOneImg_CheckedChanged);
            // 
            // btnApply
            // 
            this.btnApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(3, 149);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(180, 30);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbNoisePersent
            // 
            this.tbNoisePersent.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNoisePersent.Enabled = false;
            this.tbNoisePersent.Location = new System.Drawing.Point(3, 72);
            this.tbNoisePersent.Name = "tbNoisePersent";
            this.tbNoisePersent.Size = new System.Drawing.Size(180, 22);
            this.tbNoisePersent.TabIndex = 3;
            this.tbNoisePersent.Text = "0";
            this.tbNoisePersent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoisePersent_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Noise percentage";
            // 
            // tbNoiseParam
            // 
            this.tbNoiseParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbNoiseParam.Location = new System.Drawing.Point(3, 34);
            this.tbNoiseParam.Name = "tbNoiseParam";
            this.tbNoiseParam.Size = new System.Drawing.Size(180, 22);
            this.tbNoiseParam.TabIndex = 1;
            this.tbNoiseParam.Text = "50";
            this.tbNoiseParam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNoiseParam_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Noise parameter";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Noises);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnOpenUrl);
            this.groupBox3.Controls.Add(this.tbUrl);
            this.groupBox3.Controls.Add(this.btnOpenFile);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Location = new System.Drawing.Point(3, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 182);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Files";
            // 
            // Noises
            // 
            this.Noises.Dock = System.Windows.Forms.DockStyle.Top;
            this.Noises.FormattingEnabled = true;
            this.Noises.Items.AddRange(new object[] {
            "White noise (Gauss)",
            "White noise (uniform)",
            "Additive noise",
            "Impulse noise",
            "Digital camera effect"});
            this.Noises.Location = new System.Drawing.Point(3, 100);
            this.Noises.Name = "Noises";
            this.Noises.Size = new System.Drawing.Size(194, 24);
            this.Noises.TabIndex = 4;
            this.Noises.SelectedIndexChanged += new System.EventHandler(this.noises_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(3, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(194, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenUrl.Location = new System.Drawing.Point(3, 70);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(194, 30);
            this.btnOpenUrl.TabIndex = 2;
            this.btnOpenUrl.Text = "Open URI";
            this.btnOpenUrl.UseVisualStyleBackColor = true;
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // tbUrl
            // 
            this.tbUrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUrl.Location = new System.Drawing.Point(3, 48);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(194, 22);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "URI";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpenFile.Location = new System.Drawing.Point(3, 18);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(194, 30);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open on PC";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Images|*.bmp;*.png;*.jpg";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "bmp files|*.bmp|png files|*.png|jpg files|*.jpg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1265, 647);
            this.Name = "Form1";
            this.Text = "Noise Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureResult)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureStart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLine)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureResult;
        private System.Windows.Forms.PictureBox pictureStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.CheckBox cbOneImg;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbNoisePersent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoiseParam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCurrentPersent;
        private System.Windows.Forms.TrackBar imgLine;
        private System.Windows.Forms.Label currentPersent;
        private System.Windows.Forms.ProgressBar pbAll;
        private System.Windows.Forms.CheckBox cbSap;
        private System.Windows.Forms.ComboBox Noises;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ProgressBar pbIteration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbBlack;
    }
}

