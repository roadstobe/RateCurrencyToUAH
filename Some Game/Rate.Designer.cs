namespace Some_Game
{
    partial class Rate
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.timerWether = new System.Windows.Forms.Timer(this.components);
            this.textBoxWeatherTomorow = new System.Windows.Forms.TextBox();
            this.textBoxWeather2day = new System.Windows.Forms.TextBox();
            this.textBoxWeather = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Find rate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Aqua;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox.Location = new System.Drawing.Point(12, 94);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(269, 75);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Enter code currency";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(12, 175);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(88, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear text";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(106, 175);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(93, 23);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show code";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(383, 145);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(63, 24);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time: ";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Yellow;
            this.labelDate.Font = new System.Drawing.Font("MV Boli", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.Blue;
            this.labelDate.Location = new System.Drawing.Point(352, 113);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(51, 23);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            // 
            // timerDate
            // 
            this.timerDate.Enabled = true;
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.Timer_Date);
            // 
            // timerWether
            // 
            this.timerWether.Enabled = true;
            this.timerWether.Interval = 10000000;
            this.timerWether.Tick += new System.EventHandler(this.Time_wether);
            // 
            // textBoxWeatherTomorow
            // 
            this.textBoxWeatherTomorow.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxWeatherTomorow.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxWeatherTomorow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeatherTomorow.ForeColor = System.Drawing.Color.Yellow;
            this.textBoxWeatherTomorow.Location = new System.Drawing.Point(203, 12);
            this.textBoxWeatherTomorow.Multiline = true;
            this.textBoxWeatherTomorow.Name = "textBoxWeatherTomorow";
            this.textBoxWeatherTomorow.ReadOnly = true;
            this.textBoxWeatherTomorow.Size = new System.Drawing.Size(169, 75);
            this.textBoxWeatherTomorow.TabIndex = 7;
            // 
            // textBoxWeather2day
            // 
            this.textBoxWeather2day.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxWeather2day.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.textBoxWeather2day.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeather2day.ForeColor = System.Drawing.Color.Lime;
            this.textBoxWeather2day.Location = new System.Drawing.Point(387, 13);
            this.textBoxWeather2day.Multiline = true;
            this.textBoxWeather2day.Name = "textBoxWeather2day";
            this.textBoxWeather2day.ReadOnly = true;
            this.textBoxWeather2day.Size = new System.Drawing.Size(170, 75);
            this.textBoxWeather2day.TabIndex = 8;
            // 
            // textBoxWeather
            // 
            this.textBoxWeather.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxWeather.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.textBoxWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWeather.ForeColor = System.Drawing.Color.Lime;
            this.textBoxWeather.Location = new System.Drawing.Point(12, 13);
            this.textBoxWeather.Multiline = true;
            this.textBoxWeather.Name = "textBoxWeather";
            this.textBoxWeather.ReadOnly = true;
            this.textBoxWeather.Size = new System.Drawing.Size(173, 74);
            this.textBoxWeather.TabIndex = 9;
            // 
            // Rate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(581, 210);
            this.Controls.Add(this.textBoxWeather);
            this.Controls.Add(this.textBoxWeather2day);
            this.Controls.Add(this.textBoxWeatherTomorow);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Rate";
            this.Text = "RateCurrency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Timer timerWether;
        private System.Windows.Forms.TextBox textBoxWeatherTomorow;
        private System.Windows.Forms.TextBox textBoxWeather2day;
        private System.Windows.Forms.TextBox textBoxWeather;
    }
}

