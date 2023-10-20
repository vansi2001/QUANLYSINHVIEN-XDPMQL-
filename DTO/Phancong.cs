using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Phancong
    {
        string magv;
        string mamh;
        string malop;
        string namhoc;
        int hocky;

        public Phancong(string magv, string mamh, string malop, string namhoc, int hocky)
        {
            this.magv = magv;
            this.mamh = mamh;
            this.malop = malop;
            this.namhoc = namhoc;
            this.hocky = hocky;
        }

        public string Magv { get => magv; set => magv = value; }
        public string Mamh { get => mamh; set => mamh = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Namhoc { get => namhoc; set => namhoc = value; }
        public int Hocky { get => hocky; set => hocky = value; }
    }
}
