namespace Inbody.usercontrols
{
    partial class UC_OverView
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
            this.pn_main = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_memberNum = new System.Windows.Forms.TextBox();
            this.btn_okay = new System.Windows.Forms.Button();
            this.lbl_numberLength = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pn_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.BackColor = System.Drawing.Color.White;
            this.pn_main.Controls.Add(this.label6);
            this.pn_main.Controls.Add(this.lbl_numberLength);
            this.pn_main.Controls.Add(this.btn_okay);
            this.pn_main.Controls.Add(this.tb_memberNum);
            this.pn_main.Controls.Add(this.label1);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Location = new System.Drawing.Point(0, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(888, 683);
            this.pn_main.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(4)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(218, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "회원번호를 입력하세요";
            // 
            // tb_memberNum
            // 
            this.tb_memberNum.Font = new System.Drawing.Font("Pretendard Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_memberNum.Location = new System.Drawing.Point(240, 197);
            this.tb_memberNum.MaxLength = 14;
            this.tb_memberNum.Name = "tb_memberNum";
            this.tb_memberNum.Size = new System.Drawing.Size(401, 47);
            this.tb_memberNum.TabIndex = 3;
            this.tb_memberNum.TextChanged += new System.EventHandler(this.tb_memberNum_TextChanged);
            // 
            // btn_okay
            // 
            this.btn_okay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn_okay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.btn_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okay.Font = new System.Drawing.Font("Pretendard Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_okay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_okay.Location = new System.Drawing.Point(240, 264);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(402, 49);
            this.btn_okay.TabIndex = 4;
            this.btn_okay.Text = "확인";
            this.btn_okay.UseVisualStyleBackColor = false;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // lbl_numberLength
            // 
            this.lbl_numberLength.AutoSize = true;
            this.lbl_numberLength.Font = new System.Drawing.Font("Pretendard", 12F);
            this.lbl_numberLength.Location = new System.Drawing.Point(590, 165);
            this.lbl_numberLength.Name = "lbl_numberLength";
            this.lbl_numberLength.Size = new System.Drawing.Size(51, 19);
            this.lbl_numberLength.TabIndex = 5;
            this.lbl_numberLength.Text = "(0/14)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(236, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "회원번호";
            // 
            // UC_OverView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pn_main);
            this.Name = "UC_OverView";
            this.Size = new System.Drawing.Size(888, 683);
            this.Load += new System.EventHandler(this.UC_OverView_Load);
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_memberNum;
        private System.Windows.Forms.Button btn_okay;
        private System.Windows.Forms.Label lbl_numberLength;
        private System.Windows.Forms.Label label6;
    }
}
