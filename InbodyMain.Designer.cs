namespace Inbody
{
    partial class InbodyMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InbodyMain));
            this.timer_menu = new System.Windows.Forms.Timer(this.components);
            this.pn_titlebar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.fpn_menu = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_menu = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rdo_home = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdo_analysis = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rdo_settings = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdo_info = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdo_folder = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rdo_progress = new System.Windows.Forms.RadioButton();
            this.pn_main = new System.Windows.Forms.Panel();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.pn_titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.fpn_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_menu
            // 
            this.timer_menu.Interval = 5;
            this.timer_menu.Tick += new System.EventHandler(this.timer_menu_Tick);
            // 
            // pn_titlebar
            // 
            this.pn_titlebar.BackColor = System.Drawing.Color.White;
            this.pn_titlebar.Controls.Add(this.pictureBox1);
            this.pn_titlebar.Controls.Add(this.btn_close);
            this.pn_titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_titlebar.Location = new System.Drawing.Point(0, 0);
            this.pn_titlebar.Name = "pn_titlebar";
            this.pn_titlebar.Size = new System.Drawing.Size(1088, 42);
            this.pn_titlebar.TabIndex = 2;
            this.pn_titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_titlebar_MouseDown);
            this.pn_titlebar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_titlebar_MouseMove);
            this.pn_titlebar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_titlebar_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inbody.Properties.Resources.InbodyNoBackground;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(210)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(1039, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(46, 37);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Controls.Add(this.lbl_time);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 725);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1088, 38);
            this.panel8.TabIndex = 5;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_time.Location = new System.Drawing.Point(861, 7);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(67, 23);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "label2";
            // 
            // fpn_menu
            // 
            this.fpn_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190)))));
            this.fpn_menu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpn_menu.Controls.Add(this.panel1);
            this.fpn_menu.Controls.Add(this.panel5);
            this.fpn_menu.Controls.Add(this.panel3);
            this.fpn_menu.Controls.Add(this.panel7);
            this.fpn_menu.Controls.Add(this.panel4);
            this.fpn_menu.Controls.Add(this.panel2);
            this.fpn_menu.Controls.Add(this.panel6);
            this.fpn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.fpn_menu.Location = new System.Drawing.Point(0, 42);
            this.fpn_menu.MaximumSize = new System.Drawing.Size(200, 763);
            this.fpn_menu.MinimumSize = new System.Drawing.Size(55, 500);
            this.fpn_menu.Name = "fpn_menu";
            this.fpn_menu.Size = new System.Drawing.Size(200, 683);
            this.fpn_menu.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pic_menu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 81);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard SemiBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(90, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU";
            // 
            // pic_menu
            // 
            this.pic_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_menu.Image = global::Inbody.Properties.Resources._512menu;
            this.pic_menu.Location = new System.Drawing.Point(0, 15);
            this.pic_menu.Name = "pic_menu";
            this.pic_menu.Size = new System.Drawing.Size(50, 50);
            this.pic_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_menu.TabIndex = 0;
            this.pic_menu.TabStop = false;
            this.pic_menu.Click += new System.EventHandler(this.pic_menu_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rdo_home);
            this.panel5.Location = new System.Drawing.Point(3, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 85);
            this.panel5.TabIndex = 2;
            // 
            // rdo_home
            // 
            this.rdo_home.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_home.Checked = true;
            this.rdo_home.FlatAppearance.BorderSize = 0;
            this.rdo_home.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.rdo_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rdo_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_home.Font = new System.Drawing.Font("Pretendard SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdo_home.Image = ((System.Drawing.Image)(resources.GetObject("rdo_home.Image")));
            this.rdo_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdo_home.Location = new System.Drawing.Point(0, 15);
            this.rdo_home.Name = "rdo_home";
            this.rdo_home.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rdo_home.Size = new System.Drawing.Size(192, 53);
            this.rdo_home.TabIndex = 0;
            this.rdo_home.TabStop = true;
            this.rdo_home.Text = "Home";
            this.rdo_home.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_home.UseVisualStyleBackColor = true;
            this.rdo_home.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdo_analysis);
            this.panel3.Location = new System.Drawing.Point(3, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 85);
            this.panel3.TabIndex = 2;
            // 
            // rdo_analysis
            // 
            this.rdo_analysis.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_analysis.FlatAppearance.BorderSize = 0;
            this.rdo_analysis.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.rdo_analysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_analysis.Font = new System.Drawing.Font("Pretendard SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdo_analysis.Image = global::Inbody.Properties.Resources.analysis;
            this.rdo_analysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdo_analysis.Location = new System.Drawing.Point(1, 17);
            this.rdo_analysis.Name = "rdo_analysis";
            this.rdo_analysis.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rdo_analysis.Size = new System.Drawing.Size(192, 53);
            this.rdo_analysis.TabIndex = 0;
            this.rdo_analysis.TabStop = true;
            this.rdo_analysis.Text = "Analysis";
            this.rdo_analysis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_analysis.UseVisualStyleBackColor = true;
            this.rdo_analysis.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rdo_settings);
            this.panel7.Location = new System.Drawing.Point(3, 272);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(197, 85);
            this.panel7.TabIndex = 3;
            // 
            // rdo_settings
            // 
            this.rdo_settings.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_settings.FlatAppearance.BorderSize = 0;
            this.rdo_settings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.rdo_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_settings.Font = new System.Drawing.Font("Pretendard SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdo_settings.Image = ((System.Drawing.Image)(resources.GetObject("rdo_settings.Image")));
            this.rdo_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdo_settings.Location = new System.Drawing.Point(0, 17);
            this.rdo_settings.Name = "rdo_settings";
            this.rdo_settings.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rdo_settings.Size = new System.Drawing.Size(192, 53);
            this.rdo_settings.TabIndex = 0;
            this.rdo_settings.TabStop = true;
            this.rdo_settings.Text = "Settings";
            this.rdo_settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_settings.UseVisualStyleBackColor = true;
            this.rdo_settings.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdo_info);
            this.panel4.Location = new System.Drawing.Point(3, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 85);
            this.panel4.TabIndex = 3;
            // 
            // rdo_info
            // 
            this.rdo_info.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_info.FlatAppearance.BorderSize = 0;
            this.rdo_info.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.rdo_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_info.Font = new System.Drawing.Font("Pretendard SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdo_info.Image = global::Inbody.Properties.Resources.info;
            this.rdo_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdo_info.Location = new System.Drawing.Point(1, 18);
            this.rdo_info.Name = "rdo_info";
            this.rdo_info.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rdo_info.Size = new System.Drawing.Size(192, 53);
            this.rdo_info.TabIndex = 0;
            this.rdo_info.TabStop = true;
            this.rdo_info.Text = "About Us";
            this.rdo_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_info.UseVisualStyleBackColor = true;
            this.rdo_info.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdo_folder);
            this.panel2.Location = new System.Drawing.Point(3, 454);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 85);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // rdo_folder
            // 
            this.rdo_folder.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_folder.FlatAppearance.BorderSize = 0;
            this.rdo_folder.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.rdo_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_folder.Font = new System.Drawing.Font("Pretendard SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdo_folder.Image = global::Inbody.Properties.Resources.folder;
            this.rdo_folder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdo_folder.Location = new System.Drawing.Point(0, 17);
            this.rdo_folder.Name = "rdo_folder";
            this.rdo_folder.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rdo_folder.Size = new System.Drawing.Size(194, 53);
            this.rdo_folder.TabIndex = 0;
            this.rdo_folder.TabStop = true;
            this.rdo_folder.Text = "Folder";
            this.rdo_folder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_folder.UseVisualStyleBackColor = true;
            this.rdo_folder.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.rdo_progress);
            this.panel6.Location = new System.Drawing.Point(3, 545);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 85);
            this.panel6.TabIndex = 4;
            this.panel6.Visible = false;
            // 
            // rdo_progress
            // 
            this.rdo_progress.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_progress.FlatAppearance.BorderSize = 0;
            this.rdo_progress.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.rdo_progress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_progress.Font = new System.Drawing.Font("Pretendard SemiBold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rdo_progress.Image = ((System.Drawing.Image)(resources.GetObject("rdo_progress.Image")));
            this.rdo_progress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdo_progress.Location = new System.Drawing.Point(1, 17);
            this.rdo_progress.Name = "rdo_progress";
            this.rdo_progress.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.rdo_progress.Size = new System.Drawing.Size(194, 53);
            this.rdo_progress.TabIndex = 0;
            this.rdo_progress.TabStop = true;
            this.rdo_progress.Text = "Progress";
            this.rdo_progress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_progress.UseVisualStyleBackColor = true;
            this.rdo_progress.Click += new System.EventHandler(this.UserControlButton_Click);
            // 
            // pn_main
            // 
            this.pn_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(200, 42);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(888, 683);
            this.pn_main.TabIndex = 9;
            // 
            // timer_time
            // 
            this.timer_time.Interval = 1000;
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // InbodyMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 763);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.fpn_menu);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pn_titlebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InbodyMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pn_titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.fpn_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_menu)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_menu;
        private System.Windows.Forms.Panel pn_titlebar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.FlowLayoutPanel fpn_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_menu;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.RadioButton rdo_home;
        private System.Windows.Forms.RadioButton rdo_folder;
        private System.Windows.Forms.RadioButton rdo_analysis;
        private System.Windows.Forms.RadioButton rdo_settings;
        private System.Windows.Forms.RadioButton rdo_info;
        private System.Windows.Forms.RadioButton rdo_progress;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

