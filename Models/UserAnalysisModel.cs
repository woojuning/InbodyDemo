using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbody.Models
{
    public class UserAnalysisModel
    {
        public int Id{ get; set; }  //아이디
        public string MemberNum { get; set; }    //회원번호
        public double Weight { get; set; }  //몸무게
        public double SkeletalMuscleMass { get; set; }  //근육량
        public double BodyFatMass { get; set; } //체지방량
        public string MeasureTime { get; set; }   //측정 시간
    }
}
