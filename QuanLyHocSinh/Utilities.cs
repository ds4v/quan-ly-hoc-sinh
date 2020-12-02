using BUS;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public static class Utilities 
    {
        public static void ShowForm(string formName) 
        {
            Form frm = Application.OpenForms[formName];
            if (frm != null) frm.Activate();
            else
            {
                Type type = Type.GetType($"QuanLyHocSinh.{formName}");
                frm = (Form)Activator.CreateInstance(type);
                frm.MdiParent = Form.ActiveForm;
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

        public static bool KiemTraTruocKhiLuu(DataGridView dataGridView, string[] colNames)
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

        public static bool KiemTraSiSoTruocKhiLuu(DataGridView dataGridView, string colSiSo)
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

        public static bool KiemTraHeSoTruocKhiLuu(DataGridView dataGridView, string colHeSo)
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

        public static bool KiemTraDiemTruocKhiLuu(DataGridView dataGridView, string[] colNames)
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
    }
}
