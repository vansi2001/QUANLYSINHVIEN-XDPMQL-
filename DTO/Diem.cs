using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Diem
    {
        private string mamh;
        private string masv;
        private float diemthuongxuyen;
        private float diemkt1;
        private float diemkt2;
        private float diemkt3;
        private float diemkt4;
        private float diemkt5;
        private float diemthi;
        private decimal diemtb;
        private int quamon;
        private float ghichu;

        public Diem(string mamh, string masv, float diemthuongxuyen, float diemkt1,
            float diemkt2, float diemkt3, float diemkt4, float diemkt5, float diemthi, 
            decimal diemtb, int quamon, float ghichu)
        {
            this.Mamh = mamh;
            this.Masv = masv;
            this.Diemthuongxuyen = diemthuongxuyen;
            this.Diemkt1 = diemkt1;
            this.Diemkt2 = diemkt2;
            this.Diemkt3 = diemkt3;
            this.Diemkt4 = diemkt4;
            this.Diemkt5 = diemkt5;
            this.Diemthi = diemthi;
            this.Diemtb = diemtb;
            this.Quamon = quamon;
            this.Ghichu = ghichu;
        }

        public string Mamh { get => mamh; set => mamh = value; }
        public string Masv { get => masv; set => masv = value; }
        public float Diemthuongxuyen { get => diemthuongxuyen; set => diemthuongxuyen = value; }
        public float Diemkt1 { get => diemkt1; set => diemkt1 = value; }
        public float Diemkt2 { get => diemkt2; set => diemkt2 = value; }
        public float Diemkt3 { get => diemkt3; set => diemkt3 = value; }
        public float Diemkt4 { get => diemkt4; set => diemkt4 = value; }
        public float Diemkt5 { get => diemkt5; set => diemkt5 = value; }
        public float Diemthi { get => diemthi; set => diemthi = value; }
        public decimal Diemtb { get => diemtb; set => diemtb = value; }
        public int Quamon { get => quamon; set => quamon = value; }
        public float Ghichu { get => ghichu; set => ghichu = value; }
    }
}
