using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleTimer
{
    public partial class Form1 : Form
    {
        private bool blink;
        private bool SoundOn;
        private bool IsRunning;
        private bool IconRed;
        private bool MsDown;

        private Point MsPoint;

        private TimeSpan VremyaOstalos;
        private DateTime VremSobitiya;
        private struct Vreamya
        {
            public byte H;
            public byte M;
            public byte S;
        }
        private Vreamya TimeStart;

        public Form1()
        {
            InitializeComponent();
            blink = false;
            SoundOn = false;
            IsRunning = false;
            
        }
        
        // ЗАГРУЗКА ФОРМЫ
        private void Form1_Load(object sender, EventArgs e)
        {
            blink = Properties.Settings.Default.Blink;
            if (blink)
                rbtnBlink.Checked = true;
            else
                rbtnJump.Checked = true;
            
            SoundOn = Properties.Settings.Default.Sound;
            checkBoxSound.Checked = SoundOn;

            textBox1.Text = Properties.Settings.Default.MsgText;
        }
        

        // СТАРТ.Click
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsRunning)
            {   // если уже запущено - остановливаем
                StopTimer();
            }
            else
            {   // если не зпущено - запускаем
                //if (!proverka())
                  //  return;

                DisableControlls(true);
                //VremyaOstalos = new TimeSpan((int)numHours.Value, (int)numMinutes.Value, (int)numSecond.Value);
                VremyaOstalos = new TimeSpan(dTPicker.Value.Hour, dTPicker.Value.Minute, dTPicker.Value.Second);
                VremSobitiya = DateTime.Now + VremyaOstalos;
                MainTimer.Start();
                notifyIcon1.Visible = true;
                IconRed = true;
                IsRunning = true;
                //TimeStart.H = (byte)numHours.Value;
                //TimeStart.M = (byte)numMinutes.Value;
                //TimeStart.S = (byte)numSecond.Value;
                TimeStart.H = (byte)dTPicker.Value.Hour;
                TimeStart.M = (byte)dTPicker.Value.Minute;
                TimeStart.S = (byte)dTPicker.Value.Second;
            }
        }


        // СТОП
        private void StopTimer()
        {
            MainTimer.Stop();
            BlinkTimer.Stop();
            DisableControlls(false);
            IsRunning = false;
            //numHours.Value = TimeStart.H;
            //numMinutes.Value = TimeStart.M;
            //numSecond.Value = TimeStart.S;
            //dTPicker.Value.Second
            dTPicker.Value = new DateTime(2015, 04, 24, TimeStart.H, TimeStart.M, TimeStart.S);
        }
        

        // ТАЙМЕР ОТСЧЕТА ВРЕМЕНИ
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            MainTimer.Stop();
            DateTime DTNow = DateTime.Now;
            if (DTNow < VremSobitiya)
            {
                // РАНО
                VremyaOstalos = VremSobitiya - DTNow;

                // обновить счетчики
                ShowRemainingTime();

                // Перезапустить таймер
                MainTimer.Start();
            }
            else
            {
                // ПОРА
                TimeOver();
            }
        }


        // ВРЕМЯ ВЫШЛО
        private void TimeOver()
        {
            StopTimer();
            
            notifyIcon1.BalloonTipText = textBox1.Text;
            notifyIcon1.ShowBalloonTip(1000);


            if (SoundOn)
            {
                // ГУДИМ
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"D:\Visual Studio 2010\!Projects\SimpleTimer\SimpleTimer\res\18.wav");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.zvonok_2_sec);
                player.Play();
            }

            if (blink)
            {
                // МОРГАЕМ
                BlinkTimer.Start();

            }
            else
            {
                // ВЫСКАКИВАЕМ
                //DisableControlls(false);
                SignalForm SF = new SignalForm(textBox1.Text);
                SF.ShowDialog();

                // Отбразить форму
                this.Show();

                // развернуть окно
                this.WindowState = FormWindowState.Normal;
            }
            
            
        }


        // ПОКАЗАТЬ ОСТАВШЕЕСЯ ВРЕМЯ
        private void ShowRemainingTime()
        {
            int H = VremyaOstalos.Hours;
            int M = VremyaOstalos.Minutes;
            int S = VremyaOstalos.Seconds;

            //numHours.Value = H;
            //numMinutes.Value = M;
            //numSecond.Value = S;
            dTPicker.Value = new DateTime(2015, 04, 24, H, M, S);

            string str = "SimpleTimer-" + H.ToString() + ":";
            if (M < 10) str += "0";
            str += M.ToString() + ":";
            if (S < 10) str += "0";
            str += S.ToString();

            notifyIcon1.Text = str;
        }


        // ПРОВЕРКА ВВЕДННЫХ ЗНАЧЕНИЙ
        /*
        private bool proverka()
        {
            if (numHours.Value >= 0 && numHours.Value < 24)
            {
                if (numMinutes.Value >= 0 && numMinutes.Value <= 60)
                {
                    if (numSecond.Value >= 0 && numSecond.Value <= 60)
                    { }
                    else
                        return false;
                }
                else
                    return false;
            }
            else
                return false;

            return true;
        }
        */

        // ЗАБЛОКИРОВАТЬ/РАЗБЛОКИРОВАТЬ КОНТРОЛЫ
        private void DisableControlls(bool disblctrl)
        {
            if (disblctrl)
            {
                // заблокировать
                /*
                numHours.Enabled = false;
                numMinutes.Enabled = false;
                numSecond.Enabled = false;
                numHours.BackColor = Color.OliveDrab;
                numMinutes.BackColor = Color.OliveDrab;
                numSecond.BackColor = Color.OliveDrab;                
                 */
                dTPicker.Enabled = false;
                btnStart.Text = "-- С  Т  О  П --";
            }
            else
            {
                // разблокировать
                /*
                numHours.Enabled = true;
                numMinutes.Enabled = true;
                numSecond.Enabled = true;
                numHours.BackColor = Color.GreenYellow;
                numMinutes.BackColor = Color.GreenYellow;
                numSecond.BackColor = Color.GreenYellow;
                 */
                dTPicker.Enabled = true;
                btnStart.Text = "= С  Т  А  Р  Т =";
            }

        }


        // ТАЙМЕР МОРГАНИЯ
        private void BlinkTimer_Tick(object sender, EventArgs e)
        {
            BlinkTimer.Stop();
            if (IconRed)
                notifyIcon1.Icon = SimpleTimer.Properties.Resources.clockgreen;
            else
                notifyIcon1.Icon = SimpleTimer.Properties.Resources.clockred;
            IconRed = !IconRed;
            BlinkTimer.Start();
        }
        

        // КЛИК ПО ИКОНКЕ В ТРЕЕ
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // остановить моргание
            BlinkTimer.Stop();

            // скрыть иконку
            notifyIcon1.Visible = false;
            
            // Отбразить форму
            this.Show();
            
            // развернуть окно
            this.WindowState = FormWindowState.Normal;

        }

        
        // ЗАКРЫТИЕ ФОРМЫ
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Blink = blink;
            Properties.Settings.Default.Sound = SoundOn;
            Properties.Settings.Default.MsgText = textBox1.Text;
            
            Properties.Settings.Default.Save();
        }


        private void rbtnJump_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnJump.Checked)
                blink = false;
        }

        private void rbtnBlink_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBlink.Checked)
                blink = true;
        }

        private void checkBoxSound_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSound.Checked)
                SoundOn = true;
            else
                SoundOn = false;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Icon = Properties.Resources.clockblue_113;
                notifyIcon1.Visible = true;
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            MsDown = true;
            MsPoint = new Point(MousePosition.X - this.Left, MousePosition.Y - this.Top);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            MsDown = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MsDown)
            {
                this.Location = new Point(MousePosition.X - MsPoint.X, MousePosition.Y - MsPoint.Y);
            }
        }

       


        

        
        
        

        
    }
}
