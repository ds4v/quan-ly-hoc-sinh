using DAO;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace BUS
{
    public class TonGiaoBUS
    {
        private static TonGiaoBUS instance;

        private TonGiaoBUS() { }

        public static TonGiaoBUS Instance
        {
            get
            {
                if (instance == null) instance = new TonGiaoBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = TonGiaoDAO.Instance.LayDanhSachTonGiao();
            comboBox.DisplayMember = "TenTonGiao";
            comboBox.ValueMember = "MaTonGiao";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = TonGiaoDAO.Instance.LayDanhSachTonGiao();
            cmbColumn.DisplayMember = "TenTonGiao";
            cmbColumn.ValueMember = "MaTonGiao";
            cmbColumn.DataPropertyName = "MaTonGiao";
            cmbColumn.HeaderText = "Tôn giáo";
        }
    }
}
