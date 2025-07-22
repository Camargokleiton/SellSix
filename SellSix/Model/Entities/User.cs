using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellSix.Model.Entities
{
    public class User
    {

        public long _id { get; set; }
        public string _name { get; set; }
        public string _document { get; set; }
        public string _email { get; set; }
        public string _password { get; set; }
        public string _phone { get; set; }
        public string _address { get; set; }
        public string _city { get; set; }
        public int _accesslevel { get; set; }


    }
}
