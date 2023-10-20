using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Account
    {
        string matk;
        string taikhoan;
        string pass;
        string type_user;

        public Account(string matk, string taikhoan, string pass, string type_user)
        {
            this.matk = matk ?? throw new ArgumentNullException(nameof(matk));
            // "??" Trả về vế bên trái nếu #null, trả về vế bên phải nếu giá trị null.
            this.taikhoan = taikhoan ?? throw new ArgumentNullException(nameof(taikhoan));
            this.pass = pass ?? throw new ArgumentNullException(nameof(pass));
            this.type_user = type_user ?? throw new ArgumentNullException(nameof(type_user));
        }
    }
}
