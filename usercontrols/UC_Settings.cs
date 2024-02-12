using Connect;
using Dapper;
using Inbody.Models;
using Inbody.Repository;
using Inbody.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.usercontrols
{
    public partial class UC_Settings : UserControl
    {
        public UC_Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAnalysisRepo repo = new UserAnalysisRepo();

            var user = new UserInfoModel()
            {
                MemberNum = "111",
                PhoneNum = "01089051985",
                Height = 164,
                Age = 29,
                Gender = false
            };

            var analysis = new UserAnalysisModel()
            {
                MemberNum = user.MemberNum,
                Weight = 92,
                SkeletalMuscleMass = 42,
                BodyFatMass = 25,
                MeasureTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            };

            repo.Insert(analysis);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserInfoRepo repo = new UserInfoRepo();
            var user = new UserInfoModel()
            {
                MemberNum = "123",
                PhoneNum = "01091471986",
                Height = 192,
                Age = 30,
                Gender = false
            };

            repo.Update(user);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserInfoRepo repo = new UserInfoRepo();
            var user = new UserInfoModel()
            {
                MemberNum = "111",
                PhoneNum = "01091471986",
                Height = 192,
                Age = 30,
                Gender = false
            };

            var res = repo.IsExistUser(user.MemberNum);
            if (res)
            {
                MessageBox.Show("존재함");
            }
        }
    }
}
