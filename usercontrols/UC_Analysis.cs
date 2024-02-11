using Inbody.Models;
using Inbody.usercontrols.Analysis;
using Inbody.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols
{
    public partial class UC_Analysis : UserControl
    {
        UC_AnalysisWeight _ucAnalysisWeight;
        UC_MemberNumber _ucMemberNumber;
        UC_CheckPersonalInfo _ucCheckPersonInfo;
        UC_PersonalInfoConsent _ucPersonInfoConsent;
        UC_PostureFoot _ucPostureFoot;
        UC_PostureHand _ucPostureHand;
        UC_PostureArmpit1 _ucPostureArmpit1;
        UC_PostureArmpit2 _ucPostureArmpit2;
        UC_InbodyTest _ucInbodyTest;

        
        private Page _currentPage;
        private UserInfoModel _currentUser;
        private UserAnalysisModel _currentAnalysis;

        public UC_Analysis()
        {
            InitializeComponent();
            _ucAnalysisWeight = new UC_AnalysisWeight();
            _ucMemberNumber = new UC_MemberNumber();
            //_ucCheckPersonInfo = new UC_CheckPersonalInfo();
            _ucPersonInfoConsent = new UC_PersonalInfoConsent();
            _ucPostureFoot = new UC_PostureFoot();
            _ucPostureHand = new UC_PostureHand();
            _ucPostureArmpit1 = new UC_PostureArmpit1();
            _ucPostureArmpit2 = new UC_PostureArmpit2();
            //_ucInbodyTest = new UC_InbodyTest();

            _currentUser = new UserInfoModel();
            _currentAnalysis = new UserAnalysisModel();

            _currentPage = Page.AnalysisMain;

            RegisterUserControlEventHandler();
        }

        #region EventHandler

        #region Load
        private void UC_Analysis_Load(object sender, EventArgs e)
        {
            RegisterUserControlToPanel();
        }
        #endregion
        
        #region Button
        //다음 버튼 이벤트
        private void btn_next_Click(object sender, EventArgs e)
        {
            // 다음 버튼을 누르면 현재 _screenIndex값에 따라 어떤 usercontrol을 panel로부터 z축 최상위로 보여줄지 정한다. 
            // switch case를 이용해서 만들면 될듯 함.
            switch (_currentPage)
            {
                case Page.AnalysisMain:
                    _currentPage = Page.AnalysisWeight;
                    _ucAnalysisWeight.Visible = true;
                    _ucAnalysisWeight.BringToFront();
                    _ucAnalysisWeight.GetWeightFromServer("weight");
                    //_ucAnalysisWeight.StartTimer();
                    break;
                case Page.AnalysisWeight:
                    _currentPage = Page.MemberNumber;
                    _ucMemberNumber.Visible = true;
                    _ucMemberNumber.BringToFront();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region UserControl
        //UC_AnalysisWeight
        private void AnalysisWeightEvent(object sender, EventWeightArgs e)
        {
            _currentAnalysis.Weight = e.Weight;
            _currentPage = Page.MemberNumber;
            _ucMemberNumber.Visible = true;
            _ucMemberNumber.BringToFront();
        }

        //UC_MemberNumbers
        private void OkayButtonClickEvent_MemberNum(object sender, EventDataArgs e)
        {
            _currentPage = Page.PersonInfo;
            _ucCheckPersonInfo = new UC_CheckPersonalInfo(e.MemberNum);
            RegisterUserControl(pn_main, _ucCheckPersonInfo);

            //Event등록
            _ucCheckPersonInfo.OkayButtonClickEvent += this.OkayButtonClickEvent_PersonalInfo;
            
            ShowUserControl(_ucCheckPersonInfo);
        }

        //UC_CheckPersonalInfo
        private void OkayButtonClickEvent_PersonalInfo(object sender, EventUserInfoArgs e)
        {
            //UserInfoModel 정보 입력.
            _currentUser.MemberNum = e.MemberNum;
            _currentUser.PhoneNum = e.PhoneNum;
            _currentUser.Height = e.Height;
            _currentUser.Age = e.Age;
            _currentUser.Gender = e.Gender;

            _currentPage = Page.PersonInfoConsent;
            _ucPersonInfoConsent.Visible = true;
            _ucPersonInfoConsent.BringToFront();
        }

        private void YesButtonClickEvent_PersonInfoConsent(object sender, EventArgs e)
        {
            if (_currentPage != Page.PersonInfoConsent) return;
            _currentPage = Page.PostureFoot;
            _ucPostureFoot.Visible = true;
            _ucPostureFoot.BringToFront();

            //여기서는 타이머를 동작시키면 될거같은데 ?
            timer_posture.Start();
        }

        #endregion

        #region Timer
        //posutre 화면 n초 마다 변경해주는 Event
        private void timer_posture_Tick(object sender, EventArgs e)
        {
            switch (_currentPage)
            {
                case Page.PostureFoot: //UC_PostureHand로 변경
                    _currentPage = Page.PostureHand;
                    _ucPostureHand.Visible = true;
                    _ucPostureHand.BringToFront();
                    break;
                case Page.PostureHand: //UC_PostureArmpit1로 변경
                    _currentPage = Page.PostureArmpit1;
                    _ucPostureArmpit1.Visible = true;
                    _ucPostureArmpit1.BringToFront();
                    break;
                case Page.PostureArmpit1: //UC_PostureArmpit2로 변경
                    _currentPage = Page.PostureArmpit2;
                    _ucPostureArmpit2.Visible = true;
                    _ucPostureArmpit2.BringToFront();
                    break;
                case Page.PostureArmpit2: //UC_InbodyTest로 변경
                    _currentPage = Page.InobyTest;

                    _ucInbodyTest = new UC_InbodyTest(_currentUser, _currentAnalysis);
                    RegisterUserControl(pn_main, _ucInbodyTest);
                    ShowUserControl(_ucInbodyTest);
                    
                    timer_posture.Stop();
                    break;
                default:
                    break;
            }
        }
        #endregion

        #endregion

        #region Application Logic
        #region 초기세팅
        private void RegisterUserControlToPanel()
        {
            pn_main.Controls.Add(_ucAnalysisWeight);
            pn_main.Controls.Add(_ucMemberNumber);
            //pn_main.Controls.Add(_ucCheckPersonInfo);
            pn_main.Controls.Add(_ucPersonInfoConsent);
            pn_main.Controls.Add(_ucPostureFoot);
            pn_main.Controls.Add(_ucPostureHand);
            pn_main.Controls.Add(_ucPostureArmpit1);
            pn_main.Controls.Add(_ucPostureArmpit2);
            //pn_main.Controls.Add(_ucInbodyTest);

            _ucAnalysisWeight.Dock = DockStyle.Fill;
            _ucMemberNumber.Dock = DockStyle.Fill;
            //_ucCheckPersonInfo.Dock = DockStyle.Fill;
            _ucPersonInfoConsent.Dock = DockStyle.Fill;
            _ucPostureFoot.Dock = DockStyle.Fill;
            _ucPostureHand.Dock = DockStyle.Fill;
            _ucPostureArmpit1.Dock = DockStyle.Fill;
            _ucPostureArmpit2.Dock = DockStyle.Fill;
            //_ucInbodyTest.Dock = DockStyle.Fill;


            _ucAnalysisWeight.Visible = false;
            _ucMemberNumber.Visible = false;
            //_ucCheckPersonInfo.Visible = false;
            _ucPersonInfoConsent.Visible = false;
            _ucPostureFoot.Visible = false;
            _ucPostureHand.Visible = false;
            _ucPostureArmpit1.Visible = false;
            _ucPostureArmpit2.Visible = false;
            //_ucInbodyTest.Visible = false;
        }

        private void RegisterUserControlEventHandler()
        {
            _ucAnalysisWeight.WeightEventHandler += AnalysisWeightEvent;
            _ucMemberNumber.OkayButtonClickEvent += this.OkayButtonClickEvent_MemberNum;
            //_ucCheckPersonInfo.OkayButtonClickEvent += this.OkayButtonClickEvent_PersonalInfo;
            _ucPersonInfoConsent.YesButtonClickEvent += this.YesButtonClickEvent_PersonInfoConsent;
        }
        #endregion


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




        #endregion

        private void pn_bottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pn_main_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



    