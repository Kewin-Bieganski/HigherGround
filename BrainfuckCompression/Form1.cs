namespace BrainfuckCompression
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            oFD_read.InitialDirectory = sFD_write.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            oFD_read.Filter = sFD_write.Filter = "Plik tekstowy (*.txt)|*.txt";
            oFD_read.DefaultExt = sFD_write.DefaultExt = "txt";
        }

        private void b_compress_Click(object sender, EventArgs e)
        {
            CatchProvider(BrainfuckCodec.BrainfuckCompression);
        }

        private void b_decompress_Click(object sender, EventArgs e)
        {
            CatchProvider(BrainfuckCodec.BrainfuckDecompression);
        }

        private void CatchProvider(Func<string, string> output) {
            try
            {
                rTB_output.Text = output(rTB_input.Text);
            }
            catch (ArgumentException argumentException)
            {
                rTB_output.Text = $"Oops! ArgumentException => {argumentException.Message}";
            }
            catch (Exception exception)
            {
                rTB_output.Text = $"Oops! Exception => {exception.Message}";
            }
        }

        private void b_read_Click(object sender, EventArgs e)
        {
            if(oFD_read.ShowDialog() == DialogResult.OK && oFD_read.CheckFileExists)
            {
                rTB_input.Text = File.ReadAllText(oFD_read.FileName);
                MessageBox.Show($"Wczytano plik {sFD_write.FileName}", "Informacja");
            } else
            {
                MessageBox.Show("Nie wczytano pliku", "B³¹d");
            }
        }

        private void b_write_Click(object sender, EventArgs e)
        {
            if (sFD_write.ShowDialog() == DialogResult.OK && oFD_read.CheckFileExists)
            {
                File.WriteAllText(sFD_write.FileName, rTB_output.Text);
                MessageBox.Show($"Zapisano plik {sFD_write.FileName}", "Informacja");
            } else
            {
                MessageBox.Show("Nie zapisano pliku", "B³¹d");
            }
        }
    }
}