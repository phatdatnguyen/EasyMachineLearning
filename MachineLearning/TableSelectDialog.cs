using System;
using System.Windows.Forms;

namespace MachineLearning
{
    public partial class TableSelectDialog : Form
    {
        //Property
        public string Selection
        {
            get
            {
                if (tablesListBox.SelectedIndex == -1)
                    return "";
                else
                    return tablesListBox.SelectedItem as string;
            }
        }

        //Contructor
        public TableSelectDialog(string[] tables)
        {
            InitializeComponent();

            tablesListBox.DataSource = tables;
        }

        //Method
        private void tablesListBox_DoubleClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
