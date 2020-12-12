using DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class QuyDinhBUS
    {
        private static QuyDinhBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private QuyDinhBUS() { }
        public static QuyDinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new QuyDinhBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            IntegerInput txtDoTuoiCanDuoi,
            IntegerInput txtDoTuoiCanTren,
            IntegerInput txtSiSoCanDuoi, 
            IntegerInput txtSiSoCanTren, 
            IntegerInput txtDiemDat)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LayDanhSachQuyDinh();
            bindingSource.DataSource = dataTable;

            txtDoTuoiCanDuoi.DataBindings.Clear();
            txtDoTuoiCanDuoi.DataBindings.Add("Value", bindingSource, "TuoiCanDuoi");

            txtDoTuoiCanTren.DataBindings.Clear();
            txtDoTuoiCanTren.DataBindings.Add("Value", bindingSource, "TuoiCanTren");

            txtSiSoCanDuoi.DataBindings.Clear();
            txtSiSoCanDuoi.DataBindings.Add("Value", bindingSource, "SiSoCanDuoi");

            txtSiSoCanTren.DataBindings.Clear();
            txtSiSoCanTren.DataBindings.Add("Value", bindingSource, "SiSoCanTren");

            txtDiemDat.DataBindings.Clear();
            txtDiemDat.DataBindings.Add("Value", bindingSource, "DiemDat");
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            QuyDinhDAO.Instance.CapNhatQuyDinhDoTuoi(tuoiCanDuoi, tuoiCanTren);
        }

        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            QuyDinhDAO.Instance.CapNhatQuyDinhSiSo(siSoCanDuoi, siSoCanTren);
        }

        public void CapNhatQuyDinhDiemDat(int diemDat)
        {
            QuyDinhDAO.Instance.CapNhatQuyDinhDiemDat(diemDat);
        }

        public bool KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LayDoTuoiQuyDinh();

            int doTuoiMin = Convert.ToInt32(dataTable.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dataTable.Rows[0]["TuoiCanTren"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;
            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax) return true;
            else return false;
        }

        public bool KiemTraSiSo(int siSo)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LaySiSoQuyDinh();

            int siSoMin = Convert.ToInt32(dataTable.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dataTable.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax) return true;
            else return false;
        }

        public bool KiemTraDiem(string diem)
        {
            IList<string> gioiHanDiem = new List<string>();
            float nacDiemTrongGioiHan = 0;

            for (int i = 0; i <= 1010; i++)
            {
                gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                nacDiemTrongGioiHan += 0.01F;
                nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
            }

            if (gioiHanDiem.Contains(diem)) return true;
            else return false;
        }
    }
}
