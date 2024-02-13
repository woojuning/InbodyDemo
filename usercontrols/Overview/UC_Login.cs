using Inbody.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols.Overview
{
    public partial class UC_Login : UserControl
    {
        public event EventHandler<EventLoginArgs> LoginOkayButtonClickEvent;

        private OverviewUseCase _overViewUseCase;

        public UC_Login()
        {
            InitializeComponent();
            _overViewUseCase = new OverviewUseCase();
        }
        #region EventHandler
        #region Button
        private void btn_okay_Click(object sender, EventArgs e)
        {
            var isExist = _overViewUseCase.IsExistUser(tb_memberNum.Text);
            if (isExist)
            {
                LoginOkayButtonClickEvent?.Invoke(sender, new EventLoginArgs(tb_memberNum.Text));
                tb_memberNum.Text = "";
            }
            else
            {
                MessageBox.Show("회원정보가 없습니다. 측정을 하고 와주세요");
            }
            
        }
        #endregion

        #region TextBox
        //글자수 Label 변경 이벤트
        private void tb_memberNum_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelMemberNumLength();
        }
        #endregion
        #endregion

        #region Application Logic
        #region TextBox
        private void UpdateLabelMemberNumLength()
        {
            var numLength = tb_memberNum.Text.Length;
            lbl_numberLength.Text = $"({numLength}/14)";
        }

        #endregion

        #endregion

     
    }

    public class EventLoginArgs : EventArgs
    {
        public string MemberNum { get; set; }

        public EventLoginArgs(string memberNum)
        {
            this.MemberNum = memberNum;
        }
    }
}
