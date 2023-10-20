using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiaoVien
    {
        private string magv;
        private string hotengv;
        private DateTime ngaysinh;
        private string gioitinh;
        private string diachi;
        private string sdt;
        private string matk;
        private string makhoa;

        public GiaoVien(string magv, string hotengv, DateTime ngaysinh, string gioitinh, string diachi, string sdt, string matk, string makhoa)
        {
            this.Magv = magv;
            this.Hotengv = hotengv;
            this.Ngaysinh = ngaysinh;
            this.Gioitinh = gioitinh;
            this.Diachi = diachi;
            this.Sdt = sdt;
            this.Matk = matk;
            this.Makhoa = makhoa;
        }

        public string Magv { get => magv; set => magv = value; }
        public string Hotengv { get => hotengv; set => hotengv = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Matk { get => matk; set => matk = value; }
        public string Makhoa { get => makhoa; set => makhoa = value; }
    }
}
