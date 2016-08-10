using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    // File: tv.cs

    class Television
    {
        private int channel = 0;
        private int volume = 0;
        private bool isOn = false;
        
        public int Channel
        {
            get
            {
                return channel;
            }
            set
            {
                if (value > 0 && value < 50)
                {
                    channel = value;
                }
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value < 100 && value > 0)
                {
                    volume = value;
                }
            }
        }
        public bool IsOn
        {
            get
            {
                return isOn;
            }
            set
            {
                isOn = value;
            }
        }
        public void TurnOn()
        {
            isOn = true;
            // do the code to turn the tv on
        }
        public void TurnOff()
        {
            isOn = false;
            // do the code to turn the tv off
        }
        public int CurrentVolume()
        {
            return volume;
        }
        public void IncreaseVolume()
        {
            if (volume < 100)
            {
                volume = volume + 1;
                // do the code to increase the volume
            }
        }
        public void DecreaseVolume()
        {
            if (volume > 0)
            {
                volume = volume - 1;
                // do the code to decrease the volume
            }
        }
        public int CurrentChannel()
        {
            return channel;
        }
        public void ChangeChannel(int Channel)
        {
            if (Channel > 0 && Channel < 50)
            {
                channel = Channel;
                // do the code to change the
                // channel on the tv
            }
        }
    }

    class TestTV
    {
        static void Main()
        {
            Television tv = new Television();

            if (!tv.IsOn)
            {
                tv.IsOn = true;
            }

            tv.Channel = 3;

            tv.Volume++;
            tv.Volume++;
            tv.Volume++;
            tv.Volume++;

            tv.IsOn = false;
        }
    }
}
