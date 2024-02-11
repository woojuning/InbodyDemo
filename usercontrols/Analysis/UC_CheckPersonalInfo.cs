using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols.Analysis
{
    public partial class UC_CheckPersonalInfo : UserControl
    {
        public event EventHandler<EventUserInfoArgs> OkayButtonClickEvent;
        

        private string _memberNum;

        public UC_CheckPersonalInfo(string memberNum)
        {
            InitializeComponent();
            this._memberNum = memberNum;
        }

        #region EventHandler
        #region Load
        private void UC_CheckPersonalInfo_Load(object sender, EventArgs e)
        {
            lbl_memberNum.Text = _memberNum;
        }
        #endregion
        #region CheckBox
        private void chk_equalMemberNum_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;

            if (chk.Checked)
            {
                tb_phoneNum.Text = lbl_memberNum.Text;
            }
            else
            {
                tb_phoneNum.Text = "";
            }

        }
        #endregion

        #region RadioButton
        private void SelectGenderRadioButton(object sender, EventArgs e)
        {
            //var rdo = sender as RadioButton;

            //// 라디오 버튼 : 남성
            //if (rdo.Text == "남성")
            //{
            //    if (rdo.Checked)
            //    {
            //        rdo.ForeColor = Color.White;
            //    }
            //    else
            //    {
            //        rdo.ForeColor = Color.White;
            //    }
            //}
            //// 라디오 버튼 : 여성
            //else
            //{
            //    if (rdo.Checked)
            //    {

            //    }
            //    else
            //    {

            //    }
            //}
        }

        private void CheckedChangeGenderRadioButton(object sender, EventArgs e)
        {
            var rdo = sender as RadioButton;

            if (rdo.Text == "남성")
            {
                if (rdo.Checked)
                {
                    rdo.ForeColor = Color.White;
                }
                else
                {
                    rdo.ForeColor = Color.Black;
                }
            }
            // 라디오 버튼 : 여성
            else
            {
                if (rdo.Checked)
                {
                    rdo.ForeColor = Color.White;
                }
                else
                {
                    rdo.ForeColor = Color.Black;
                }
            }
        }

        #endregion

        #region Button
        private void btn_okay_Click(object sender, EventArgs e)
        {
            EventUserInfoArgs args = new EventUserInfoArgs(
                membernum: lbl_memberNum.Text,
                phonenum: tb_phoneNum.Text,
                height: double.Parse(tb_height.Text),
                age: int.Parse(tb_age.Text),
                gender: rdo_male.Checked ? false : true
                );

            OkayButtonClickEvent?.Invoke(sender, args);
        }


        #endregion

        #endregion

        #region Application Logic

        #endregion

    
    }

    public class EventUserInfoArgs : EventArgs
    {
        public string MemberNum { get; set; }
        public string PhoneNum { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        public EventUserInfoArgs(string membernum, string phonenum, double height, int age, bool gender)
        {
            this.MemberNum = membernum;
            this.PhoneNum = phonenum;
            this.Height = height;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
