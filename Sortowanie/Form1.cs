using System.Text.RegularExpressions;

namespace Sortowanie
{
    public partial class Form1 : Form
    {
        FileContentSort fileContentSort;
        public Form1()
        {
            InitializeComponent();
            cB_sortMode.Items.AddRange(Enum.GetNames(typeof(SortMode)));
        }

        private void b_loadFile_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = oFD_load.ShowDialog();
            MessageBox.Show(dialogResult + " " + oFD_load.CheckFileExists + " " + oFD_load.FileName);
            if (dialogResult == DialogResult.OK && oFD_load.CheckFileExists)
            {
                fileContentSort = new FileContentSort(oFD_load.FileName);
                rTB_output.Text = fileContentSort.ToString();
                gB_sortOptions.Enabled = true;
            }
        }

        private void b_sort_Click(object sender, EventArgs e)
        {
            if (fileContentSort != null && cB_sortMode.SelectedIndex >= 0)
            {
                fileContentSort.Sort((SortMode)cB_sortMode.SelectedIndex);
                rTB_output.Text = $"{fileContentSort}\n*\t*\t*\n{fileContentSort.SortInfo()}";
            }
        }
    }
}