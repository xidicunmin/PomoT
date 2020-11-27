using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Configuration;

namespace EasyPomo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TimeSpan _workTime;
        TimeSpan _restTime;
        TimeSpan _intervalTime;
        bool _isWork;
        int wt = 25;
        int rt = 5;
        bool _isCloseBack;


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = MinimumSize;
            //读取配置
            string w = GetValue("WorkTime");
            if (w == "")
            {
                wt = 25;
                SetValue("WorkTime", wt.ToString());
            }
            else 
            {
                wt = int.Parse(w);
            }

            string r = GetValue("RestTime");
            if (r == "")
            {
                rt = 5;
                SetValue("RestTime", rt.ToString());
            }
            else
            {
                rt = int.Parse(r);
            }

            string top = GetValue("OnTop");
            if (top == "")
            {
                ckbOnTop.Checked = false;
                SetValue("OnTop", "false");
            }
            else
            {
                ckbOnTop.Checked = bool.Parse(top);
            }

            string closeBack = GetValue("CloseBack");
            if (closeBack == "")
            {
                _isCloseBack = false;
                SetValue("CloseBack", "false");
            }
            else
            {
                _isCloseBack = bool.Parse(closeBack);
            }

            nudWt.Value = wt;
            nudRt.Value = rt;
            chkCloseBack.Checked = _isCloseBack;

            InitTime();

            timer1.Interval = 100;
            _intervalTime = new TimeSpan(0, 0, 0, 0, timer1.Interval);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isWork)
            {
                if (_workTime.TotalSeconds > 0)
                {
                    _workTime = _workTime.Subtract(_intervalTime);
                    lblWorkTime.Text = TimeSpanToString(_workTime);
                }
                else
                {
                    _isWork = false;
                    notifyIcon1.ShowBalloonTip(1000, "提示：", "工作结束！休息一下吧！", ToolTipIcon.Info);
                }
            }
            else 
            {
                if (_restTime.TotalSeconds > 0)
                {
                    _restTime = _restTime.Subtract(_intervalTime);
                    lblRestTime.Text = TimeSpanToString(_restTime);
                }
                else
                {
                    _isWork = true;
                    timer1.Enabled = false;
                    InitTime();

                    btnChangeStatus.Text = "开始";
                    //Task.Factory.StartNew(() =>
                    //{
                    //    MessageBox.Show("完成！再来一个番茄钟吧！");
                    //});
                    notifyIcon1.ShowBalloonTip(1000, "提示：", "休息结束！再来一个番茄钟吧！", ToolTipIcon.Info);
                }
            }
           
        }

        private void InitTime()
        {
            _workTime = new TimeSpan(0, 0, wt, 0, 0);
            lblWorkTime.Text = TimeSpanToString(_workTime);
            _restTime = new TimeSpan(0, 0, rt, 0, 0);
            lblRestTime.Text = TimeSpanToString(_restTime);
        }

        private string TimeSpanToString(TimeSpan ts)
        {
            string time = "00:00:00";
            try
            {
                DateTime dTime = DateTime.MinValue.Add(ts);
                time = dTime.ToString("mm:ss:ff");
            }
            catch (Exception)
            {
                
            }
           
           
            return time;
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            PomoStart(btnChangeStatus.Text == "开始");
        }

        private void PomoStart(bool isStart)
        {
            if (isStart)
            {
                SettingShow(false);
                _isWork = true;
                timer1.Enabled = true;
                btnChangeStatus.Text = tsmChangeStatus.Text = "中断";
                lklSetting.Enabled = false;
            }
            else
            {
                InitTime();
                timer1.Enabled = false;
                btnChangeStatus.Text = tsmChangeStatus.Text = "开始";
                lklSetting.Enabled = true;
            }
        }

        private void lklSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SettingShow(lklSetting.Text == "打开设置");
        }

        private void SettingShow(bool isShow)
        {
            if (isShow)
            {
                Size = MaximumSize;
                lklSetting.Text = "收起设置";
            }
            else
            {
                Size = MinimumSize;
                lklSetting.Text = "打开设置";
            }
        }

        private void ckbOnTop_CheckedChanged(object sender, EventArgs e)
        {
            SetValue("OnTop", ckbOnTop.Checked.ToString());
            TopMost = ckbOnTop.Checked ? true : false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            wt = (int)nudWt.Value;
            SetValue("WorkTime", wt.ToString());
            rt = (int)nudRt.Value;
            SetValue("RestTime", rt.ToString());
            _isCloseBack = chkCloseBack.Checked;
            SetValue("CloseBack", _isCloseBack.ToString());
            InitTime();
            MessageBox.Show("生效成功");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isCloseBack)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                {
                    e.Cancel = true;
                    Hide();
                    notifyIcon1.ShowBalloonTip(1000, "提示：", "EasyPomo躲到后台了！", ToolTipIcon.Info);
                }
            }
        }

        private void tsmChangeStatus_Click(object sender, EventArgs e)
        {
            PomoStart(btnChangeStatus.Text == "开始");
        }

        private void tsmClose_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
            Application.Exit();
            Environment.Exit(0);
        }

        private void tsmShow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }

        /// <summary>  
        /// 写入值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <param name="value"></param>  
        public static void SetValue(string key, string value)
        {
            //增加的内容写在appSettings段下 <add key="RegCode" value="0"/>  
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
            {
                config.AppSettings.Settings.Add(key, value);
            }
            else
            {
                config.AppSettings.Settings[key].Value = value;
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");//重新加载新的配置文件   
        }

        /// <summary>  
        /// 读取指定key的值  
        /// </summary>  
        /// <param name="key"></param>  
        /// <returns></returns>  
        public static string GetValue(string key)
        {
            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (config.AppSettings.Settings[key] == null)
                return "";
            else
                return config.AppSettings.Settings[key].Value;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Show();
            Activate();
        }

        private void notifyIcon1_MouseMove(object sender, MouseEventArgs e)
        {
            notifyIcon1.Text = string.Format("工作时间：{0}\r\n休息时间：{1}", lblWorkTime.Text, lblRestTime.Text);
        }
    }
}
