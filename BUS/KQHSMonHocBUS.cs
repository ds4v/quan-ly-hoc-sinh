using System.Collections.Generic;
using System;
using DTO;
using System.Data;
using DAO;

namespace BUS
{
    public class KQHSMonHocBUS
    {
        private static KQHSMonHocBUS instance;

        private KQHSMonHocBUS() { }

        public static KQHSMonHocBUS Instance
        {
            get
            {
                if (instance == null) instance = new KQHSMonHocBUS();
                return instance;
            }
            private set => instance = value;
        }

        public IList<KQHSMonHocDTO> ReportKQHSMonHoc(string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            DataTable dataTable = KQHSMonHocDAO.Instance.ReportKQHSMonHoc(maLop, maMonHoc, maHocKy, maNamHoc);
            IList<KQHSMonHocDTO> ilist = new List<KQHSMonHocDTO>();

            foreach (DataRow Row in dataTable.Rows)
            {
                KQHSMonHocDTO ketQua = new KQHSMonHocDTO();

                HocSinhDTO hocSinh = new HocSinhDTO();
                hocSinh.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hocSinh.HoTen = Convert.ToString(Row["HoTen"]);

                LopDTO lop = new LopDTO();
                lop.MaLop = Convert.ToString(Row["MaLop"]);
                lop.TenLop = Convert.ToString(Row["TenLop"]);

                MonHocDTO monHoc = new MonHocDTO();
                monHoc.MaMonHoc = Convert.ToString(Row["MaMonHoc"]);
                monHoc.TenMonHoc = Convert.ToString(Row["TenMonHoc"]);

                HocKyDTO hocKy = new HocKyDTO();
                hocKy.MaHocKy = Convert.ToString(Row["MaHocKy"]);
                hocKy.TenHocKy = Convert.ToString(Row["TenHocKy"]);

                NamHocDTO namHoc = new NamHocDTO();
                namHoc.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                namHoc.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

                ketQua.HocSinh = hocSinh;
                ketQua.Lop = lop;
                ketQua.MonHoc = monHoc;
                ketQua.HocKy = hocKy;
                ketQua.NamHoc = namHoc;
                ketQua.Diem15Phut = Convert.ToSingle(Row["Diem15Phut"]);
                ketQua.Diem45Phut = Convert.ToSingle(Row["Diem45Phut"]);
                ketQua.DiemThi = Convert.ToSingle(Row["DiemThi"]);
                ketQua.DiemTB = Convert.ToSingle(Row["DiemTB"]);

                ilist.Add(ketQua);
            }
            return ilist;
        }
    }
}
