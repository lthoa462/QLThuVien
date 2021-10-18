using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLThuVien.DTO
{
    class ThanhVienDTO
    {
        public int id;
        public string Name;
        public string Phone;
        public string Email;

        public ThanhVienDTO(int id, string name, string phone, string email)
        {
            this.id = id;
            Name = name;
            Phone = phone;
            Email = email;
        }

        public ThanhVienDTO() { }

        public String getName()
        {
            return Name;
        }
        public void setName(String name)
        {
            this.Name = name;
        }
        public String getPhone()
        {
            return Phone;
        }
        public void setPhone(String Phone)
        {
            this.Phone = Phone;
        }
        public int getid()
        {
            return id;
        }
        public void setid(int id)
        {
            this.id = id;
        }
        public String getEmail()
        {
            return Email;
        }
        public void setEmail(String email)
        {
            this.Email = email;

        }
    }
}
