using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        private string malop;
        private string tenlop;
        private string makhoa;

        public Lop(string malop, string tenlop, string makhoa)
        {
            this.Malop = malop;
            this.Tenlop = tenlop;
            this.Makhoa = makhoa;
        }

        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
    }
}
