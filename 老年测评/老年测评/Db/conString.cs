using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 老年测评
{
    public class conString
    {
        public static string connstr = @"Data Source=123.206.100.251;Initial Catalog=oldman;User ID=sa;Password=Sa1234";

        public conString(string str)
        {
            connstr = str;
        }
    }
}
