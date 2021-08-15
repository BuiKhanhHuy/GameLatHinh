using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
namespace BTTongHop1.LopHoTro
{
    class AmThanh
    {
        SoundPlayer nhacNen;
        SoundPlayer nhacThua;
        SoundPlayer nhacThang;
        SoundPlayer nhacChonDung;
        SoundPlayer nhacChonSai;
        SoundPlayer nhacSapHetTG;
        public AmThanh()
        {

        }
        public AmThanh(System.IO.UnmanagedMemoryStream urlnhacNen,
            System.IO.UnmanagedMemoryStream urlnhacThua,
            System.IO.UnmanagedMemoryStream urlnhacThang,
            System.IO.UnmanagedMemoryStream urlnhacChonDung,
            System.IO.UnmanagedMemoryStream urlnhacChonSai,
            System.IO.UnmanagedMemoryStream urlnhacSapHetTG)
        {
            nhacNen = new SoundPlayer(urlnhacNen);
            nhacThua = new SoundPlayer(urlnhacThua);
            nhacThang = new SoundPlayer(urlnhacThang);
            nhacChonDung = new SoundPlayer(urlnhacChonDung);
            nhacChonSai = new SoundPlayer(urlnhacChonSai);
            nhacSapHetTG = new SoundPlayer(urlnhacSapHetTG);
        }

        public void PhatNhacNen()
        {
            nhacNen.PlaySync();
        }
        public void NhacNenLapLai()
        {
            nhacNen.Play();
        }

        public void PhatNhacThua()
        {
            nhacThua.Play();
        }
        public void PhatNhacThang()
        {
            nhacThang.Play();
        }
        public void PhatNhacChonDung()
        {
            nhacChonDung.Play();
        }
        public void PhatNhacChonSai()
        {
            nhacChonSai.Play();
        }
        public void PhatNhacSapHetTG()
        {
            nhacSapHetTG.Play();
        }

        public void DungNhacNen()
        {
            nhacNen.Stop();
        }

        public void DungNhacThua()
        {
            nhacThua.Stop();
        }
        public void DungNhacThang()
        {
            nhacThang.Stop();
        }
        public void DungNhacChonDung()
        {
            nhacChonDung.Stop();
        }
        public void DungNhacChonSai()
        {
            nhacChonSai.Stop();
        }
        public void DungNhacSapHetTG()
        {
            nhacSapHetTG.Stop();
        }

        public SoundPlayer NhacNen
        {
            get { return nhacNen; }
            set { nhacNen = value; }
        }
        public SoundPlayer NhacThua
        {
            get { return nhacThua; }
            set { nhacThua = value; }
        }
        public SoundPlayer NhacThang
        {
            get { return nhacThang; }
            set { nhacThang = value; }
        }
        public SoundPlayer NhacChonDung
        {
            get { return nhacChonDung; }
            set { nhacChonDung = value; }
        }
        public SoundPlayer NhacChonSai
        {
            get { return nhacChonSai; }
            set { nhacChonSai = value; }
        }
        public SoundPlayer NhacSapHetTG
        {
            get { return nhacSapHetTG; }
            set { nhacSapHetTG = value; }
        }
    }
}
