namespace Inbody.usercontrols.Analysis
{
    partial class UC_CheckPersonalInfo
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tb_phoneNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_memberNum = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_equalMemberNum = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdo_male = new System.Windows.Forms.RadioButton();
            this.rdo_female = new System.Windows.Forms.RadioButton();
            this.btn_okay = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 70);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Pretendard Medium", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.label5.Location = new System.Drawing.Point(335, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "신상정보 확인";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(638, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 70);
            this.panel3.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 70);
            this.panel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 559);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(638, 70);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 559);
            this.panel5.TabIndex = 5;
            // 
            // tb_phoneNum
            // 
            this.tb_phoneNum.Font = new System.Drawing.Font("Pretendard Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_phoneNum.Location = new System.Drawing.Point(275, 215);
            this.tb_phoneNum.MaxLength = 14;
            this.tb_phoneNum.Name = "tb_phoneNum";
            this.tb_phoneNum.Size = new System.Drawing.Size(340, 47);
            this.tb_phoneNum.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Pretendard Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(271, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "신상정보 확인";
            // 
            // lbl_memberNum
            // 
            this.lbl_memberNum.AutoSize = true;
            this.lbl_memberNum.Font = new System.Drawing.Font("Pretendard Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_memberNum.ForeColor = System.Drawing.Color.Black;
            this.lbl_memberNum.Location = new System.Drawing.Point(268, 121);
            this.lbl_memberNum.Name = "lbl_memberNum";
            this.lbl_memberNum.Size = new System.Drawing.Size(248, 40);
            this.lbl_memberNum.TabIndex = 11;
            this.lbl_memberNum.Text = "01052927826";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Pretendard Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(271, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "휴대전화번호";
            // 
            // chk_equalMemberNum
            // 
            this.chk_equalMemberNum.Appearance = System.Windows.Forms.Appearance.Button;
            this.chk_equalMemberNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(222)))));
            this.chk_equalMemberNum.FlatAppearance.BorderSize = 0;
            this.chk_equalMemberNum.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.chk_equalMemberNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_equalMemberNum.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_equalMemberNum.Location = new System.Drawing.Point(458, 179);
            this.chk_equalMemberNum.Name = "chk_equalMemberNum";
            this.chk_equalMemberNum.Size = new System.Drawing.Size(157, 30);
            this.chk_equalMemberNum.TabIndex = 12;
            this.chk_equalMemberNum.Text = "회원번호와 동일";
            this.chk_equalMemberNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk_equalMemberNum.UseVisualStyleBackColor = false;
            this.chk_equalMemberNum.CheckedChanged += new System.EventHandler(this.chk_equalMemberNum_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Pretendard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(271, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(344, 52);
            this.label4.TabIndex = 13;
            this.label4.Text = "휴대전화번호를 입력하면 검사 후 휴대전화에서\r\n결과를 확인할 수 있습니다.\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Pretendard Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(271, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "신장 (cm)";
            // 
            // tb_height
            // 
            this.tb_height.Font = new System.Drawing.Font("Pretendard Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_height.Location = new System.Drawing.Point(275, 341);
            this.tb_height.MaxLength = 6;
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(340, 47);
            this.tb_height.TabIndex = 1;
            // 
            // tb_age
            // 
            this.tb_age.Font = new System.Drawing.Font("Pretendard Medium", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tb_age.Location = new System.Drawing.Point(275, 429);
            this.tb_age.MaxLength = 3;
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(340, 47);
            this.tb_age.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Pretendard Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(271, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "연령 (만 나이)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Pretendard Medium", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(271, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 24);
            this.label8.TabIndex = 16;
            this.label8.Text = "성별";
            // 
            // rdo_male
            // 
            this.rdo_male.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_male.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.rdo_male.FlatAppearance.BorderSize = 0;
            this.rdo_male.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.rdo_male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_male.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdo_male.Location = new System.Drawing.Point(275, 514);
            this.rdo_male.Name = "rdo_male";
            this.rdo_male.Size = new System.Drawing.Size(165, 51);
            this.rdo_male.TabIndex = 3;
            this.rdo_male.Text = "남성";
            this.rdo_male.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_male.UseVisualStyleBackColor = false;
            this.rdo_male.CheckedChanged += new System.EventHandler(this.CheckedChangeGenderRadioButton);
            this.rdo_male.Click += new System.EventHandler(this.SelectGenderRadioButton);
            // 
            // rdo_female
            // 
            this.rdo_female.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_female.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.rdo_female.Checked = true;
            this.rdo_female.FlatAppearance.BorderSize = 0;
            this.rdo_female.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.rdo_female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdo_female.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rdo_female.Location = new System.Drawing.Point(450, 514);
            this.rdo_female.Name = "rdo_female";
            this.rdo_female.Size = new System.Drawing.Size(165, 51);
            this.rdo_female.TabIndex = 4;
            this.rdo_female.TabStop = true;
            this.rdo_female.Text = "여성";
            this.rdo_female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_female.UseVisualStyleBackColor = false;
            this.rdo_female.CheckedChanged += new System.EventHandler(this.CheckedChangeGenderRadioButton);
            this.rdo_female.Click += new System.EventHandler(this.SelectGenderRadioButton);
            // 
            // btn_okay
            // 
            this.btn_okay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(155)))), ((int)(((byte)(220)))));
            this.btn_okay.FlatAppearance.BorderSize = 0;
            this.btn_okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_okay.Font = new System.Drawing.Font("Pretendard Medium", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_okay.ForeColor = System.Drawing.Color.White;
            this.btn_okay.Location = new System.Drawing.Point(275, 574);
            this.btn_okay.Name = "btn_okay";
            this.btn_okay.Size = new System.Drawing.Size(340, 45);
            this.btn_okay.TabIndex = 5;
            this.btn_okay.Text = "확인";
            this.btn_okay.UseVisualStyleBackColor = false;
            this.btn_okay.Click += new System.EventHandler(this.btn_okay_Click);
            // 
            // UC_CheckPersonalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_okay);
            this.Controls.Add(this.rdo_female);
            this.Controls.Add(this.rdo_male);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_age);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_equalMemberNum);
            this.Controls.Add(this.lbl_memberNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_phoneNum);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UC_CheckPersonalInfo";
            this.Size = new System.Drawing.Size(888, 629);
            this.Load += new System.EventHandler(this.UC_CheckPersonalInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tb_phoneNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_memberNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_equalMemberNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdo_male;
        private System.Windows.Forms.RadioButton rdo_female;
        private System.Windows.Forms.Button btn_okay;
    }
}
