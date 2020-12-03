using DAO;
using System;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class QuyDinhBUS
    {
        private static QuyDinhBUS instance;

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
