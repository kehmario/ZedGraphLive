namespace ZedGraph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.rtbIncoming = new System.Windows.Forms.RichTextBox();
            this.ResetTime = new System.Windows.Forms.Button();
            this.Stream = new System.Windows.Forms.CheckBox();
            this.BeatsMinute = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Window_Size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Refresh = new System.Windows.Forms.Button();
            this.ZoomBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.csv_btn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.TextBox();
            this.Stop = new System.Windows.Forms.Button();
            this.Default = new System.Windows.Forms.Button();
            this.ZoomScroll = new System.Windows.Forms.VScrollBar();
            this.MaxBOX = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(12, 12);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1039, 426);
            this.zedGraphControl1.TabIndex = 0;
            this.zedGraphControl1.Load += new System.EventHandler(this.zedGraphControl1_Load);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1057, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1060, 39);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(149, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(1060, 66);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(59, 23);
            this.Connect.TabIndex = 7;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(1125, 66);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(84, 23);
            this.Disconnect.TabIndex = 8;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // rtbIncoming
            // 
            this.rtbIncoming.AcceptsTab = true;
            this.rtbIncoming.Location = new System.Drawing.Point(1057, 310);
            this.rtbIncoming.Name = "rtbIncoming";
            this.rtbIncoming.ReadOnly = true;
            this.rtbIncoming.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbIncoming.Size = new System.Drawing.Size(152, 127);
            this.rtbIncoming.TabIndex = 9;
            this.rtbIncoming.Text = "";
            this.rtbIncoming.TextChanged += new System.EventHandler(this.rtbIncoming_TextChanged_1);
            // 
            // ResetTime
            // 
            this.ResetTime.Location = new System.Drawing.Point(1057, 281);
            this.ResetTime.Name = "ResetTime";
            this.ResetTime.Size = new System.Drawing.Size(75, 23);
            this.ResetTime.TabIndex = 10;
            this.ResetTime.Text = "ResetTime";
            this.ResetTime.UseVisualStyleBackColor = true;
            this.ResetTime.Click += new System.EventHandler(this.ResetTime_Click);
            // 
            // Stream
            // 
            this.Stream.AutoSize = true;
            this.Stream.Location = new System.Drawing.Point(1057, 180);
            this.Stream.Name = "Stream";
            this.Stream.Size = new System.Drawing.Size(65, 17);
            this.Stream.TabIndex = 11;
            this.Stream.Text = "Window";
            this.Stream.UseVisualStyleBackColor = true;
            // 
            // BeatsMinute
            // 
            this.BeatsMinute.Location = new System.Drawing.Point(1057, 229);
            this.BeatsMinute.Name = "BeatsMinute";
            this.BeatsMinute.Size = new System.Drawing.Size(65, 20);
            this.BeatsMinute.TabIndex = 13;
            this.BeatsMinute.TextChanged += new System.EventHandler(this.BeatsMinute_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1131, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "BPM";
            // 
            // Window_Size
            // 
            this.Window_Size.Location = new System.Drawing.Point(1057, 255);
            this.Window_Size.Name = "Window_Size";
            this.Window_Size.Size = new System.Drawing.Size(65, 20);
            this.Window_Size.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1128, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Window Size";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Stream up to 10,000 data";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(1060, 96);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 18;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // ZoomBox
            // 
            this.ZoomBox.Location = new System.Drawing.Point(1057, 203);
            this.ZoomBox.Name = "ZoomBox";
            this.ZoomBox.Size = new System.Drawing.Size(65, 20);
            this.ZoomBox.TabIndex = 19;
            this.ZoomBox.TabStop = false;
            this.ZoomBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ZoomBox.TextChanged += new System.EventHandler(this.ZoomBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1131, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Zoom";
            // 
            // csv_btn
            // 
            this.csv_btn.Location = new System.Drawing.Point(1058, 126);
            this.csv_btn.Name = "csv_btn";
            this.csv_btn.Size = new System.Drawing.Size(75, 23);
            this.csv_btn.TabIndex = 21;
            this.csv_btn.Text = "Start Saving";
            this.csv_btn.UseVisualStyleBackColor = true;
            this.csv_btn.Click += new System.EventHandler(this.csv_btn_Click);
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(1057, 155);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(151, 20);
            this.Status.TabIndex = 22;
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(1134, 126);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(75, 23);
            this.Stop.TabIndex = 23;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Default
            // 
            this.Default.Location = new System.Drawing.Point(1138, 281);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(75, 23);
            this.Default.TabIndex = 25;
            this.Default.Text = "Default";
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // ZoomScroll
            // 
            this.ZoomScroll.Location = new System.Drawing.Point(1216, 13);
            this.ZoomScroll.Maximum = 1024;
            this.ZoomScroll.Name = "ZoomScroll";
            this.ZoomScroll.Size = new System.Drawing.Size(26, 425);
            this.ZoomScroll.TabIndex = 26;
            this.ZoomScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ZoomScroll_Scroll);
            // 
            // MaxBOX
            // 
            this.MaxBOX.Location = new System.Drawing.Point(12, 444);
            this.MaxBOX.Name = "MaxBOX";
            this.MaxBOX.Size = new System.Drawing.Size(100, 20);
            this.MaxBOX.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 485);
            this.Controls.Add(this.MaxBOX);
            this.Controls.Add(this.ZoomScroll);
            this.Controls.Add(this.Default);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.csv_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZoomBox);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Window_Size);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BeatsMinute);
            this.Controls.Add(this.Stream);
            this.Controls.Add(this.ResetTime);
            this.Controls.Add(this.rtbIncoming);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.zedGraphControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ZedGraphControl zedGraphControl1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.RichTextBox rtbIncoming;
        private System.Windows.Forms.Button ResetTime;
        private System.Windows.Forms.CheckBox Stream;
        private System.Windows.Forms.TextBox BeatsMinute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Window_Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox ZoomBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button csv_btn;
        private System.Windows.Forms.TextBox Status;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.VScrollBar ZoomScroll;
        private System.Windows.Forms.TextBox MaxBOX;
    }
}

