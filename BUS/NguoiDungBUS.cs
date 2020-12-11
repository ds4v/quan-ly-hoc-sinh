using DAO;
using DevComponents.DotNetBar.Controls;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class NguoiDungBUS
    {
        private static NguoiDungBUS instance;
        private NguoiDungDTO nguoiDung;
        private BindingSource bindingSource = new BindingSource();

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

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = NguoiDungDAO.Instance.LayDanhSachNguoiDung();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public bool DangNhap(string username, string password)
        {
            DataTable dataTable = NguoiDungDAO.Instance.DangNhap(username, password);
            if (dataTable.Rows.Count == 0) return false;

            LoaiNguoiDungDTO loaiNguoiDung = new LoaiNguoiDungDTO();
            loaiNguoiDung.MaLoai = dataTable.Rows[0]["MaLoai"].ToString();

            nguoiDung = new NguoiDungDTO(
                dataTable.Rows[0]["MaNguoiDung"].ToString(),
                loaiNguoiDung,
                dataTable.Rows[0]["TenNguoiDung"].ToString(),
                dataTable.Rows[0]["TenDangNhap"].ToString(),
                dataTable.Rows[0]["MatKhau"].ToString()
            );
            return true;
        }

        public void DoiMatKhau(string username, string newPassword)
        {
            NguoiDungDAO.Instance.DoiMatKhau(username, newPassword);
            nguoiDung.MatKhau = newPassword;
        }

        public void CapNhatNguoiDung(DataTable dataTable)
        {
            NguoiDungDAO.Instance.CapNhatNguoiDung(dataTable);
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
