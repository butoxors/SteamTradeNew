using System.Windows.Forms;

namespace Extensions
{
    public static class DataGridViewExtension
    {
        public static void Init(this DataGridView d)
        {
            d.AutoGenerateColumns = true;
            d.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing;
            d.RowHeadersVisible = false;
            d.ColumnHeadersHeight = 10;
        }
    }
}
