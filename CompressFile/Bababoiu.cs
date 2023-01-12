using System.IO.Compression;

namespace CompressFile
{
    public partial class Bababoiu : Form
    {
        private OpenFileDialog OpenFile;
        private ICompress_Other_Formats _compress_files;
        public Bababoiu()
        {
            InitializeComponent();
        }

        private void Bababoiu_Load(object sender, EventArgs e)
        {

        }
        
        private void Bababoiu_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
                            
        private void CompressedLoad_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            try
            {
                bool AcceptedChecking = CompressedLoad_label.LinkColor == Color.Green;
                bool IsJPG = OpenFile.FileName.EndsWith("jpg");
                bool IsPNG = OpenFile.FileName.EndsWith("png") || OpenFile.FileName.EndsWith("PNG");
                if (AcceptedChecking && OpenFile != null && !IsJPG && !IsPNG)
                {
                    using (FileStream FileIn = File.OpenRead(OpenFile.FileName))
                    {
                        using (FileStream FileOut = File.Create(OpenFile.FileName + ".gz"))
                        {
                            using (GZipStream gz = new GZipStream(FileOut, CompressionLevel.SmallestSize))
                            {
                                FileIn.CopyTo(gz);
                            }
                        }
                    }
                }
                else if(AcceptedChecking && OpenFile != null && IsJPG)
                {                    
                    _compress_files = new Compress_Image_Jpeg(OpenFile.FileName);
                    _compress_files.Compress_Files();
                }
                else if(AcceptedChecking && OpenFile != null && IsPNG)
                {
                    _compress_files = new Compress_Image_PNG(OpenFile.FileName);
                    _compress_files.Compress_Files();
                }                
            }
            catch(FileNotFoundException ex) 
            {
                error_compressing.Text = "Something went wrong";
                CompressedLoad_label.Text = "Output File";
                CompressedLoad_label.LinkColor = Color.FromArgb(9, 163, 235);
            }
            catch (NullReferenceException ex) { }            
        }

        private void OpenDialog_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CompressedLoad_label.Text = "Output File";
            CompressedLoad_label.LinkColor = Color.FromArgb(9, 163, 235);
            using (OpenFile = new OpenFileDialog() { Filter = "All files|*.*", ValidateNames = true, Multiselect = false})
            {                
                if (OpenFile.ShowDialog() == DialogResult.OK)
                {
                    string FileName = OpenFile.FileName;
                    OpenDialog_label.Text = FileName;
                }
            }
        }

        private async void Compress_Start_Click(object sender, EventArgs e)
        {
            bool FulledBar = false;
            CompressedLoad_label.Text = "Output File";
            CompressedLoad_label.LinkColor = Color.FromArgb(9, 163, 235);
            error_compressing.Text = string.Empty;
            Compress_Start.Enabled = false;
            while (ProgressCompressing.Value != 100)
            {
                ProgressCompressing.Value++;
                await Task.Delay(1);
            }
            Compress_Start.Enabled = true;
            ProgressCompressing.Value = 0;

            FulledBar = true;
            if (FulledBar)
            {
                try
                {
                    if (OpenFile != null)
                    {
                        using(FileStream FileIn = File.OpenRead(OpenFile.FileName))
                        {
                            CompressedLoad_label.LinkColor = Color.Green;
                            CompressedLoad_label.Text = "Compressed";
                        }
                    }
                    else
                    {
                        throw new ArgumentException();
                    }
                }
                catch (FileNotFoundException ex)
                {
                    error_compressing.Text = "File doesn't exist";
                }
                catch(ArgumentException ex)
                {
                    error_compressing.Text = "Something went wrong";
                }
            }
        }

    }
}
//System.IO.FileNotFoundException