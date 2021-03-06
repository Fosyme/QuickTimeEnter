﻿using System.Windows.Forms;

namespace LOLFlashRecorder
{
    public class GameTime
    {
        private uint minutes;   //分钟
        private uint seconds;   //秒钟

        //初始化游戏时间（自v1.3.0）
        public GameTime()
        {
            minutes = 0;
            seconds = 30;
        }

        public uint Minutes { get => minutes; set => minutes = value; }
        public uint Seconds { get => seconds; set => seconds = value; }

        public void SetGametime(string m, string s)
        {
            minutes = uint.Parse(m);
            seconds = uint.Parse(s);
        }

        //timer运行一次，游戏时间加一秒
        public void StartTimer(TextBox textBox)
        {
            string m;
            string s;

            //将时间格式统一化
            if (seconds < 59)
            {
                seconds++;
                if (seconds < 10)
                {
                    s = "0" + seconds.ToString();
                }
                else
                {
                    s = seconds.ToString();
                }
            }
            else
            {
                minutes++;
                seconds = 0;
                s = "00";
            }
            if (minutes < 10)
            {
                m = "0" + minutes.ToString();
            }
            else
            {
                if (minutes == 100)
                    minutes = 0;
                m = minutes.ToString();
            }
            textBox.Text = m + ":" + s;
        }

    }
}
