using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Monhoc
    {
        private string mamh;
        private string tenmh;
        private int sotiet;
        private int sodauiemkt;
        private int sotinchi;

        public Monhoc(string mamh, string tenmh, int sotiet, int sodauiemkt, int sotinchi)
        {
            this.Mamh = mamh;
            this.Tenmh = tenmh;
            this.Sotiet = sotiet;
            this.Sodauiemkt = sodauiemkt;
            this.Sotinchi = sotinchi;
        }

        public string Mamh { get => mamh; set => mamh = value; }
        public string Tenmh { get => tenmh; set => tenmh = value; }
        public int Sotiet { get => sotiet; set => sotiet = value; }
        public int Sodauiemkt { get => sodauiemkt; set => sodauiemkt = value; }
        public int Sotinchi { get => sotinchi; set => sotinchi = value; }
    }
}
