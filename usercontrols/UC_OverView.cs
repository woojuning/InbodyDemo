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
        private UC_DashBoardMenu _ucDashBoard;
        private UC_Login _ucLogin;

        private OverviewUseCase _overviewUseCase;
        

        public UC_OverView()
        {
            InitializeComponent();
            _overviewUseCase = new OverviewUseCase();
            _ucLogin = new UC_Login();

            RegisterEventHandler();
        }

        #region EventHandler
        #region Load

        private void UC_OverView_Load(object sender, EventArgs e)
        {
            _ucEntryImage = new UC_EntryImage();
            _ucEntryImage.EntryImamgeDisposedEvent += EntryImageDisposedEvent;
            RegisterUserControl(pn_main, _ucEntryImage);
            ShowUserControl(_ucEntryImage);
            _ucEntryImage.StartLogicTimer();
        }

        #endregion

        #region Button
      
        #endregion

        #region TextBox
        #endregion

        #region UserControlEvent
        private void EntryImageDisposedEvent(object sender, EventArgs e)
        {
            RegisterUserControl(pn_main, _ucLogin);
            ShowUserControl(_ucLogin);
        }

        private void LoginOkayButtonEvent(object sender, EventLoginArgs e)
        {
            _ucDashBoard = new UC_DashBoardMenu(e.MemberNum);
            RegisterUserControl(pn_main, _ucDashBoard);
            ShowUserControl(_ucDashBoard);
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

        private void RegisterEventHandler()
        {
            _ucLogin.LoginOkayButtonClickEvent += LoginOkayButtonEvent;
        }

        #region TextBox
       
        #endregion

        #endregion


    }
}
