using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXZ.Car
{
    public class userZaivka
    {
        public List<UserZaivka> UserZaivka { get; set; }
    }

    public class UserZaivka
    {
        public string id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public string passportS { get; set; }
        public string passportN { get; set; }
        public string inventory { get; set; }
        public string costInventory { get; set; }
        public string deposit { get; set; }
        public string tarrif { get; set; }
        public string dateTimeBegin { get; set; }
        public string dateTimeEnd { get; set; }
        public string costRent { get; set; }

    }
}
