using Inbody.Controller;
using Inbody.usercontrols.Overview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols
{
    public partial class UC_OverView : UserControl
    {
        private UC_EntryImage _ucEntryImage;

        private OverviewUseCase _overviewUseCase;
        

        public UC_OverView()
        {
            InitializeComponent();
            _overviewUseCase = new OverviewUseCase();
        }

        #region EventHandler
        #region Load

        private void UC_OverView_Load(object sender, EventArgs e)
        {
            _ucEntryImage = new UC_EntryImage();
            RegisterUserControl(pn_main, _ucEntryImage);
            ShowUserControl(_ucEntryImage);
            _ucEntryImage.StartLogicTimer();
        }

        #endregion

        #region Button
        private void btn_okay_Click(object sender, EventArgs e)
        {
            //db검증을 해야함
            // 1) db서버에 해당 회원이 존재하면 로그인 성공 (다른 Main UserControl DashBoard를 띄우면됨)
            // 2) 없으면 MessageBox를 통해서 회원이 없다고 표시한다. 
            // 3) 측정을 하고 오라고 한다.
            var isExist = _overviewUseCase.IsExistUser(tb_memberNum.Text);

            if (isExist)
            {
                MessageBox.Show("로그인 성공!~");
            }
            else
            {
                MessageBox.Show("회원정보가 없습니다. 측정을 하고 오세요");
            }

        }
        #endregion

        #region TextBox
        private void tb_memberNum_TextChanged(object sender, EventArgs e)
        {
            UpdateLabelMemberNumLength();
        }
        #endregion
        #endregion

        #region Application Logic
        private void RegisterUserControl(Panel panel, UserControl usercontrol)
        {
            panel.Controls.Add(usercontrol);
            usercontrol.Dock = DockStyle.Fill;
            usercontrol.Visible = false;
        }

        private void ShowUserControl(UserControl usercontrol)
        {
            usercontrol.Visible = true;
            usercontrol.BringToFront();
        }

        #region TextBox
        private void UpdateLabelMemberNumLength()
        {
            var numLength = tb_memberNum.Text.Length;
            lbl_numberLength.Text = $"({numLength}/14)";
        }
        #endregion

        #endregion


    }
}
