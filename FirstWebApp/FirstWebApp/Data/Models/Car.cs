using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Data.Models
{
    public class Car
    {
        public int id { set; get; }
        public string name { set; get; }
        public string shortDesc { set; get; }
        public string longDesc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; } /// ushort cuz price cant be <0
        public bool isFavourite { set; get; }
        public bool available { set; get; }
        public int categoryID { set; get; }
        public virtual Category Category { set; get; }

    }
}
