using DAO;
using DevComponents.DotNetBar.Controls;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class DiemBUS
    {
        private static DiemBUS instance;

        private DiemBUS() { }

        public static DiemBUS Instance
        {
            get
            {
                if (instance == null) instance = new DiemBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            DataGridViewX dataGridViewX, 
            ComboBoxEx cmbMonHoc, 
            ComboBoxEx cmbHocKy, 
            ComboBoxEx cmbNamHoc, 
            ComboBoxEx cmbLop, 
            ref int[,] STT)
        {
            STT = new int[60, 20];
            int countRowHocSinh = 0;

            foreach (DataGridViewRow rowHocSinh in dataGridViewX.Rows)
            {
                countRowHocSinh++;
                int soDiemMieng = 0, soDiem15Phut = 0, soDiem45Phut = 0;
                int countRowDiem = 0;

                string[] diemMieng = new string[10];
                string[] diem15Phut = new string[10];
                string[] diem45Phut = new string[10];
                string diemThi = "";

                DataTable dataTable = DiemDAO.Instance.LayDanhSachDiem(
                    rowHocSinh.Cells["colMaHocSinh"].Value.ToString(),
                    cmbMonHoc.SelectedValue.ToString(),
                    cmbHocKy.SelectedValue.ToString(),
                    cmbNamHoc.SelectedValue.ToString(),
                    cmbLop.SelectedValue.ToString()
                );

                foreach (DataRow rowDiem in dataTable.Rows)
                {
                    countRowDiem++;
                    STT[countRowHocSinh, countRowDiem] = int.Parse(rowDiem["STT"].ToString());
                    string loaiDiem = rowDiem["MaLoai"].ToString();

                    if (loaiDiem == "LD0001") diemMieng[soDiemMieng++] = rowDiem["Diem"].ToString();
                    else if (loaiDiem == "LD0002") diem15Phut[soDiem15Phut++] = rowDiem["Diem"].ToString();
                    else if (loaiDiem == "LD0003") diem45Phut[soDiem45Phut++] = rowDiem["Diem"].ToString();
                    else if (loaiDiem == "LD0004") diemThi = rowDiem["Diem"].ToString();
                }

                rowHocSinh.Cells["colDiemMieng"].Value = UtilitiesBUS.ArrayToString(diemMieng, soDiemMieng);
                rowHocSinh.Cells["colDiem15Phut"].Value = UtilitiesBUS.ArrayToString(diem15Phut, soDiem15Phut);
                rowHocSinh.Cells["colDiem45Phut"].Value = UtilitiesBUS.ArrayToString(diem45Phut, soDiem45Phut);
                rowHocSinh.Cells["colDiemThi"].Value = diemThi;
            }
        }

        public void HienThiDanhSachXemDiem(
            ListViewEx lvXemDiem,
            string maHocSinh,
            string maMonHoc,
            string maHocKy,
            string maNamHoc,
            string maLop)
        {
            lvXemDiem.Items.Clear();
            DataTable dataTable = DiemDAO.Instance.LayDanhSachDiem(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);

            foreach (DataRow row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();

                item.Text = row["STT"].ToString();
                item.SubItems.Add(row["MaHocSinh"].ToString());
                item.SubItems.Add(row["HoTen"].ToString());
                item.SubItems.Add(row["TenMonHoc"].ToString());
                item.SubItems.Add(row["TenLoai"].ToString());
                item.SubItems.Add(row["Diem"].ToString());

                lvXemDiem.Items.Add(item);
            }
        }

        public float LayDiemMiengTB(string maHocSinh, string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            DataTable dataTable = DiemDAO.Instance.LayDanhSachDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
            float tongDiem = 0;
            int tongHeSo = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["MaLoai"].ToString() == "LD0001")
                {
                    float diem = Convert.ToSingle(row["Diem"].ToString());
                    int heSo = Convert.ToInt32(row["HeSo"].ToString());
                    tongDiem += diem * heSo;
                    tongHeSo += heSo;
                }
            }

            if (tongHeSo <= 0) return 0;
            return (float)Math.Round(tongDiem / tongHeSo, 2);
        }

        public float LayDiem15PhutTB(string maHocSinh, string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            DataTable dataTable = DiemDAO.Instance.LayDanhSachDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
            float tongDiem = 0;
            int tongHeSo = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["MaLoai"].ToString() == "LD0002")
                {
                    float diem = Convert.ToSingle(row["Diem"].ToString());
                    int heSo = Convert.ToInt32(row["HeSo"].ToString());
                    tongDiem += diem * heSo;
                    tongHeSo += heSo;
                }
            }

            if (tongHeSo <= 0) return 0;
            return (float)Math.Round(tongDiem / tongHeSo, 2);
        }

        public float LayDiem45PhutTB(string maHocSinh, string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            DataTable dataTable = DiemDAO.Instance.LayDanhSachDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
            float tongDiem = 0;
            int tongHeSo = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["MaLoai"].ToString() == "LD0003")
                {
                    float diem = Convert.ToSingle(row["Diem"].ToString());
                    int heSo = Convert.ToInt32(row["HeSo"].ToString());
                    tongDiem += diem * heSo;
                    tongHeSo += heSo;
                }
            }

            if (tongHeSo <= 0) return 0;
            return (float)Math.Round(tongDiem / tongHeSo, 2);
        }

        public float LayDiemThi(string maHocSinh, string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            DataTable dataTable = DiemDAO.Instance.LayDanhSachDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
            float tongDiem = 0;
            int tongHeSo = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                if (row["MaLoai"].ToString() == "LD0004")
                {
                    float diem = Convert.ToSingle(row["Diem"].ToString());
                    int heSo = Convert.ToInt32(row["HeSo"].ToString());
                    tongDiem += diem * heSo;
                    tongHeSo += heSo;
                }
            }

            if (tongHeSo <= 0) return 0;
            return (float)Math.Round(tongDiem / tongHeSo, 2);
        }

        public float LayDiemTBHKTheoMon(string maHocSinh, string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            DataTable dataTable = DiemDAO.Instance.LayDanhSachDiemHocSinh(maHocSinh, maMonHoc, maHocKy, maNamHoc, maLop);
            float tongDiem = 0;
            int tongHeSo = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                float diem = Convert.ToSingle(row["Diem"].ToString());
                int heSo = Convert.ToInt32(row["HeSo"].ToString());
                tongDiem += diem * heSo;
                tongHeSo += heSo;
            }

            if (tongHeSo <= 0) return 0;
            return (float)Math.Round(tongDiem / tongHeSo, 2);
        }

        public float LayDiemTBHKChung(string maHocSinh, string maLop, string maNamHoc, string maHocKy)
        {
            DataTable dataTable = MonHocDAO.Instance.LayDanhSachMonHoc(maNamHoc, maLop);
            float tongDiemCacMon = 0;
            int tongHeSoCacMon = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                float diemTBTungMon = LayDiemTBHKTheoMon(maHocSinh, maLop, maNamHoc, row["MaMonHoc"].ToString(), maHocKy);
                int heSo = Convert.ToInt32(row["HeSo"].ToString());
                tongDiemCacMon += diemTBTungMon * heSo;
                tongHeSoCacMon += heSo;
            }

            if (tongHeSoCacMon <= 0) return 0;
            return (float)Math.Round(tongDiemCacMon / tongHeSoCacMon, 2);
        }

        public float LayDiemTBCNTheoMon(string maHocSinh, string maLop, string maNamHoc, string maMonHoc)
        {
            DataTable dataTable = HocKyDAO.Instance.LayDanhSachHocKy();
            float tongDiem = 0;
            int tongHeSo = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                int heSo = Convert.ToInt32(row["HeSo"].ToString());
                tongDiem += LayDiemTBHKTheoMon(maHocSinh, maMonHoc, row["MaHocKy"].ToString(), maNamHoc, maLop) * heSo;
                tongHeSo += heSo;
            }

            if (tongHeSo <= 0) return 0;
            return (float)Math.Round(tongDiem / tongHeSo, 2);
        }

        public float LayDiemTBCNChung(string maHocSinh, string maLop, string maNamHoc)
        {
            DataTable dataTable = MonHocDAO.Instance.LayDanhSachMonHoc(maNamHoc, maLop);
            float tongDiemCacMon = 0;
            int tongHeSoCacMon = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                float diemTBTungMon = LayDiemTBCNTheoMon(maHocSinh, maLop, maNamHoc, row["MaMonHoc"].ToString());
                int heSo = Convert.ToInt32(row["HeSo"].ToString());
                tongDiemCacMon += diemTBTungMon * heSo;
                tongHeSoCacMon += heSo;
            }

            if (tongHeSoCacMon <= 0) return 0;
            return (float)Math.Round(tongDiemCacMon / tongHeSoCacMon, 2);
        }

        public int LaySoLuongDat(string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh(maNamHoc, maLop);
            int diemDat = QuyDinhDAO.Instance.LayDiemDatQuyDinh();
            int soLuongDat = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                float diemTBHK = LayDiemTBHKTheoMon(row["MaHocSinh"].ToString(), maLop, maNamHoc, maMonHoc, maHocKy);
                soLuongDat += Convert.ToInt32(diemTBHK >= diemDat);
            }
            return soLuongDat;
        }

        public int LaySoLuongDat(string maLop, string maNamHoc, string maHocKy)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh(maNamHoc, maLop);
            int diemDat = QuyDinhDAO.Instance.LayDiemDatQuyDinh();
            int soLuongDat = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                float diemTBHK = LayDiemTBHKChung(row["MaHocSinh"].ToString(), maLop, maNamHoc, maHocKy);
                soLuongDat += Convert.ToInt32(diemTBHK >= diemDat);
            }
            return soLuongDat;
        }

        public void ThemDiem(DiemDTO diem)
        {
            DiemDAO.Instance.ThemDiem(diem);
        }

        public void XoaDiem(int stt)
        {
            DiemDAO.Instance.XoaDiem(stt);
        }
    }
}
