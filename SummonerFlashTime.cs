﻿using System.Windows.Forms;

namespace LOLFlashRecorder
{
    public class SummonerFlashTime
    {
        //存储每个位置的剩余时间
        private uint[] time;

        //初始化每个位置的时间，主要用于创建对象
        public SummonerFlashTime()
        {
            time = new uint[5];
            for (int i = 0; i < 5; i++)
            {
                time[i] = 0;
            }
        }

        public uint[] Time { get => time; set => time = value; }

        //初始化每个位置的时间，主要用于初始化对象
        public void StartInput(params Label[] labels)
        {
            time = new uint[5];
            for (int i = 0; i < 5; i++)
            {
                time[i] =
                    (labels[i].Text.Equals("") || labels[i].Text == null || labels[i].Text.Equals("0")) ?
                    0 : uint.Parse(labels[i].Text);
            }
        }

        //timer一次,时间减少一秒
        public void FlashETA(params Label[] labels)
        {
            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = time[i] == 0 ? "" : (--time[i]).ToString();
            }
        }

    }
}
