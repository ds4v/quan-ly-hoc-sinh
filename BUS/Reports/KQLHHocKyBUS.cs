using System.Collections.Generic;
using System;
using DTO;
using System.Data;
using DAO;

namespace BUS
{
    public class KQLHHocKyBUS
    {
        private static KQLHHocKyBUS instance;

        private KQLHHocKyBUS() { }

        public static KQLHHocKyBUS Instance
        {
            get
            {
                if (instance == null) instance = new KQLHHocKyBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void LuuKetQua(string maLop, string maNamHoc, string maHocKy)
        {
            LopDTO lop = new LopDTO();
            lop.MaLop = maLop;
            lop.SiSo = LopDAO.Instance.LaySiSo(maLop);

            HocKyDTO hocKy = new HocKyDTO();
            hocKy.MaHocKy = maHocKy;

            NamHocDTO namHoc = new NamHocDTO();
            namHoc.MaNamHoc = maNamHoc;

            int soLuongDat = DiemBUS.Instance.LaySoLuongDat(maLop, maNamHoc, maHocKy);
            KQLHHocKyDAO.Instance.XoaKetQua(maLop, maNamHoc, maHocKy);
            KQLHHocKyDAO.Instance.LuuKetQua(new KQLHHocKyDTO(
                lop,
                namHoc,
                hocKy,
                soLuongDat,
                Convert.ToSingle(Math.Round(soLuongDat * 100F / lop.SiSo, 2))
            ));
        }

        public IList<KQLHHocKyDTO> Report(string maNamHoc, string maHocKy)
        {
            DataTable dataTable = KQLHHocKyDAO.Instance.Report(maNamHoc, maHocKy);
            IList<KQLHHocKyDTO> ilist = new List<KQLHHocKyDTO>();

            foreach (DataRow Row in dataTable.Rows)
            {
                LopDTO lop = new LopDTO();
                lop.MaLop = Convert.ToString(Row["MaLop"]);
                lop.TenLop = Convert.ToString(Row["TenLop"]);
                lop.SiSo = Convert.ToInt32(Row["SiSo"]);

                NamHocDTO namHoc = new NamHocDTO();
                namHoc.MaNamHoc = Convert.ToString(Row["MaNamHoc"]);
                namHoc.TenNamHoc = Convert.ToString(Row["TenNamHoc"]);

                HocKyDTO hocKy = new HocKyDTO();
                hocKy.MaHocKy = Convert.ToString(Row["MaHocKy"]);
                hocKy.TenHocKy = Convert.ToString(Row["TenHocKy"]);

                ilist.Add(new KQLHHocKyDTO(
                    lop,
                    namHoc,
                    hocKy,
                    Convert.ToInt32(Row["SoLuongDat"]),
                    Convert.ToSingle(Row["TiLe"])
                ));
            }
            return ilist;
        }
    }
}
