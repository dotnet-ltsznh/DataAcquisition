namespace DataAcquisition
{
    partial class frmCommReader
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
                timer.Close();
                timer.Dispose();
                toledos.closeSerialPort();


                components.Dispose();
               
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labResult = new System.Windows.Forms.Label();
            this.comPortName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBaudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comDatabits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comStopbits = new System.Windows.Forms.ComboBox();
            this.rbtnCommStatus = new System.Windows.Forms.RadioButton();
            this.btnComm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 336);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labResult);
            this.groupBox1.Location = new System.Drawing.Point(437, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 116);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "接收数据结果";
            // 
            // labResult
            // 
            this.labResult.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labResult.Location = new System.Drawing.Point(6, 21);
            this.labResult.Name = "labResult";
            this.labResult.Size = new System.Drawing.Size(227, 89);
            this.labResult.TabIndex = 100;
            this.labResult.Text = "0.00";
            this.labResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comPortName
            // 
            this.comPortName.FormattingEnabled = true;
            this.comPortName.Location = new System.Drawing.Point(63, 28);
            this.comPortName.Name = "comPortName";
            this.comPortName.Size = new System.Drawing.Size(170, 23);
            this.comPortName.TabIndex = 0;
            this.comPortName.Text = "COM1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "串口";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "波特率";
            // 
            // comBaudrate
            // 
            this.comBaudrate.FormattingEnabled = true;
            this.comBaudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600"});
            this.comBaudrate.Location = new System.Drawing.Point(63, 57);
            this.comBaudrate.Name = "comBaudrate";
            this.comBaudrate.Size = new System.Drawing.Size(170, 23);
            this.comBaudrate.TabIndex = 2;
            this.comBaudrate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据位";
            // 
            // comDatabits
            // 
            this.comDatabits.FormattingEnabled = true;
            this.comDatabits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comDatabits.Location = new System.Drawing.Point(63, 86);
            this.comDatabits.Name = "comDatabits";
            this.comDatabits.Size = new System.Drawing.Size(170, 23);
            this.comDatabits.TabIndex = 4;
            this.comDatabits.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "校验位";
            // 
            // comParity
            // 
            this.comParity.FormattingEnabled = true;
            this.comParity.Location = new System.Drawing.Point(63, 115);
            this.comParity.Name = "comParity";
            this.comParity.Size = new System.Drawing.Size(170, 23);
            this.comParity.TabIndex = 6;
            this.comParity.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "停止位";
            // 
            // comStopbits
            // 
            this.comStopbits.FormattingEnabled = true;
            this.comStopbits.Location = new System.Drawing.Point(63, 144);
            this.comStopbits.Name = "comStopbits";
            this.comStopbits.Size = new System.Drawing.Size(170, 23);
            this.comStopbits.TabIndex = 8;
            this.comStopbits.Text = "None";
            // 
            // rbtnCommStatus
            // 
            this.rbtnCommStatus.AutoSize = true;
            this.rbtnCommStatus.Enabled = false;
            this.rbtnCommStatus.Location = new System.Drawing.Point(40, 179);
            this.rbtnCommStatus.Name = "rbtnCommStatus";
            this.rbtnCommStatus.Size = new System.Drawing.Size(17, 16);
            this.rbtnCommStatus.TabIndex = 10;
            this.rbtnCommStatus.TabStop = true;
            this.rbtnCommStatus.UseVisualStyleBackColor = true;
            // 
            // btnComm
            // 
            this.btnComm.Location = new System.Drawing.Point(64, 174);
            this.btnComm.Name = "btnComm";
            this.btnComm.Size = new System.Drawing.Size(169, 31);
            this.btnComm.TabIndex = 11;
            this.btnComm.Text = "打开串口";
            this.btnComm.UseVisualStyleBackColor = true;
            this.btnComm.Click += new System.EventHandler(this.OpenOrCloseSerialPort);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 336);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收原始数据";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(6, 19);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(415, 317);
            this.txtData.TabIndex = 100;
            this.txtData.Text = "02 03 04";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnComm);
            this.groupBox3.Controls.Add(this.comPortName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comBaudrate);
            this.groupBox3.Controls.Add(this.rbtnCommStatus);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comDatabits);
            this.groupBox3.Controls.Add(this.comStopbits);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comParity);
            this.groupBox3.Location = new System.Drawing.Point(449, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口设置";
            // 
            // frmCommReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCommReader";
            this.Text = "串口取数";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comPortName;
        private System.Windows.Forms.Button btnComm;
        private System.Windows.Forms.RadioButton rbtnCommStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comStopbits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comParity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comDatabits;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comBaudrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labResult;
    }
}

