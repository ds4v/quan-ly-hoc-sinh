using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;
        private NguoiDungDTO nguoiDung;

        private NguoiDungBUS() { }
        public NguoiDungDTO NguoiDung { get => nguoiDung; set => nguoiDung = value; }

        public static NguoiDungBUS Instance
        {
            get
            {
                if (instance == null) instance = new NguoiDungBUS();
                return instance;
            }
            private set => instance = value;
        }

        public int DangNhap(string username, string password)
        {
            DataTable dataTable = NguoiDungDAO.Instance.LayNguoiDung(username);
            if (dataTable.Rows.Count == 0) return 0;
            if (password != dataTable.Rows[0]["MatKhau"].ToString()) return 1;

            LoaiNguoiDungDTO loaiNguoiDung = new LoaiNguoiDungDTO();
            loaiNguoiDung.MaLoai = dataTable.Rows[0]["MaLoai"].ToString();

            nguoiDung = new NguoiDungDTO(
                dataTable.Rows[0]["MaNguoiDung"].ToString(),
                loaiNguoiDung,
                dataTable.Rows[0]["TenNguoiDung"].ToString(),
                dataTable.Rows[0]["TenDangNhap"].ToString(),
                dataTable.Rows[0]["MatKhau"].ToString()
            );
            return 2;
        }

        public void DoiMatKhau(string username, string newPassword)
        {
            NguoiDungDAO.Instance.DoiMatKhau(username, newPassword);
            nguoiDung.MatKhau = newPassword;
        }

        public void SaoLuuCSDL(string fileName)
        {
            NguoiDungDAO.Instance.SaoLuuCSDL(fileName);
        }

        public void PhucHoiCSDL(string fileName)
        {
            NguoiDungDAO.Instance.PhucHoiCSDL(fileName);

        }
    }
}
