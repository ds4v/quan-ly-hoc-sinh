using System;

namespace DTO
{
    public class HocSinhDTO
    {
        private string maHocSinh;
        private string hoTen;
        bool gioiTinh;
        private DateTime ngaySinh; 
        private string diaChi; 
        private string maDanToc; 
        private string maTonGiao; 
        private string hoTenCha; 
        private string maNgheCha; 
        private string hoTenMe;
        private string maNgheMe;
        private string email;

        public HocSinhDTO() { }
        public HocSinhDTO(
            string maHocSinh, 
            string hoTen, 
            bool gioiTinh, 
            DateTime ngaySinh, 
            string diaChi, 
            string maDanToc, 
            string maTonGiao, 
            string hoTenCha, 
            string maNgheCha, 
            string hoTenMe, 
            string maNgheMe, 
            string email)
        {
            this.maHocSinh = maHocSinh;
            this.hoTen = hoTen;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.maDanToc = maDanToc;
            this.maTonGiao = maTonGiao;
            this.hoTenCha = hoTenCha;
            this.maNgheCha = maNgheCha;
            this.hoTenMe = hoTenMe;
            this.maNgheMe = maNgheMe;
            this.email = email;
        }

        public string MaHocSinh { get => maHocSinh; set => maHocSinh = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaDanToc { get => maDanToc; set => maDanToc = value; }
        public string MaTonGiao { get => maTonGiao; set => maTonGiao = value; }
        public string HoTenCha { get => hoTenCha; set => hoTenCha = value; }
        public string MaNgheCha { get => maNgheCha; set => maNgheCha = value; }
        public string HoTenMe { get => hoTenMe; set => hoTenMe = value; }
        public string MaNgheMe { get => maNgheMe; set => maNgheMe = value; }
        public string Email { get => email; set => email = value; }
    }
}
