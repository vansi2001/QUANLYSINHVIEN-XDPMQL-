using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class Sinhvien
    {
        private string masv;
        private string hotensv;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sdt;
        private string matk;
        private string malop;

        public Sinhvien(string masv, string hotensv, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string matk, string malop)
        {
            this.Masv = masv;
            this.Hotensv = hotensv;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Matk = matk;
            this.Malop = malop;
        }

        public string Masv { get => masv; set => masv = value; }
        public string Hotensv { get => hotensv; set => hotensv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Matk { get => matk; set => matk = value; }
        public string Malop { get => malop; set => malop = value; }
    }
}
