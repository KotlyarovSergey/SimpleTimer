namespace SimpleTimer
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbtnJump = new System.Windows.Forms.RadioButton();
            this.rbtnBlink = new System.Windows.Forms.RadioButton();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.BlinkTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dTPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.BurlyWood;
            this.textBox1.Location = new System.Drawing.Point(33, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Время вышло!";
            // 
            // rbtnJump
            // 
            this.rbtnJump.AutoSize = true;
            this.rbtnJump.Checked = true;
            this.rbtnJump.Location = new System.Drawing.Point(33, 111);
            this.rbtnJump.Name = "rbtnJump";
            this.rbtnJump.Size = new System.Drawing.Size(51, 17);
            this.rbtnJump.TabIndex = 3;
            this.rbtnJump.TabStop = true;
            this.rbtnJump.Text = "Окно";
            this.rbtnJump.UseVisualStyleBackColor = true;
            this.rbtnJump.CheckedChanged += new System.EventHandler(this.rbtnJump_CheckedChanged);
            // 
            // rbtnBlink
            // 
            this.rbtnBlink.AutoSize = true;
            this.rbtnBlink.Location = new System.Drawing.Point(90, 111);
            this.rbtnBlink.Name = "rbtnBlink";
            this.rbtnBlink.Size = new System.Drawing.Size(68, 17);
            this.rbtnBlink.TabIndex = 4;
            this.rbtnBlink.TabStop = true;
            this.rbtnBlink.Text = "Моргать";
            this.rbtnBlink.UseVisualStyleBackColor = true;
            this.rbtnBlink.CheckedChanged += new System.EventHandler(this.rbtnBlink_CheckedChanged);
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Location = new System.Drawing.Point(206, 111);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(50, 17);
            this.checkBoxSound.TabIndex = 5;
            this.checkBoxSound.Text = "Звук";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            this.checkBoxSound.CheckedChanged += new System.EventHandler(this.checkBoxSound_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(33, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(228, 33);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "= С  Т  А  Р  Т =";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Interval = 250;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // BlinkTimer
            // 
            this.BlinkTimer.Interval = 500;
            this.BlinkTimer.Tick += new System.EventHandler(this.BlinkTimer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "SimpleTimer";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Х";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dTPicker
            // 
            this.dTPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dTPicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dTPicker.Location = new System.Drawing.Point(59, 26);
            this.dTPicker.Name = "dTPicker";
            this.dTPicker.ShowUpDown = true;
            this.dTPicker.Size = new System.Drawing.Size(166, 47);
            this.dTPicker.TabIndex = 1;
            this.dTPicker.Value = new System.DateTime(2015, 4, 24, 0, 2, 0, 0);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(290, 184);
            this.Controls.Add(this.dTPicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.checkBoxSound);
            this.Controls.Add(this.rbtnBlink);
            this.Controls.Add(this.rbtnJump);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbtnJump;
        private System.Windows.Forms.RadioButton rbtnBlink;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer BlinkTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTPicker;
    }
}

