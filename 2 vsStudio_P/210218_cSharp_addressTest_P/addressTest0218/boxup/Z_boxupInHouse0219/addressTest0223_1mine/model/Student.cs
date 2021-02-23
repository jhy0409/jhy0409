using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressTest0223_1mine.model
{
    class Student
    {
        private string id;
        private string name;
        private string tel;
        private string address;
        private string email;


        public Student(string id, string name, string tel, string address, string email)
        {
            this.id = id;
            this.name = name;
            this.tel = tel;
            this.address = address;
            this.email = email;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
    }
}
