using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_form
{
    public static class GlobalUserName
    {
        private static string _userName = "";
        public static string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
    }
}
