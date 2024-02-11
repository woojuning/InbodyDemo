using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inbody.Utils
{
    public class TCPIP_Client
    {
        public static string GetDataFromServer(string sendMsg)
        {
            TcpClient client = new TcpClient();
            string data = "";
            try
            {
                client.Connect("127.0.0.1", 1234);

                NetworkStream stream = client.GetStream();

                byte[] sendData = Encoding.UTF8.GetBytes(sendMsg);
                stream.Write(sendData, 0, sendData.Length);

                byte[] responseData = new byte[256];
                int byteRead = stream.Read(responseData, 0, responseData.Length);
                data = Encoding.UTF8.GetString(responseData, 0, byteRead);

                //Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                client.Close();
            }

            return data;
        }
    }
}
