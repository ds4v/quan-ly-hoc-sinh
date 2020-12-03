using System;
using System.Windows.Forms;

namespace QuanLyHocSinh.Components
{
    #region CalendarColumn
    public class CalendarColumn : DataGridViewColumn
    {
        public CalendarColumn() : base(new CalendarCell()) { }

        public override DataGridViewCell CellTemplate
        {
            get => base.CellTemplate;
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(CalendarCell)))
                    throw new InvalidCastException("Must be a CalendarCell");
                base.CellTemplate = value;
            }
        }
    }
    #endregion

    #region CalendarCell
    public class CalendarCell : DataGridViewTextBoxCell
    {
        public CalendarCell() : base() { Style.Format = "dd/MM/yyyy"; }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            CalendarEditingControl ctl = DataGridView.EditingControl as CalendarEditingControl;
            ctl.Value = (DateTime)Value;
        }

        public override Type EditType { get => typeof(CalendarEditingControl); }
        public override Type ValueType { get => typeof(DateTime); }
        public override object DefaultNewRowValue { get => DateTime.Now; }
    }
    #endregion

    #region CalendarEditingControl
    public class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
    {
        DataGridView dataGridView;
        private bool valueChanged = false;
        int rowIndex;

        public CalendarEditingControl() { Format = DateTimePickerFormat.Short; }

        public object EditingControlFormattedValue
        {
            get => Value.ToShortDateString();
            set
            {
                if (value is string)
                    Value = DateTime.Parse((string)value);
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            Font = dataGridViewCellStyle.Font;
            CalendarForeColor = dataGridViewCellStyle.ForeColor;
            CalendarMonthBackground = dataGridViewCellStyle.BackColor;
        }

        public int EditingControlRowIndex
        {
            get => rowIndex; 
            set => rowIndex = value; 
        }

        public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
        {
            switch (key & Keys.KeyCode)
            {
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Home:
                case Keys.End:
                case Keys.PageDown:
                case Keys.PageUp: return true;
                default: return false;
            }
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
            //No preparation needs to be done.
        }

        public bool RepositionEditingControlOnValueChange { get => false; }

        public DataGridView EditingControlDataGridView
        {
            get => dataGridView; 
            set => dataGridView = value; 
        }

        public bool EditingControlValueChanged
        {
            get => valueChanged; 
            set => valueChanged = value; 
        }

        public Cursor EditingPanelCursor { get => base.Cursor; }

        protected override void OnValueChanged(EventArgs eventargs)
        {
            valueChanged = true;
            EditingControlDataGridView.NotifyCurrentCellDirty(true);
            base.OnValueChanged(eventargs);
        }
    }
    #endregion
}
