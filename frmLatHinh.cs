using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;
using BTTongHop1.LopHoTro;
using System.Threading;

namespace BTTongHop1
{
    public partial class frmLatHinh : Form
    {
        // media
        private AmThanh amThanh;
        // Play và Pause
        private bool ON_OFF;
        // di chuyển form
        private Point diemClickManHinh;
        private int w, h;
        // time và level
        private int level;
        private Time time;
        // random
        private int n;
        private PictureBox[,] picOvuong;
        private int[,] giaTriOVuong;
        // gia trị của ô đầu được mở
        private int firstValue;
        private int i, j;

        public frmLatHinh()
        {
            InitializeComponent();
        }

        // load Form khi khởi động
        private void frmLatHinh_Load(object sender, EventArgs e)
        {
            amThanh = new AmThanh(Properties.Resources.amThanhNen,
               Properties.Resources.amThanhThua,
              Properties.Resources.amThanhThang,
               Properties.Resources.amThanhDung,
              Properties.Resources.amThanhChonSai,
               Properties.Resources.amThanhSapHetGio);
          
            level = 1;
            ON_OFF = false;
            n = 2;
            firstValue = -1; i = -1; j = -1;
            Refresh_form();
           
        }
        // refresh load lại Dữ liệu form
        private void Refresh_form()
        {
            panelMain.Controls.Clear();
            picOvuong = new PictureBox[n, n];
            giaTriOVuong = new int[n, n];
            khoiTaoGiaTriOVuong(n);
            this.lblLevel.Text = level.ToString();

            khoiTaoOVuong(level);
            khoiTaoThoiGian(level);
        }
        // Khởi tạo ô hình Pokemon
        private void khoiTaoOVuong(int level)
        {
            PictureBox pic;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    pic = new PictureBox();
                    pic.Size = new Size(600 / n - 4, 600 / n - 4);
                    pic.Location = new Point(j * (600 / n), i * (600 / n));
                    pic.Image = global::BTTongHop1.Properties.Resources.pokemon_go;
                    pic.SizeMode = PictureBoxSizeMode.Zoom;
                    pic.Name = "picPokemon#" + i + "#" + j;
                    pic.BackColor = Color.Black;
                    pic.Cursor = Cursors.Hand;
                    picOvuong[i, j] = pic;
                    picOvuong[i, j].MouseClick += PictureBox_Click;
                    panelMain.Controls.Add(pic);
                }
        }
        // Khởi tạo time
        private void khoiTaoThoiGian(int level)
        {
            int t;
            if (level == 1)
            {
                t = 1;
            }
            else
            if (level == 2)
                t = 3;
            else
                if (level == 3)
                t = 5;
            else
                t = 10;
            time = new Time(t);
            lblTime.Text = time.show();
        }
        // minimize
        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // close
        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // click di chuyển
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            this.diemClickManHinh = new Point(MousePosition.X, MousePosition.Y);
            this.w = e.X;
            this.h = e.Y;
        }
        // di chuyển
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseButtons == MouseButtons.Left)
                this.Location = new Point(MousePosition.X - w, MousePosition.Y - h);
        }
        // random giá trị các ô vuông
        private void khoiTaoGiaTriOVuong(int n)
        {
            Random rand = new Random();
            int number;
            int[] arrGTDaCo = new int[n * n];
            for (int i = 0; i < arrGTDaCo.Length; i++)
                arrGTDaCo[i] = -1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    number = rand.Next(0, (n * n) / 2);
                    while (kiemTra(arrGTDaCo, number) == false)
                    {
                        number = rand.Next(0, (n * n) / 2);
                    }
                    arrGTDaCo[n * i + j] = number;
                    giaTriOVuong[i, j] = number;

                    Console.Write(giaTriOVuong[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        // thời gian
        private void tmrTime_Tick(object sender, EventArgs e)
        {
            time.Giay--;
            if (time.Giay <= 0)
            {
                if (time.Phut <= 0)
                {
                    tmrTime.Stop();
                    lblTime.Text = time.show();
                    ON_OFF = false;
                    panelMain.Enabled = false;
                    panelMain.Controls.Clear();
                    //===> thua
                    Graphics g = panelMain.CreateGraphics();
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawString("GAME OVER", new Font("Showcard Gothic", 50, FontStyle.Bold),
                        Brushes.Red, new Rectangle(panelMain.Location.X, panelMain.Location.Y,
                        panelMain.ClientRectangle.Width, panelMain.ClientRectangle.Height), format);
                    btnPlay_Pause.BackgroundImage = global::BTTongHop1.Properties.Resources.play;
                    amThanh.PhatNhacThua();
                }
                time.Giay = 59;
                time.Phut--;
            }
            lblTime.Text = time.show();
        }

        // Hàm Play và Pause
        private void Play_Pause(bool OnOff)
        {
            if (ON_OFF == false)
            {
                panelMain.Enabled = true;
                tmrTime.Start();
                btnPlay_Pause.BackgroundImage = global::BTTongHop1.Properties.Resources.pause;
                ON_OFF = true;
            }
            else
            {
                panelMain.Enabled = false;
                tmrTime.Stop();
                btnPlay_Pause.BackgroundImage = global::BTTongHop1.Properties.Resources.play;
                ON_OFF = false;
            }
        }
        // play and pause Click
        private void btnPlay_Pause_Click(object sender, EventArgs e)
        {
            Play_Pause(ON_OFF);
        }
        // Lặp lại từ đầu
        private void btnReplay_Click(object sender, EventArgs e)
        {
            level = 1;
            n = 2;
            Refresh_form();
            Play_Pause(ON_OFF);
        }
        // kiểm tra chỉ hai ô được trùng giá trị hỗ trợ cho hàm random
        private bool kiemTra(int[] arr, int x)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (x == arr[i])
                    dem++;
                if (dem == 2)
                    return false;
            }
            return true;
        }
        // bắt sự kiện click cho từng pictureBox Pokemon
        private void PictureBox_Click(object o, MouseEventArgs e)
        {
            int i_index;
            int j_index;
            PictureBox picture_Pokemon = (PictureBox)o;
            string[] s = picture_Pokemon.Name.Split('#');
            //s[0] chỉ là tên tiền tố nên bỏ qua
            i_index = int.Parse(s[1]);
            j_index = int.Parse(s[2]);
            picOvuong[i_index, j_index].Image = imageListPokemon.Images[giaTriOVuong[i_index, j_index]];
            if (this.firstValue == -1)
            {
                // gán giá trị ô vừa click
                this.firstValue = giaTriOVuong[i_index, j_index];
                this.i = i_index;
                this.j = j_index;
            }
            else
            {
                // nếu hai ô khác nhau
                if (((i != i_index) || (j != j_index)))
                {

                    // hai ô cùng giá trị (chọn đúng)
                    if (this.firstValue == giaTriOVuong[i_index, j_index])
                    {
                        amThanh.PhatNhacChonDung();
                        this.BackColor = Color.Green;
                        wait(700);
                        this.BackColor = Color.Purple;
                        panelMain.Controls.Remove(picOvuong[i, j]);
                        panelMain.Controls.Remove(picOvuong[i_index, j_index]);
                    }
                    // hai ô không cùng giá trị (chọn sai)
                    else
                    {
                        amThanh.PhatNhacChonSai();
                        this.BackColor = Color.Red;
                        wait(700);
                        this.BackColor = Color.Purple;
                        picOvuong[i, j].Image = global::BTTongHop1.Properties.Resources.pokemon_go;
                        picOvuong[i_index, j_index].Image = global::BTTongHop1.Properties.Resources.pokemon_go;
                    }
                    this.i = -1;
                    this.j = -1;
                    this.firstValue = -1;
                }
            }

            if (panelMain.Controls.Count == 0)
            {
                if (n == 8)
                {
                    panelMain.Controls.Clear();
                    ON_OFF = false;
                    Graphics g = panelMain.CreateGraphics();
                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.DrawString("YOU WIN", new Font("Showcard Gothic", 72, FontStyle.Bold),
                        Brushes.Green, new Rectangle(panelMain.Location.X, panelMain.Location.Y,
                        panelMain.ClientRectangle.Width, panelMain.ClientRectangle.Height), format);
                    amThanh.PhatNhacThang();
                }
                else
                {
                    level++;
                    n += 2;
                    amThanh.PhatNhacThang();
                    Refresh_form();
                }
            }
        }
        // wait
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
    }
}
