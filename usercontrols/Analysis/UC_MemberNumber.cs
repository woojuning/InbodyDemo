using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols.Analysis
{
    public partial class UC_MemberNumber : UserControl
    {
        public event EventHandler OkayButtonClickEvent;

        public UC_MemberNumber()
        {
            InitializeComponent();
        }

        #region EventHandler

        #region TextBox
        private void tb_memberNum_TextChanged(object sender, EventArgs e)
        {
            // 글자수 변경 레이블 업데이트
            UpdateLabelMemberNumLength();
            // 입력한 회원번호가 존재하면 확인 버튼 활성화
            if (tb_memberNum.Text.Length > 0)
            {
                btn_okay.Enabled = true;
            }
            else
            {
                btn_okay.Enabled = false;
            }
        }
        #endregion

        #region Button
        private void btn_okay_Click(object sender, EventArgs e)
        {
            OkayButtonClickEvent?.Invoke(sender, e);
        }
        #endregion

        #endregion

        #region Application Logic
        private void UpdateLabelMemberNumLength()
        {
            var numLength = tb_memberNum.Text.Length;
            lbl_numberLength.Text = $"({numLength}/14)";
        }

        #endregion

        
    }
}
