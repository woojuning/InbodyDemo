using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inbody.Models
{
    public class UserInfoModel
    {
        public int Id { get; set; }
        public string MemberNum { get; set; }
        public string PhoneNum { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; } //0 : 남자, 1 : 여자 

        public UserInfoModel()
        {
                
        }
    }
}
