namespace BTTongHop1
{
    partial class frmLatHinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLatHinh));
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.imageListPokemon = new System.Windows.Forms.ImageList(this.components);
            this.panelFoter = new System.Windows.Forms.Panel();
            this.btnReplay = new System.Windows.Forms.Button();
            this.picClockImage = new System.Windows.Forms.PictureBox();
            this.btnPlay_Pause = new System.Windows.Forms.Button();
            this.lblLevel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panelFoter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClockImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.panelMain.Enabled = false;
            this.panelMain.ForeColor = System.Drawing.Color.Black;
            this.panelMain.Location = new System.Drawing.Point(6, 62);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 600);
            this.panelMain.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.White;
            this.lblTieuDe.Location = new System.Drawing.Point(51, 12);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(115, 25);
            this.lblTieuDe.TabIndex = 4;
            this.lblTieuDe.Text = "POKEMON";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.picMinimize);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.picIcon);
            this.panel1.Controls.Add(this.lblTieuDe);
            this.panel1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 57);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // picMinimize
            // 
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.picMinimize.Image = global::BTTongHop1.Properties.Resources.minus;
            this.picMinimize.Location = new System.Drawing.Point(535, 10);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(34, 31);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 2;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // picClose
            // 
            this.picClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.picClose.Image = global::BTTongHop1.Properties.Resources.close;
            this.picClose.Location = new System.Drawing.Point(573, 10);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(34, 31);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 1;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picIcon
            // 
            this.picIcon.Image = global::BTTongHop1.Properties.Resources.iconPokemon;
            this.picIcon.Location = new System.Drawing.Point(2, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(52, 48);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // imageListPokemon
            // 
            this.imageListPokemon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListPokemon.ImageStream")));
            this.imageListPokemon.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListPokemon.Images.SetKeyName(0, "image1.png");
            this.imageListPokemon.Images.SetKeyName(1, "image2.png");
            this.imageListPokemon.Images.SetKeyName(2, "image3.png");
            this.imageListPokemon.Images.SetKeyName(3, "image4.png");
            this.imageListPokemon.Images.SetKeyName(4, "image5.png");
            this.imageListPokemon.Images.SetKeyName(5, "image6.png");
            this.imageListPokemon.Images.SetKeyName(6, "image7.png");
            this.imageListPokemon.Images.SetKeyName(7, "image8.png");
            this.imageListPokemon.Images.SetKeyName(8, "image9.png");
            this.imageListPokemon.Images.SetKeyName(9, "image10.png");
            this.imageListPokemon.Images.SetKeyName(10, "image11.png");
            this.imageListPokemon.Images.SetKeyName(11, "image12.png");
            this.imageListPokemon.Images.SetKeyName(12, "image13.png");
            this.imageListPokemon.Images.SetKeyName(13, "image14.png");
            this.imageListPokemon.Images.SetKeyName(14, "image15.png");
            this.imageListPokemon.Images.SetKeyName(15, "image16.png");
            this.imageListPokemon.Images.SetKeyName(16, "image17.png");
            this.imageListPokemon.Images.SetKeyName(17, "image18.png");
            this.imageListPokemon.Images.SetKeyName(18, "image19.png");
            this.imageListPokemon.Images.SetKeyName(19, "image20.png");
            this.imageListPokemon.Images.SetKeyName(20, "image21.png");
            this.imageListPokemon.Images.SetKeyName(21, "image22.png");
            this.imageListPokemon.Images.SetKeyName(22, "image23.png");
            this.imageListPokemon.Images.SetKeyName(23, "image24.png");
            this.imageListPokemon.Images.SetKeyName(24, "image25.png");
            this.imageListPokemon.Images.SetKeyName(25, "image26.png");
            this.imageListPokemon.Images.SetKeyName(26, "image27.png");
            this.imageListPokemon.Images.SetKeyName(27, "image28.png");
            this.imageListPokemon.Images.SetKeyName(28, "image29.png");
            this.imageListPokemon.Images.SetKeyName(29, "image30.png");
            this.imageListPokemon.Images.SetKeyName(30, "image31.png");
            this.imageListPokemon.Images.SetKeyName(31, "image32.png");
            // 
            // panelFoter
            // 
            this.panelFoter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelFoter.Controls.Add(this.btnReplay);
            this.panelFoter.Controls.Add(this.picClockImage);
            this.panelFoter.Controls.Add(this.btnPlay_Pause);
            this.panelFoter.Controls.Add(this.lblLevel);
            this.panelFoter.Controls.Add(this.label2);
            this.panelFoter.Controls.Add(this.lblTime);
            this.panelFoter.Location = new System.Drawing.Point(6, 668);
            this.panelFoter.Name = "panelFoter";
            this.panelFoter.Size = new System.Drawing.Size(600, 52);
            this.panelFoter.TabIndex = 6;
            // 
            // btnReplay
            // 
            this.btnReplay.BackgroundImage = global::BTTongHop1.Properties.Resources.repeat_icon;
            this.btnReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplay.Location = new System.Drawing.Point(310, 6);
            this.btnReplay.Name = "btnReplay";
            this.btnReplay.Size = new System.Drawing.Size(40, 40);
            this.btnReplay.TabIndex = 5;
            this.btnReplay.UseVisualStyleBackColor = true;
            this.btnReplay.Click += new System.EventHandler(this.btnReplay_Click);
            // 
            // picClockImage
            // 
            this.picClockImage.Image = global::BTTongHop1.Properties.Resources.time;
            this.picClockImage.Location = new System.Drawing.Point(3, 3);
            this.picClockImage.Name = "picClockImage";
            this.picClockImage.Size = new System.Drawing.Size(46, 49);
            this.picClockImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClockImage.TabIndex = 0;
            this.picClockImage.TabStop = false;
            // 
            // btnPlay_Pause
            // 
            this.btnPlay_Pause.BackgroundImage = global::BTTongHop1.Properties.Resources.play;
            this.btnPlay_Pause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay_Pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay_Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay_Pause.Location = new System.Drawing.Point(261, 6);
            this.btnPlay_Pause.Name = "btnPlay_Pause";
            this.btnPlay_Pause.Size = new System.Drawing.Size(40, 40);
            this.btnPlay_Pause.TabIndex = 4;
            this.btnPlay_Pause.UseVisualStyleBackColor = true;
            this.btnPlay_Pause.Click += new System.EventHandler(this.btnPlay_Pause_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.Yellow;
            this.lblLevel.Location = new System.Drawing.Point(231, 10);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(17, 28);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(136, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTime.Location = new System.Drawing.Point(48, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(96, 35);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // frmLatHinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(613, 726);
            this.Controls.Add(this.panelFoter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLatHinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmLatHinh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panelFoter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picClockImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageListPokemon;
        private System.Windows.Forms.Panel panelFoter;
        private System.Windows.Forms.PictureBox picClockImage;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Button btnPlay_Pause;
        private System.Windows.Forms.Button btnReplay;
    }
}

