using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using DAO;
using System;
using DevComponents.Editors.DateTimeAdv;
using System.Data;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class HocSinhBUS
    {
        private static HocSinhBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HocSinhBUS() { }

        public static HocSinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator, 
            DataGridViewX dataGridViewX, 
            TextBoxX txtMaHocSinh, 
            TextBoxX txtTenHocSinh, 
            TextBoxX txtGioiTinh, 
            CheckBoxX ckbGTinhNam, 
            CheckBoxX ckbGTinhNu, 
            DateTimeInput dtpNgaySinh, 
            TextBoxX txtDiaChi, 
            ComboBoxEx cmbDanToc, 
            ComboBoxEx cmbTonGiao, 
            TextBoxX txtHoTenCha, 
            ComboBoxEx cmbNgheNghiepCha, 
            TextBoxX txtHoTenMe, 
            ComboBoxEx cmbNgheNghiepMe,
            TextBoxX txtEmail)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh();
            bindingSource.DataSource = dataTable;

            bool gioiTinh = Convert.ToBoolean(dataTable.Rows[0]["GioiTinh"]);
            if (gioiTinh) ckbGTinhNu.Checked = true;
            else ckbGTinhNam.Checked = true;

            txtMaHocSinh.DataBindings.Clear();
            txtMaHocSinh.DataBindings.Add("Text", bindingSource, "MaHocSinh");

            txtTenHocSinh.DataBindings.Clear();
            txtTenHocSinh.DataBindings.Add("Text", bindingSource, "HoTen");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", bindingSource, "GioiTinh");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi");

            cmbDanToc.DataBindings.Clear();
            cmbDanToc.DataBindings.Add("SelectedValue", bindingSource, "MaDanToc");

            cmbTonGiao.DataBindings.Clear();
            cmbTonGiao.DataBindings.Add("SelectedValue", bindingSource, "MaTonGiao");

            txtHoTenCha.DataBindings.Clear();
            txtHoTenCha.DataBindings.Add("Text", bindingSource, "HoTenCha");

            cmbNgheNghiepCha.DataBindings.Clear();
            cmbNgheNghiepCha.DataBindings.Add("SelectedValue", bindingSource, "MaNgheCha");

            txtHoTenMe.DataBindings.Clear();
            txtHoTenMe.DataBindings.Add("Text", bindingSource, "HoTenMe");

            cmbNgheNghiepMe.DataBindings.Clear();
            cmbNgheNghiepMe.DataBindings.Add("SelectedValue", bindingSource, "MaNgheMe");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email");

            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiHocSinhTheoLop(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX, 
            string namHoc, 
            string lop)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop);
            bindingNavigator.BindingSource = bs;
            dataGridViewX.DataSource = bs;
        }

        public void HienThiHocSinhTheoLop(string namHoc, string khoiLop, string lop, ListViewEx listViewEx)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinhTheoLop(namHoc, khoiLop, lop);
            listViewEx.Items.Clear();

            foreach (DataRow Row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaHocSinh"].ToString();
                item.SubItems.Add(Row["HoTen"].ToString());
                listViewEx.Items.Add(item);
            }
        }

        public void HienThiComboBox(string namHoc, string lop, ComboBoxEx comboBox)
        {
            comboBox.DataSource = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }

        public DataTable LayDanhSachHocSinhTheoNamHoc(string namHoc)
        {
            return HocSinhDAO.Instance.LayDanhSachHocSinhTheoNamHoc(namHoc);
        }

        public IList<HocSinhDTO> Report()
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh();
            IList<HocSinhDTO> ilist = new List<HocSinhDTO>();

            foreach (DataRow Row in dataTable.Rows)
            {
                HocSinhDTO hocSinh = new HocSinhDTO();
                hocSinh.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hocSinh.HoTen = Convert.ToString(Row["HoTen"]);
                hocSinh.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
                hocSinh.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                hocSinh.DiaChi = Convert.ToString(Row["DiaChi"]);
                hocSinh.Email = Convert.ToString(Row["Email"]);
                ilist.Add(hocSinh);
            }
            return ilist;
        }

        public IList<HocSinhDTO> Report(string namHoc, string lop)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop, true);
            IList<HocSinhDTO> ilist = new List<HocSinhDTO>();

            foreach (DataRow Row in dataTable.Rows)
            {
                HocSinhDTO hocSinh = new HocSinhDTO();
                hocSinh.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hocSinh.HoTen = Convert.ToString(Row["HoTen"]);
                hocSinh.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
                hocSinh.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                hocSinh.DiaChi = Convert.ToString(Row["DiaChi"]);
                ilist.Add(hocSinh);
            }
            return ilist;
        }

        public void CapNhatHocSinh(DataTable dataTable)
        {
            HocSinhDAO.Instance.CapNhatHocSinh(dataTable);
        }

        public void ThemHocSinh(HocSinhDTO hocSinh)
        {
            HocSinhDAO.Instance.ThemHocSinh(hocSinh);
        }

        public void TimTheoMa(string maHocSinh)
        {
            bindingSource.DataSource = HocSinhDAO.Instance.TimTheoMa(maHocSinh);
        }

        public void TimTheoTen(string tenHocSinh)
        {
            bindingSource.DataSource = HocSinhDAO.Instance.TimTheoTen(tenHocSinh);
        }
    }
}
