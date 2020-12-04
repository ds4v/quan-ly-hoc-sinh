using DAO;
using DTO;
using System.Data;

namespace BUS
{
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;
        private NguoiDungDTO nguoiDung = new NguoiDungDTO();
        private LoaiNguoiDungDTO loaiNguoiDung = new LoaiNguoiDungDTO();

        private NguoiDungBUS() { }
        public NguoiDungDTO NguoiDung { get => nguoiDung; set => nguoiDung = value; }
        public LoaiNguoiDungDTO LoaiNguoiDung { get => loaiNguoiDung; set => loaiNguoiDung = value; }

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
            DataTable dataTable = NguoiDungDAO.Instance.LayDanhSachNguoiDung(username);
            if (dataTable.Rows.Count == 0) return 0;
            if (password != dataTable.Rows[0]["MatKhau"].ToString()) return 1;

            NguoiDung.TenNguoiDung = dataTable.Rows[0]["TenNguoiDung"].ToString();
            LoaiNguoiDung.MaLoai = dataTable.Rows[0]["MaLoai"].ToString();
            NguoiDung.LoaiNguoiDung = LoaiNguoiDung;
            return 2;
        }
    }
}
