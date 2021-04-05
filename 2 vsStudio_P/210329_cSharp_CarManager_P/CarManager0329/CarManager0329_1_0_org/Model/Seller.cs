using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager0323.Model
{
    class Seller
    {
        string name;
        string tel;
        string email;
        string jikwi;
        string officeName;

        public Seller(string name, string tel, string email, 
            string jikwi, string officeName)
        {
            this.name = name;
            this.tel = tel;
            this.email = email;
            this.jikwi = jikwi;
            this.officeName = officeName;
        }

        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Email { get => email; set => email = value; }
        public string Jikwi { get => jikwi; set => jikwi = value; }
        public string OfficeName { get => officeName; set => officeName = value; }
    }
}
