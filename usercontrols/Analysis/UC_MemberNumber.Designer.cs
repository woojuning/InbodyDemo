namespace Inbody.usercontrols.Analysis
{
    partial class UC_MemberNumber
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_memberNum = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_okay = new System.Windows.Forms.Button();
            this.lbl_numberLength = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(40)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 180);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(638, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 180);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 180);
            this.panel2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pretendard Medium", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(284, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 41);
            this.label5.TabIndex = 7;
            this.label5.Text = "회원번호를 입력하세요.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pretendard Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(465, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Pretendard Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(136)))), ((int)(((byte)(89)))));
            this.label2.Location = new System.Drawing.Point(429, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(252)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(393, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Pretendard", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(233, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(377, 282);
            this.label4.TabIndex = 2;
            this.label4.Text = "새로운 회원번호를 입력하면\r\n회원가입됩니다.\r\n인바디 회원 혜택\r\n1. 인바디에 결과를 저장하여, 저장된 \r\n결과들로 몸의 변화를 확인할 수 있습" +
    "니다.\r\n2. 신상정보를 저장하여, 매번 신상정보를 \r\n입력하지 않고 검사할 수 있습니다.";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbl_numberLength);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.tb_memberNum);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.btn_okay);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 407);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(888, 222);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Pretendard Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(10, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "비회원 검사";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pretendard", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(233, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "회원번호";
            // 
            // tb_memberNum
            // 
            this.tb_memberNum.Font = new System.Drawing.Font("Pretendard Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_memberNum.Location = new System.Drawing.Point(237, 36);
            this.tb_memberNum.MaxLength = 14;
            this.tb_memberNum.Name = "tb_memberNum";
            this.tb_memberNum.Size = new System.Drawing.Size(401, 47);
            this.tb_memberNum.TabIndex = 2;
            this.tb_memberNum.TextChanged += new System.EventHandler(this.tb_memberNum_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.panel5.Location = new System.Drawing.Point(-1, 147);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(888, 3);
            this.panel5.TabIndex = 3;
            // 
            // btn_okay
            // 
            this.btn_okay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(201)))), ((int)(((byte)(218)))));
            this.btn_okay.Enabled = false;
            this.btn_okay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(207)))), ((int)(((byte)(206)))));
            this.btn_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okay.Font = new System.Drawing.Font("Pretendard Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_okay.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_okay.Location = new System.Drawing.Point(236, 92);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(402, 49);
            this.btn_okay.TabIndex = 0;
            this.btn_okay.Text = "확인";
            this.btn_okay.UseVisualStyleBackColor = false;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // lbl_numberLength
            // 
            this.lbl_numberLength.AutoSize = true;
            this.lbl_numberLength.Font = new System.Drawing.Font("Pretendard", 12F);
            this.lbl_numberLength.Location = new System.Drawing.Point(587, 10);
            this.lbl_numberLength.Name = "lbl_numberLength";
            this.lbl_numberLength.Size = new System.Drawing.Size(51, 19);
            this.lbl_numberLength.TabIndex = 4;
            this.lbl_numberLength.Text = "(0/14)";
            // 
            // UC_MemberNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(224)))), ((int)(((byte)(223)))));
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "UC_MemberNumber";
            this.Size = new System.Drawing.Size(888, 629);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_memberNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_okay;
        private System.Windows.Forms.Label lbl_numberLength;
    }
}
