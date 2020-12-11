using DAO;
using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class HocLucBUS
    {
        private static HocLucBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HocLucBUS() { }

        public static HocLucBUS Instance
        {
            get
            {
                if (instance == null) instance = new HocLucBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = HocLucDAO.Instance.LayDanhSachHocLuc();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void CapNhatHocLuc(DataTable dataTable)
        {
            HocLucDAO.Instance.CapNhatHocLuc(dataTable);
        }

        public string XepLoaiHocLucMonHoc(float[] arrayDiemTBTungMon, float tongDiem)
        {
            string xepLoai = "";
            float diemTBMonNhoNhat = arrayDiemTBTungMon[0];

            for (int i = 0; i < arrayDiemTBTungMon.Length - 1; i++)
                if (arrayDiemTBTungMon[i] < diemTBMonNhoNhat)
                    diemTBMonNhoNhat = arrayDiemTBTungMon[i];

            DataTable dataTable = HocLucDAO.Instance.LayDanhSachHocLuc();
            string[] maHocLuc = new string[dataTable.Rows.Count];
            float[] diemCanDuoi = new float[dataTable.Rows.Count];

            int count = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                maHocLuc[count] = row["MaHocLuc"].ToString();
                diemCanDuoi[count] = float.Parse(row["DiemCanDuoi"].ToString());
                count++;
            }

            for (int i = 0; i < count - 1; i++)
            {
                if (tongDiem >= diemCanDuoi[i] && diemTBMonNhoNhat >= diemCanDuoi[i + 1])
                {
                    xepLoai = maHocLuc[i];
                    break;
                }
            }

            if (xepLoai == "") xepLoai = maHocLuc[count - 1].ToString();
            return xepLoai;
        }

        public string XepLoaiHocLucCaNam(string maHocSinh, string maLop, string maNamHoc)
        {
            DataTable dataTable = MonHocDAO.Instance.LayDanhSachMonHoc(maNamHoc, maLop);
            float tongDiemCacMon = 0;
            int tongHeSoCacMon = 0;

            float[] arrayDiemTBTungMon = new float[dataTable.Rows.Count];
            int soMonHoc = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                float diemTBTungMon = DiemBUS.Instance.LayDiemTBCNTheoMon(maHocSinh, row["MaMonHoc"].ToString(), maNamHoc, maLop);
                int heSo = Convert.ToInt32(row["HeSo"].ToString());

                arrayDiemTBTungMon[soMonHoc++] = diemTBTungMon;
                tongDiemCacMon += diemTBTungMon * heSo;
                tongHeSoCacMon += heSo;
            }

            float tongDiem;
            if (tongHeSoCacMon <= 0) tongDiem = 0;
            else tongDiem = tongDiemCacMon / tongHeSoCacMon;
            return XepLoaiHocLucMonHoc(arrayDiemTBTungMon, tongDiem);
        }
    }
}
