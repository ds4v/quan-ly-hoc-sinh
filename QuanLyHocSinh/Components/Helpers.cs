using BUS;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public static class Utilities
    {
        public static void ShowForm(string formName, bool mdiParent = true)
        {
            Form frm = Application.OpenForms[formName];
            if (frm != null) frm.Activate();
            else
            {
                Type type = Type.GetType($"QuanLyHocSinh.{formName}");
                frm = (Form)Activator.CreateInstance(type);
                if(mdiParent) frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
        }

        public static string LaySTT(int autoNum)
        {
            if (autoNum < 10) return "000" + autoNum;
            else if (autoNum >= 10 && autoNum < 100) return "00" + autoNum;
            else if (autoNum >= 100 && autoNum < 1000) return "0" + autoNum;
            else if (autoNum >= 1000 && autoNum < 10000) return "" + autoNum;
            return "";
        }
    }

    public static class KiemTraTruocKhiLuu
    {
        public static bool KiemTraDataGridView(DataGridView dataGridView, string[] colNames)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (string col in colNames)
                {
                    if (row.Cells[col].Value != null)
                    {
                        string str = row.Cells[col].Value.ToString();
                        if (string.IsNullOrWhiteSpace(str))
                        {
                            MessageBox.Show(
                                "Giá trị của ô không được rỗng !",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public static bool KiemTraDiem(DataGridView dataGridView, string[] colNames)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (string col in colNames)
                {
                    if (row.Cells[col].Value != null)
                    {
                        string chuoiDiem = row.Cells[col].Value.ToString();
                        int count = 0;

                        for (int i = 0; i < chuoiDiem.Length; i++)
                        {
                            if (chuoiDiem[i] != ';' && i != chuoiDiem.Length - 1) count++;
                            else
                            {
                                if (i == chuoiDiem.Length - 1)
                                {
                                    i++;
                                    count++;
                                }

                                string diemDaXuLy = chuoiDiem.Substring(i - count, count);
                                if (count != 0 && !QuyDinhBUS.Instance.KiemTraDiem(diemDaXuLy))
                                {
                                    MessageBox.Show(
                                        $"Điểm của học sinh {row.Cells["colHoTen"].Value} không hợp lệ!",
                                        "ERROR",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error
                                    );
                                    return false;
                                }
                                count = 0;
                            }
                        }
                    }
                }
            }
            return true;
        }
        
        public static bool KiemTraSiSo(DataGridView dataGridView, string colSiSo)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[colSiSo].Value != null)
                {
                    try
                    {
                        int siSo = Convert.ToInt32(row.Cells[colSiSo].Value.ToString());
                        if (!QuyDinhBUS.Instance.KiemTraSiSo(siSo))
                        {
                            MessageBox.Show(
                                "Sỉ số không đúng quy định!",
                                "ERROR",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                            );
                            return false;
                        }
                    }
                    catch
                    {
                        MessageBox.Show(
                            "Sỉ số phải là một số nguyên!",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool KiemTraHeSo(DataGridView dataGridView, string colHeSo)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[colHeSo].Value != null)
                {
                    string str = row.Cells[colHeSo].Value.ToString();
                    if (string.IsNullOrWhiteSpace(str) || str == "0")
                    {
                        MessageBox.Show(
                            "Giá trị của ô không được rỗng và hệ số phải lớn hơn 0 !",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool KiemTraDoTuoi(DataGridView dataGridView, string colDoTuoi)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[colDoTuoi].Value != null)
                {
                    DateTime ngaySinh = Convert.ToDateTime(row.Cells[colDoTuoi].Value.ToString());

                    if (!QuyDinhBUS.Instance.KiemTraDoTuoi(ngaySinh))
                    {
                        MessageBox.Show(
                            $"Tuổi học sinh {row.Cells["colHoTen"].Value} không đúng quy định !", 
                            "ERROR", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
