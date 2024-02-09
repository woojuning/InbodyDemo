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
        public event EventHandler OkayButtonClickEvent;

        public UC_CheckPersonalInfo()
        {
            InitializeComponent();
        }

        #region EventHandler
        #region CheckBox
        private void chk_equalMemberNum_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;

            if (chk.Checked)
            {
                tb_memberNum.Text = lbl_memberNum.Text;
            }
            else
            {
                tb_memberNum.Text = "";
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
            OkayButtonClickEvent?.Invoke(sender, e);
        }
        #endregion

        #endregion

        #region Application Logic

        #endregion



    }
}
