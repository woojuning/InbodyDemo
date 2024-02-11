using Inbody.Models;
using Inbody.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbody.Controller
{
    public class AnalysisController
    {
        public AnalysisController()
        {
                
        }

        public string GetWeight(string msg)
        {
            string message = "";
            try
            {
                message = TCPIP_Client.GetDataFromServer(msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            return message;
        }

        public UserAnalysisModel GetAnalysisInfo(UserAnalysisModel userAnalysis)
        {
            var res = TCPIP_Client.GetDataFromServer("Analysis").Split(',').ToList();

            userAnalysis.SkeletalMuscleMass = double.Parse(res[0]);
            userAnalysis.BodyFatMass = double.Parse(res[1]);

            return userAnalysis;
        }

        
    }
}
