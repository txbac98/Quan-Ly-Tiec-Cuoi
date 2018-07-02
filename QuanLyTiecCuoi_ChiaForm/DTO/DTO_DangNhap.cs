using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DangNhap
    {
        public DTO_DangNhap(string user, string pass)
        {
            Username = user;
            Password = pass;
        }
        public  string Username { get; set; }
        public string Password { get; set; }
    }
}
