using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace JewelryStore.Helper
{
    public class Constants
    {
        public const string Alert = "Alert";
        public const string EmailMsg = "Please enter email";
        public const string Ok = "Ok";
        public const string ValidEmailMsg = "Please enter valid email";

        public static bool ValidateEmail(string email)
        {
            //    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }

        public static bool ValidatesignupEmail(string email)
        {
            //    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            //"^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$"
            Match match = regex.Match(email);
            if (match.Success)
                return true;
            else
                return false;
        }
        public class Regexes
        {
            public const string EmailRegex = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        }
    }
}
