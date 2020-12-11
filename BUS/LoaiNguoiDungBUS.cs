using DAO;
using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class LoaiNguoiDungBUS
    {
        private static LoaiNguoiDungBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private LoaiNguoiDungBUS() { }

        public static LoaiNguoiDungBUS Instance
        {
            get
            {
                if (instance == null) instance = new LoaiNguoiDungBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = LoaiNguoiDungDAO.Instance.LayDanhSachLoaiNguoiDung();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = LoaiNguoiDungDAO.Instance.LayDanhSachLoaiNguoiDung();
            cmbColumn.DisplayMember = "TenLoai";
            cmbColumn.ValueMember = "MaLoai";
            cmbColumn.DataPropertyName = "MaLoai";
            cmbColumn.HeaderText = "Loại người dùng";
        }

        public void CapNhatLoaiNguoiDung(DataTable dataTable)
        {
            LoaiNguoiDungDAO.Instance.CapNhatLoaiNguoiDung(dataTable);
        }
    }
}
