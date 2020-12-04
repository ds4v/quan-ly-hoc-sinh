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
            IntegerInput txtSiSoCanDuoi, 
            IntegerInput txtSiSoCanTren, 
            IntegerInput txtDoTuoiCanDuoi, 
            IntegerInput txtDoTuoiCanTren, 
            CheckBoxX ckbThang10, 
            CheckBoxX ckbThang100)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LayDanhSachQuyDinh();
            bindingSource.DataSource = dataTable;

            int thangDiem = Convert.ToInt32(dataTable.Rows[0]["ThangDiem"]);
            if (thangDiem == 10) ckbThang10.Checked = true;
            else ckbThang100.Checked = true;

            txtSiSoCanDuoi.DataBindings.Clear();
            txtSiSoCanDuoi.DataBindings.Add("Value", bindingSource, "SiSoCanDuoi");

            txtSiSoCanTren.DataBindings.Clear();
            txtSiSoCanTren.DataBindings.Add("Value", bindingSource, "SiSoCanTren");

            txtDoTuoiCanDuoi.DataBindings.Clear();
            txtDoTuoiCanDuoi.DataBindings.Add("Value", bindingSource, "TuoiCanDuoi");

            txtDoTuoiCanTren.DataBindings.Clear();
            txtDoTuoiCanTren.DataBindings.Add("Value", bindingSource, "TuoiCanTren");
        }

        public void CapNhatSiSoQuyDinh(int siSoCanDuoi, int siSoCanTren)
        {
            QuyDinhDAO.Instance.CapNhatSiSoQuyDinh(siSoCanDuoi, siSoCanTren);
        }

        public void CapNhatDoTuoiQuyDinh(int tuoiCanDuoi, int tuoiCanTren)
        {
            QuyDinhDAO.Instance.CapNhatDoTuoiQuyDinh(tuoiCanDuoi, tuoiCanTren);
        }

        public void CapNhatThangDiemQuyDinh(int thangDiem)
        {
            QuyDinhDAO.Instance.CapNhatThangDiemQuyDinh(thangDiem);
        }

        public bool KiemTraSiSo(int siSo)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LaySiSoQuyDinh();

            int siSoMin = Convert.ToInt32(dataTable.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dataTable.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax) return true;
            else return false;
        }

        public bool KiemTraDoTuoi(DateTime ngaySinh)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LayDoTuoiQuyDinh();

            int doTuoiMin = Convert.ToInt32(dataTable.Rows[0]["TuoiCanDuoi"]);
            int doTuoiMax = Convert.ToInt32(dataTable.Rows[0]["TuoiCanTren"]);

            int doTuoi = DateTime.Today.Year - ngaySinh.Year;
            if (doTuoi >= doTuoiMin && doTuoi <= doTuoiMax)  return true;
            else return false;
        }

        public bool KiemTraDiem(string diem)
        {
            IList<string> gioiHanDiem = new List<string>();
            DataTable dataTable = QuyDinhDAO.Instance.LayThangDiemQuyDinh();

            int thangDiem = Convert.ToInt32(dataTable.Rows[0]["ThangDiem"]);
            float nacDiemTrongGioiHan = 0;

            if (thangDiem == 10)
            {
                for (int i = 0; i <= 1010; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 0.01F;
                    nacDiemTrongGioiHan = (float)Math.Round(nacDiemTrongGioiHan, 2);
                }

                if (gioiHanDiem.Contains(diem)) return true;
                else return false;
            }
            else
            {
                for (int i = 0; i <= 100; i++)
                {
                    gioiHanDiem.Add(nacDiemTrongGioiHan.ToString());
                    nacDiemTrongGioiHan += 1;
                }

                if (gioiHanDiem.Contains(diem)) return true;
                else return false;
            }
        }
    }
}
