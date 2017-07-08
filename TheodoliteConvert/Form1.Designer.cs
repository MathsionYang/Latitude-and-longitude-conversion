namespace TheodoliteConvert
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxDegA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDegB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lab1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lab = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBoxRadionB = new System.Windows.Forms.TextBox();
            this.textBoxRadionA = new System.Windows.Forms.TextBox();
            this.labelRadioB = new System.Windows.Forms.Label();
            this.labelRadioA = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSecB = new System.Windows.Forms.TextBox();
            this.textBoxSecA = new System.Windows.Forms.TextBox();
            this.textBoxMinB = new System.Windows.Forms.TextBox();
            this.textBoxMinA = new System.Windows.Forms.TextBox();
            this.tbwe = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_write = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Image = ((System.Drawing.Image)(resources.GetObject("buttonOk.Image")));
            this.buttonOk.Location = new System.Drawing.Point(12, 20);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(30, 35);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            this.buttonOk.MouseEnter += new System.EventHandler(this.buttonOk_MouseEnter);
            // 
            // textBoxDegA
            // 
            this.textBoxDegA.Location = new System.Drawing.Point(56, 64);
            this.textBoxDegA.Name = "textBoxDegA";
            this.textBoxDegA.Size = new System.Drawing.Size(50, 21);
            this.textBoxDegA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "经度：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 4;
            // 
            // textBoxDegB
            // 
            this.textBoxDegB.Location = new System.Drawing.Point(56, 102);
            this.textBoxDegB.Name = "textBoxDegB";
            this.textBoxDegB.Size = new System.Drawing.Size(50, 21);
            this.textBoxDegB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "纬度：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lab1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.textBoxRadionB);
            this.groupBox1.Controls.Add(this.textBoxRadionA);
            this.groupBox1.Controls.Add(this.labelRadioB);
            this.groupBox1.Controls.Add(this.labelRadioA);
            this.groupBox1.Location = new System.Drawing.Point(262, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 268);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "椭球参数";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "参考椭球:";
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(21, 73);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(0, 12);
            this.lab1.TabIndex = 9;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Controls.Add(this.lab);
            this.groupBox4.Location = new System.Drawing.Point(11, 135);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 52);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "投影方式";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "3",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(123, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 20);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Location = new System.Drawing.Point(18, 28);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(0, 12);
            this.lab.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1954",
            "1980",
            "1984"});
            this.comboBox2.Location = new System.Drawing.Point(74, 99);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(124, 20);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBoxRadionB
            // 
            this.textBoxRadionB.Location = new System.Drawing.Point(90, 46);
            this.textBoxRadionB.Name = "textBoxRadionB";
            this.textBoxRadionB.ReadOnly = true;
            this.textBoxRadionB.Size = new System.Drawing.Size(96, 21);
            this.textBoxRadionB.TabIndex = 7;
            this.textBoxRadionB.Text = "6356863.0188";
            // 
            // textBoxRadionA
            // 
            this.textBoxRadionA.Location = new System.Drawing.Point(92, 18);
            this.textBoxRadionA.Name = "textBoxRadionA";
            this.textBoxRadionA.ReadOnly = true;
            this.textBoxRadionA.Size = new System.Drawing.Size(96, 21);
            this.textBoxRadionA.TabIndex = 6;
            this.textBoxRadionA.Text = "6378245";
            // 
            // labelRadioB
            // 
            this.labelRadioB.AutoSize = true;
            this.labelRadioB.Location = new System.Drawing.Point(9, 48);
            this.labelRadioB.Name = "labelRadioB";
            this.labelRadioB.Size = new System.Drawing.Size(77, 12);
            this.labelRadioB.TabIndex = 5;
            this.labelRadioB.Text = "椭球短半轴：";
            // 
            // labelRadioA
            // 
            this.labelRadioA.AutoSize = true;
            this.labelRadioA.Location = new System.Drawing.Point(9, 21);
            this.labelRadioA.Name = "labelRadioA";
            this.labelRadioA.Size = new System.Drawing.Size(77, 12);
            this.labelRadioA.TabIndex = 4;
            this.labelRadioA.Text = "椭球长半轴：";
            this.labelRadioA.Click += new System.EventHandler(this.labelRadioA_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBoxSecB);
            this.groupBox3.Controls.Add(this.textBoxSecA);
            this.groupBox3.Controls.Add(this.textBoxMinB);
            this.groupBox3.Controls.Add(this.textBoxMinA);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.textBoxDegA);
            this.groupBox3.Controls.Add(this.textBoxDegB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 142);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "大地坐标";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "  度       分        秒";
            // 
            // textBoxSecB
            // 
            this.textBoxSecB.Location = new System.Drawing.Point(174, 99);
            this.textBoxSecB.Name = "textBoxSecB";
            this.textBoxSecB.Size = new System.Drawing.Size(43, 21);
            this.textBoxSecB.TabIndex = 10;
            // 
            // textBoxSecA
            // 
            this.textBoxSecA.Location = new System.Drawing.Point(174, 67);
            this.textBoxSecA.Name = "textBoxSecA";
            this.textBoxSecA.Size = new System.Drawing.Size(43, 21);
            this.textBoxSecA.TabIndex = 9;
            // 
            // textBoxMinB
            // 
            this.textBoxMinB.Location = new System.Drawing.Point(114, 101);
            this.textBoxMinB.Name = "textBoxMinB";
            this.textBoxMinB.Size = new System.Drawing.Size(45, 21);
            this.textBoxMinB.TabIndex = 8;
            // 
            // textBoxMinA
            // 
            this.textBoxMinA.Location = new System.Drawing.Point(114, 64);
            this.textBoxMinA.Name = "textBoxMinA";
            this.textBoxMinA.Size = new System.Drawing.Size(45, 21);
            this.textBoxMinA.TabIndex = 7;
            // 
            // tbwe
            // 
            this.tbwe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbwe.Location = new System.Drawing.Point(3, 17);
            this.tbwe.Multiline = true;
            this.tbwe.Name = "tbwe";
            this.tbwe.Size = new System.Drawing.Size(228, 100);
            this.tbwe.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbwe);
            this.groupBox5.Location = new System.Drawing.Point(13, 160);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(234, 120);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "高斯投影坐标";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_close);
            this.groupBox2.Controls.Add(this.btn_read);
            this.groupBox2.Controls.Add(this.bt_write);
            this.groupBox2.Controls.Add(this.buttonOk);
            this.groupBox2.Location = new System.Drawing.Point(11, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // bt_write
            // 
            this.bt_write.Image = ((System.Drawing.Image)(resources.GetObject("bt_write.Image")));
            this.bt_write.Location = new System.Drawing.Point(57, 20);
            this.bt_write.Name = "bt_write";
            this.bt_write.Size = new System.Drawing.Size(30, 35);
            this.bt_write.TabIndex = 1;
            this.bt_write.UseVisualStyleBackColor = true;
            this.bt_write.Click += new System.EventHandler(this.bt_write_Click);
            this.bt_write.MouseEnter += new System.EventHandler(this.bt_write_MouseEnter);
            // 
            // btn_read
            // 
            this.btn_read.Image = ((System.Drawing.Image)(resources.GetObject("btn_read.Image")));
            this.btn_read.Location = new System.Drawing.Point(106, 20);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(30, 35);
            this.btn_read.TabIndex = 2;
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            this.btn_read.MouseEnter += new System.EventHandler(this.btn_read_MouseEnter);
            // 
            // btn_close
            // 
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(157, 20);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 35);
            this.btn_close.TabIndex = 3;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 285);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "坐标转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.TextBox textBoxDegA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDegB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelRadioB;
        private System.Windows.Forms.Label labelRadioA;
        private System.Windows.Forms.TextBox textBoxRadionB;
        private System.Windows.Forms.TextBox textBoxRadionA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;

        private System.Windows.Forms.TextBox textBoxSecB;
        private System.Windows.Forms.TextBox textBoxSecA;
        private System.Windows.Forms.TextBox textBoxMinB;
        private System.Windows.Forms.TextBox textBoxMinA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.TextBox tbwe;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_write;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

