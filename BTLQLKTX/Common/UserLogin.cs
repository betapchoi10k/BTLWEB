using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTLQLKTX.Common
{
    [Serializable]
    public class UserLogin
    {
        public string UserName { set; get; }
        public string MaSV { get; set; }
    }
}