namespace Inbody.usercontrols.Overview
{
    partial class UC_DashBoardMenu
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_memberNum = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pn_dashboard = new System.Windows.Forms.Panel();
            this.btn_dashBoard = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btn_detail = new System.Windows.Forms.Button();
            this.pn_detail = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_change = new System.Windows.Forms.Button();
            this.pn_change = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.pn_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lbl_memberNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 75);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inbody.Properties.Resources.InbodyLogoBlack;
            this.pictureBox1.Location = new System.Drawing.Point(14, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(494, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "회원번호 : ";
            // 
            // lbl_memberNum
            // 
            this.lbl_memberNum.AutoSize = true;
            this.lbl_memberNum.Font = new System.Drawing.Font("Pretendard Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_memberNum.Location = new System.Drawing.Point(594, 22);
            this.lbl_memberNum.Name = "lbl_memberNum";
            this.lbl_memberNum.Size = new System.Drawing.Size(107, 25);
            this.lbl_memberNum.TabIndex = 2;
            this.lbl_memberNum.Text = "회원번호 : ";
            // 
            // btn_logout
            // 
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Pretendard SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_logout.Location = new System.Drawing.Point(787, 20);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(75, 34);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "로그아웃";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel19);
            this.panel5.Controls.Add(this.panel18);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 608);
            this.panel5.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel20);
            this.panel2.Controls.Add(this.panel21);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(694, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 608);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel13);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(194, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 52);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_dashBoard);
            this.panel4.Controls.Add(this.pn_dashboard);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(166, 52);
            this.panel4.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(20, 52);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(146, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(20, 52);
            this.panel7.TabIndex = 1;
            // 
            // pn_dashboard
            // 
            this.pn_dashboard.BackColor = System.Drawing.Color.White;
            this.pn_dashboard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_dashboard.Location = new System.Drawing.Point(20, 47);
            this.pn_dashboard.Name = "pn_dashboard";
            this.pn_dashboard.Size = new System.Drawing.Size(126, 5);
            this.pn_dashboard.TabIndex = 2;
            // 
            // btn_dashBoard
            // 
            this.btn_dashBoard.BackColor = System.Drawing.Color.White;
            this.btn_dashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dashBoard.FlatAppearance.BorderSize = 0;
            this.btn_dashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashBoard.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_dashBoard.Location = new System.Drawing.Point(20, 0);
            this.btn_dashBoard.Name = "btn_dashBoard";
            this.btn_dashBoard.Size = new System.Drawing.Size(126, 47);
            this.btn_dashBoard.TabIndex = 3;
            this.btn_dashBoard.Text = "대시보드";
            this.btn_dashBoard.UseVisualStyleBackColor = false;
            this.btn_dashBoard.Click += new System.EventHandler(this.MenuButtonClickEvent);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btn_detail);
            this.panel9.Controls.Add(this.pn_detail);
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel12);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(166, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(166, 52);
            this.panel9.TabIndex = 24;
            // 
            // btn_detail
            // 
            this.btn_detail.BackColor = System.Drawing.Color.White;
            this.btn_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_detail.FlatAppearance.BorderSize = 0;
            this.btn_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_detail.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_detail.Location = new System.Drawing.Point(20, 0);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(126, 47);
            this.btn_detail.TabIndex = 3;
            this.btn_detail.Text = "상세";
            this.btn_detail.UseVisualStyleBackColor = false;
            this.btn_detail.Click += new System.EventHandler(this.MenuButtonClickEvent);
            // 
            // pn_detail
            // 
            this.pn_detail.BackColor = System.Drawing.Color.White;
            this.pn_detail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_detail.Location = new System.Drawing.Point(20, 47);
            this.pn_detail.Name = "pn_detail";
            this.pn_detail.Size = new System.Drawing.Size(126, 5);
            this.pn_detail.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(146, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(20, 52);
            this.panel11.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.White;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(20, 52);
            this.panel12.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_change);
            this.panel13.Controls.Add(this.pn_change);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(332, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(166, 52);
            this.panel13.TabIndex = 25;
            // 
            // btn_change
            // 
            this.btn_change.BackColor = System.Drawing.Color.White;
            this.btn_change.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_change.FlatAppearance.BorderSize = 0;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_change.Location = new System.Drawing.Point(20, 0);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(126, 47);
            this.btn_change.TabIndex = 3;
            this.btn_change.Text = "변화";
            this.btn_change.UseVisualStyleBackColor = false;
            this.btn_change.Click += new System.EventHandler(this.MenuButtonClickEvent);
            // 
            // pn_change
            // 
            this.pn_change.BackColor = System.Drawing.Color.White;
            this.pn_change.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_change.Location = new System.Drawing.Point(20, 47);
            this.pn_change.Name = "pn_change";
            this.pn_change.Size = new System.Drawing.Size(126, 5);
            this.pn_change.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.White;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(146, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(20, 52);
            this.panel15.TabIndex = 1;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.White;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(20, 52);
            this.panel16.TabIndex = 0;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(194, 127);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(500, 3);
            this.panel17.TabIndex = 23;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.White;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(194, 52);
            this.panel18.TabIndex = 24;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.panel19.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel19.Location = new System.Drawing.Point(0, 52);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(194, 3);
            this.panel19.TabIndex = 25;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(220)))), ((int)(((byte)(221)))));
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 52);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(194, 3);
            this.panel20.TabIndex = 27;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.Color.White;
            this.panel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(194, 52);
            this.panel21.TabIndex = 26;
            // 
            // pn_main
            // 
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(194, 130);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(500, 553);
            this.pn_main.TabIndex = 24;
            // 
            // UC_DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.panel17);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Name = "UC_DashBoard";
            this.Size = new System.Drawing.Size(888, 683);
            this.Load += new System.EventHandler(this.UC_DashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_memberNum;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_dashBoard;
        private System.Windows.Forms.Panel pn_dashboard;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Panel pn_change;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Panel pn_detail;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel pn_main;
    }
}
