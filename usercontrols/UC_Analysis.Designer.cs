namespace Inbody.usercontrols
{
    partial class UC_Analysis
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Analysis));
            this.pn_bottom = new System.Windows.Forms.Panel();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_managerMenu = new System.Windows.Forms.Button();
            this.pn_main = new System.Windows.Forms.Panel();
            this.pn_top = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_posture = new System.Windows.Forms.Timer(this.components);
            this.pn_bottom.SuspendLayout();
            this.pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_bottom
            // 
            this.pn_bottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_bottom.Controls.Add(this.btn_next);
            this.pn_bottom.Controls.Add(this.btn_managerMenu);
            this.pn_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_bottom.Location = new System.Drawing.Point(0, 629);
            this.pn_bottom.Name = "pn_bottom";
            this.pn_bottom.Size = new System.Drawing.Size(888, 54);
            this.pn_bottom.TabIndex = 1;
            this.pn_bottom.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_bottom_Paint);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_next.ForeColor = System.Drawing.Color.Black;
            this.btn_next.Location = new System.Drawing.Point(709, 7);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(165, 37);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "다음";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_managerMenu
            // 
            this.btn_managerMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(245)))), ((int)(((byte)(238)))));
            this.btn_managerMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_managerMenu.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_managerMenu.ForeColor = System.Drawing.Color.Black;
            this.btn_managerMenu.Location = new System.Drawing.Point(8, 7);
            this.btn_managerMenu.Name = "btn_managerMenu";
            this.btn_managerMenu.Size = new System.Drawing.Size(165, 37);
            this.btn_managerMenu.TabIndex = 0;
            this.btn_managerMenu.Text = "관리자메뉴";
            this.btn_managerMenu.UseVisualStyleBackColor = false;
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.pn_main.Controls.Add(this.pn_top);
            this.pn_main.Controls.Add(this.label2);
            this.pn_main.Controls.Add(this.label1);
            this.pn_main.Controls.Add(this.pictureBox1);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(888, 629);
            this.pn_main.TabIndex = 2;
            this.pn_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_main_Paint);
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(52)))));
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(888, 46);
            this.pn_top.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pretendard Medium", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(89)))), ((int)(((byte)(61)))));
            this.label2.Location = new System.Drawing.Point(307, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "맨발로 올라서세요.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(307, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "인바디검사를 하려면";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer_posture
            // 
            this.timer_posture.Interval = 700;
            this.timer_posture.Tick += new System.EventHandler(this.timer_posture_Tick);
            // 
            // UC_Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.pn_bottom);
            this.Name = "UC_Analysis";
            this.Size = new System.Drawing.Size(888, 683);
            this.Load += new System.EventHandler(this.UC_Analysis_Load);
            this.pn_bottom.ResumeLayout(false);
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pn_bottom;
        private System.Windows.Forms.Button btn_managerMenu;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Timer timer_posture;
    }
}
