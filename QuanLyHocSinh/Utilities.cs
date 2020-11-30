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

        public static bool KiemTraTruocKhiLuu(DataGridView dataGridView, string colName)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[colName].Value != null)
                {
                    string str = row.Cells[colName].Value.ToString();
                    if (string.IsNullOrWhiteSpace(str))
                    {
                        MessageBox.Show(
                            "Giá trị của ô không được rỗng!",
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
    }
}
