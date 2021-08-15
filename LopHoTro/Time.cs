using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTongHop1.LopHoTro
{
    class Time
    {
        private int phut;
        private int giay;
        public Time()
        {
            this.phut = 0;
            this.giay = 0;
        }
        public Time(int phut, int giay)
        {
            this.phut = phut;
            this.giay = giay;
        }
        public Time(int phut)
        {
            this.phut = phut;
        }
        public int Phut
        {
            set { phut = value;
                if (phut < 0)
                    phut = 0;
            }
            get { return phut; }
        }
        public int Giay
        {
            set { giay = value;
                if (giay < 0)
                    giay = 0;
            }
            get { return giay; }
        }
        public string show()
        {
            return String.Format("{0:00}:{1:00}", this.phut, this.giay);
        }
    }
}
