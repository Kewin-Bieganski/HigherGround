using Codecs;

namespace BrainfuckCompression
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            oFD_read.InitialDirectory = sFD_write.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            oFD_read.Filter = sFD_write.Filter = "Plik tekstowy (*.txt)|*.txt|Plik Brainfuck (*.bf)|*.bf|Plik binarny (*.dat)|*.dat|Wszystkie pliki (*.*)|*.*";
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

        private void CatchProvider(Func<string, string> output)
        {
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
            if (oFD_read.ShowDialog() == DialogResult.OK && oFD_read.CheckFileExists)
            {
                switch (Path.GetExtension(oFD_read.FileName))
                {
                    case ".dat":
                        rTB_input.Text = String.Join(null, File.ReadAllBytes(oFD_read.FileName).Select<byte, string>(b => { return Convert.ToString(b, 2).PadLeft(8, '0'); }));
                        break;
                    case ".bf":
                    default:
                        rTB_input.Text = File.ReadAllText(oFD_read.FileName);
                        return;
                }
                MessageBox.Show($"Wczytano plik {sFD_write.FileName}", "Informacja");
            }
            else
            {
                MessageBox.Show("Nie wczytano pliku", "B³¹d");
            }
        }

        private void b_write_Click(object sender, EventArgs e)
        {
            if (BrainfuckCodec.LatestConversion != BrainfuckCodec.ConversionType.NotSet && ChangeDefualtExtension() && sFD_write.ShowDialog() == DialogResult.OK && oFD_read.CheckFileExists)
            {
                switch (BrainfuckCodec.LatestConversion)
                {
                    case BrainfuckCodec.ConversionType.Compression:
                        using (FileStream output = File.OpenWrite(sFD_write.FileName))
                        using (BinaryWriter binaryWriter = new BinaryWriter(output))
                        {
                            binaryWriter.Write(BrainfuckCodec.CompressedBytes.ToArray());
                        }
                        break;
                    case BrainfuckCodec.ConversionType.Decompression:
                        File.WriteAllText(sFD_write.FileName, rTB_output.Text);
                        break;
                }
                MessageBox.Show($"Zapisano plik {sFD_write.FileName}", "Informacja");
            }
            else
            {
                MessageBox.Show("Nie zapisano pliku", "B³¹d");
            }
        }

        private bool ChangeDefualtExtension()
        {
            switch (BrainfuckCodec.LatestConversion)
            {
                case BrainfuckCodec.ConversionType.Compression:
                    sFD_write.DefaultExt = "dat";
                    return true;
                case BrainfuckCodec.ConversionType.Decompression:
                    sFD_write.DefaultExt = "bf";
                    return true;
                default:
                    return false;
            }
        }
    }
}