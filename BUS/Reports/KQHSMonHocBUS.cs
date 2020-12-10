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

        public void LuuKetQua(string maHocSinh, string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            HocSinhDTO hocSinh = new HocSinhDTO();
            LopDTO lop = new LopDTO();
            MonHocDTO monHoc = new MonHocDTO();
            HocKyDTO hocKy = new HocKyDTO();
            NamHocDTO namHoc = new NamHocDTO();

            hocSinh.MaHocSinh = maHocSinh;
            lop.MaLop = maLop;
            monHoc.MaMonHoc = maMonHoc;
            hocKy.MaHocKy = maHocKy;
            namHoc.MaNamHoc = maNamHoc;

            KQHSMonHocDTO ketQua = new KQHSMonHocDTO(
                hocSinh,
                lop,
                monHoc,
                hocKy,
                namHoc,
                DiemBUS.Instance.LayDiemMiengTB(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc),
                DiemBUS.Instance.LayDiem15PhutTB(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc),
                DiemBUS.Instance.LayDiem45PhutTB(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc),
                DiemBUS.Instance.LayDiemThi(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc),
                DiemBUS.Instance.LayDiemTBHK(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc)
            );
            KQHSMonHocDAO.Instance.XoaKetQua(maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc);
            KQHSMonHocDAO.Instance.LuuKetQua(ketQua);
        }

        public IList<KQHSMonHocDTO> ReportKQHSMonHoc(string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            DataTable dataTable = KQHSMonHocDAO.Instance.Report(maLop, maMonHoc, maHocKy, maNamHoc);
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
                ketQua.DiemMiengTB = Convert.ToSingle(Row["DiemMiengTB"]);
                ketQua.Diem15PhutTB = Convert.ToSingle(Row["Diem15PhutTB"]);
                ketQua.Diem45PhutTB = Convert.ToSingle(Row["Diem45PhutTB"]);
                ketQua.DiemThi = Convert.ToSingle(Row["DiemThi"]);
                ketQua.DiemTBHK = Convert.ToSingle(Row["DiemTBHK"]);

                ilist.Add(ketQua);
            }
            return ilist;
        }
    }
}
