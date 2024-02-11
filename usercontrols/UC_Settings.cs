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
            var str = TCPIP_Client.GetDataFromServer("total");

            Console.WriteLine(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var str = TCPIP_Client.GetDataFromServer("weight");
            Console.WriteLine(str);
        }
    }
}
