using Inbody.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody
{
    public partial class InbodyMain : Form
    {
        #region UserControl 선언
        private UC_OverView _ucOverview;
        private UC_Folder _ucFolder;
        private UC_ProgressBar _ucProgressbar;
        private UC_Analysis _ucAnalysis;
        private UC_Info _ucInfo;
        private UC_Settings _ucSettings;
        
        #endregion

        private bool _isMenuExpanded;
        private bool _isDragging = false;
        private Point offset;
        private List<RadioButton> _userControlButtons;
        
        public InbodyMain()
        {
            InitializeComponent();
            _isMenuExpanded = true;
            _ucFolder = new UC_Folder();
            _ucOverview = new UC_OverView();
            _ucProgressbar = new UC_ProgressBar();
            _ucAnalysis = new UC_Analysis();
            _ucInfo = new UC_Info();   
            _ucSettings = new UC_Settings();

            RegisterUserControlToPanel();
            Init_UserControlButton();
        }

        #region EventHandler
        #region Load
        private void Form1_Load(object sender, EventArgs e)
        {
            rdo_home.ForeColor = Color.White;
            lbl_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            timer_time.Start();
        }
        #endregion

        #region Button
        private void btn_home_Click(object sender, EventArgs e)
        {
            _ucOverview.BringToFront();
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            _ucFolder.BringToFront();
        }

        private void btn_progress_Click(object sender, EventArgs e)
        {
            _ucProgressbar.BringToFront();
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            _ucAnalysis.BringToFront();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            _ucSettings.BringToFront();
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            _ucInfo.BringToFront();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pic_menu_Click(object sender, EventArgs e)
        {
            timer_menu.Start();
        }

        private void UserControlButton_Click(object sender, EventArgs e)
        {
            UserControlButtonCheckedChange(sender); //메뉴 선택 시, 하나만 체크가 되고 나머지는 모두 checked false 되도록 하는 함수
            UserControlButton_Click(sender);  // 클릭한 버튼에 해당하는 usercontrol을 panel의 z축 최상단으로 불러주는 함수
            ChangeForeColor(sender);
        }

        
        #endregion

        #region TitleBar
        private void pn_titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            // 1) 마우스 왼쪽 버튼이 눌렸으면
            // 2) _isDragging을 true로 변경해준다. => 지금부터 드래그를 시작한다라는 의미
            // 3) offset 값에 현재 마우스가 클릭된 위치 정보를 할당 시켜줌 .
            if (e.Button == MouseButtons.Left)
            {
                
                _isDragging = true;
                offset = new Point(e.X, e.Y);
            }
        }

        private void pn_titlebar_MouseMove(object sender, MouseEventArgs e)
        {
            // 1) 마우스 왼쪽 버튼이 눌린 상태에서 드래그가 되면
            // 2) 현재 포지션 위치를 구한다. 
            // 3) newLocation
            if (_isDragging)
            {
                Point newLocation = this.PointToScreen(new Point(e.X, e.Y));
                newLocation.Offset(-offset.X, -offset.Y);
                this.Location = newLocation;
            }
        }

        private void pn_titlebar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isDragging = false;
            }
        }
        #endregion

        #region Timer
        private void timer_menu_Tick(object sender, EventArgs e)
        {
            if (_isMenuExpanded)    //펼쳐진 상태
            {
                fpn_menu.Width -= 10;
                //this.Width -= 10;   //MainForm의 크기도 줄인다.
                if (fpn_menu.Width == fpn_menu.MinimumSize.Width)
                {
                    timer_menu.Stop();
                    _isMenuExpanded = false;
                }
            }
            else
            {
                fpn_menu.Width += 10;
                //this.Width += 10;   //MainForm의 크기도 늘린다.
                if (fpn_menu.Width == fpn_menu.MaximumSize.Width)
                {
                    timer_menu.Stop();
                    _isMenuExpanded = true;
                }
            }
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        #endregion

        #endregion

        #region Application Logic

        private void RegisterUserControlToPanel()
        {
            pn_main.Controls.Add(_ucOverview);
            pn_main.Controls.Add(_ucFolder);
            pn_main.Controls.Add(_ucProgressbar);
            pn_main.Controls.Add(_ucAnalysis);
            pn_main.Controls.Add(_ucInfo);
            pn_main.Controls.Add(_ucSettings);


            _ucOverview.Dock = DockStyle.Fill;
            _ucFolder.Dock = DockStyle.Fill;
            _ucProgressbar.Dock = DockStyle.Fill;
            _ucAnalysis.Dock = DockStyle.Fill;
            _ucInfo.Dock = DockStyle.Fill;
            _ucSettings.Dock = DockStyle.Fill;

            _ucOverview.BringToFront();
        }

        private void Init_UserControlButton()
        {
            _userControlButtons = new List<RadioButton>();
            _userControlButtons.Add(rdo_home);
            _userControlButtons.Add(rdo_analysis);
            _userControlButtons.Add(rdo_settings);
            _userControlButtons.Add(rdo_info);
            _userControlButtons.Add(rdo_folder);
            _userControlButtons.Add(rdo_progress);
        }



        #region UserControl Show
        private void UserControlButtonCheckedChange(object sender)
        {
            var currentRadioBtn = sender as RadioButton;

            foreach (var rdo in _userControlButtons)
            {
                if (rdo != currentRadioBtn)
                {
                    rdo.Checked = false;
                }
            }
        }

        private void UserControlButton_Click(object sender)
        {
            var currentRdo = sender as RadioButton;
            switch (currentRdo.Text)
            {
                case "Home":
                    _ucOverview.BringToFront();
                    break;
                case "Analysis":
                    _ucAnalysis.BringToFront();
                    break;
                case "Settings":
                    _ucSettings.BringToFront();
                    break;
                case "About Us":
                    _ucInfo.BringToFront();
                    break;
                case "Folder":
                    _ucFolder.BringToFront();
                    break;
                case "Progress":
                    _ucProgressbar.BringToFront();
                    break;

                default: break;
            }
        }

        //선택한 라디오버튼만 글자색을 흰색으로 변경
        private void ChangeForeColor(object sender)
        {
            var currentRdo = sender as RadioButton;

            foreach (var rdo in _userControlButtons)
            {
                rdo.ForeColor = Color.Black;
            }

            currentRdo.ForeColor = Color.White;
        }




        #endregion

        #endregion

   
    }
}
