using DTO;
using System;
using System.Data;

namespace DAO
{
    public class DiemDAO
    {
        private static DiemDAO instance;

        private DiemDAO() { }

        public static DiemDAO Instance
        {
            get
            {
                if (instance == null) instance = new DiemDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachDiem(string maHocSinh, string maMonHoc, string maHocKy, string maNamHoc, string maLop)
        {
            string query = $@"
                SELECT * FROM DIEM D, HOCSINH S, MONHOC H, LOAIDIEM O, LOP L 
                WHERE D.MaHocSinh = S.MaHocSinh 
                  AND D.MaMonHoc = H.MaMonHoc 
                  AND D.MaLoai = O.MaLoai 
                  AND D.MaLop = L.MaLop 
                  AND S.MaHocSinh = '{ maHocSinh }'
                  AND H.MaMonHoc = '{ maMonHoc }'
                  AND D.MaHocKy = '{ maHocKy }'
                  AND D.MaNamHoc = '{ maNamHoc }'
                  AND L.MaLop = '{ maLop }'
            ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void ThemDiem(DiemDTO diem)
        {
            string query = "EXEC ThemDiem @maHocSinh , @maMonHoc , @maHocKy , @maNamHoc , @maLop , @maLoaiDiem , @diemSo";
            object[] parameters = new object[] { 
                diem.MaHocSinh, diem.MaMonHoc, diem.MaHocKy, diem.MaNamHoc, diem.MaLop, diem.MaLoaiDiem, diem.DiemSo 
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void XoaDiem(int stt)
        {
            string query = "EXEC XoaDiem @STT";
            object[] parameters = new object[] { stt };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
