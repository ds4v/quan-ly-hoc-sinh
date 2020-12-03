﻿using DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class LopBUS
    {
        private static LopBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private LopBUS() { }

        public static LopBUS Instance
        {
            get
            {
                if (instance == null) instance = new LopBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX,
            TextBoxX txtMaLop,
            TextBoxX txtTenLop,
            ComboBoxEx cmbKhoiLop,
            ComboBoxEx cmbNamHoc,
            IntegerInput iniSiSo,
            ComboBoxEx cmbGiaoVien)
        {
            bindingSource.DataSource = LopDAO.Instance.LayDanhSachLop();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;

            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", bindingSource, "MaLop");

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", bindingSource, "TenLop");

            cmbKhoiLop.DataBindings.Clear();
            cmbKhoiLop.DataBindings.Add("SelectedValue", bindingSource, "MaKhoiLop");

            cmbNamHoc.DataBindings.Clear();
            cmbNamHoc.DataBindings.Add("SelectedValue", bindingSource, "MaNamHoc");

            iniSiSo.DataBindings.Clear();
            iniSiSo.DataBindings.Add("Text", bindingSource, "SiSo");

            cmbGiaoVien.DataBindings.Clear();
            cmbGiaoVien.DataBindings.Add("SelectedValue", bindingSource, "MaGiaoVien");
        }

        public void HienThiComboBox(string namHoc, ComboBoxEx comboBox)
        {
            comboBox.DataSource = LopDAO.Instance.LayDanhSachLop(namHoc);
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }

        public void CapNhatLop(DataTable dataTable)
        {
            LopDAO.Instance.CapNhatLop(dataTable);
        }

        public void ThemLop(LopDTO lop)
        {
            LopDAO.Instance.ThemLop(lop);
        }

        public void TimTheoMa(string maLop)
        {
            bindingSource.DataSource = LopDAO.Instance.TimTheoMa(maLop);
        }

        public void TimTheoTen(string tenLop)
        {
            bindingSource.DataSource = LopDAO.Instance.TimTheoTen(tenLop);
        }
    }
}
