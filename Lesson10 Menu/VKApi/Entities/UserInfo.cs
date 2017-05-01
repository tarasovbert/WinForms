using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vk_Api.Entities
{
   public class UserInfo
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public long CaptchaSid { get; set; }
        public string CaptchaKey { get; set; }
    }

   public class CommonInfo
   {
       public string Name { get; set; }
       public long Id { get; set; }
       public string Photo { get; set; }
       public override string ToString()
       {
           return Name;
       }
   }

}
