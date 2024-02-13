using Inbody.Controller;
using Inbody.Models;
using Inbody.Utils;
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
    public partial class UC_DashBoardMenu : UserControl
    {
        private OverviewUseCase _overviewUsecase;

        private string _memberNum;

        private List<UserAnalysisModel> _userAnalysises;
        private UserInfoModel _currentUser;

        private Dictionary<Button, Panel> _menuDict;

        private UC_DashBoard _ucDashBoard;
        private UC_DashBoardDetail _ucDashBoardDetail;
        private UC_DashBoardChange _ucDashBoardChange;

        public UC_DashBoardMenu(string memberNum)
        {
            InitializeComponent();
            this._memberNum = memberNum;
            _overviewUsecase = new OverviewUseCase();
            _userAnalysises = new List<UserAnalysisModel>();
            InitMenuDict();
            InitUserControl();
            InitMenu();
        }






        #region EventHandler
        #region Load
        private void UC_DashBoard_Load(object sender, EventArgs e)
        {
            //DB를 불러와야할듯?
            //회원번호를 넘기면 좋을것 같은데 ㅎㅎ 
            _currentUser = _overviewUsecase.GetUserInfoById(_memberNum);
            lbl_memberNum.Text = _currentUser.MemberNum;



        }

        #endregion

        #region Button
        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void MenuButtonClickEvent(object sender, EventArgs e)
        {
            var button = sender as Button;
            ChangeButtonColorAll(_menuDict);
            ChangeButtonColor(button, _menuDict);

            switch (button.Text)
            {
                case "대시보드":
                    UtilExt.ShowUserControl(_ucDashBoard);
                    break;
                case "상세":
                    UtilExt.ShowUserControl(_ucDashBoardDetail);
                    break;
                case "변화":
                    UtilExt.ShowUserControl(_ucDashBoardChange);
                    break;
                default:
                    break;
            }
        }

        #endregion

        #endregion

        #region Application Logic
        #region Init
        private void InitMenuDict()
        {
            _menuDict = new Dictionary<Button, Panel>()
            {
                {btn_dashBoard, pn_dashboard },
                {btn_detail, pn_detail },
                {btn_change, pn_change },
            };
        }


        private void InitMenu()
        {
            ChangeButtonColor(btn_dashBoard, _menuDict);
            UtilExt.ShowUserControl(_ucDashBoard);
        }

        private void InitUserControl()
        {
            _ucDashBoard = new UC_DashBoard();
            UtilExt.RegisterUserControl(pn_main, _ucDashBoard);

            _ucDashBoardDetail = new UC_DashBoardDetail();
            UtilExt.RegisterUserControl(pn_main, _ucDashBoardDetail);

            _ucDashBoardChange = new UC_DashBoardChange();
            UtilExt.RegisterUserControl(pn_main, _ucDashBoardChange);
        }
        #endregion

        private void ChangeButtonColor(Button button, Dictionary<Button,Panel> dict)
        {
            button.ForeColor = Color.Red;
            dict[button].BackColor = Color.Red;
        }

        private void ChangeButtonColorAll(Dictionary<Button, Panel> dict)
        {
            foreach (var item in dict)
            {
                item.Key.ForeColor = Color.Black;
                item.Value.BackColor = Color.White;
            }
        }

        
        #endregion


    }
}
