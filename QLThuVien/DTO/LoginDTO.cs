using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    class LoginDTO
    {
        private int id;
        private String Name;
        private String Pass;

        public LoginDTO() { }
        public LoginDTO(int id, string Name, string Pass)
        {
            this.id = id; 
            this.Name = Name;
            this.Pass = Pass;
        }
        public String getName()
        {
            return Name;
        }
        public void setName(String name)
        {
            this.Name = name;
        }
        public String getPass()
        {
            return Pass;
        }
        public void setPass(String pass)
        {
            this.Pass = pass;
        }
        public int getid()
        {
            return id;
        }
        public void setid(int id)
        {
            this.id = id;
        }

    }
}
