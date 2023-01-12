using Aspose.Imaging.FileFormats.Jpeg;
using Aspose.Imaging.ImageOptions;

namespace CompressFile
{
    public interface ICompress_Other_Formats
    {
        void Compress_Files();
    }

    public class Compress_Image_Jpeg : ICompress_Other_Formats
    {
        private string _FileName;
        private string path;
        public Compress_Image_Jpeg(string FileName)
        {
            this._FileName = FileName;
            path = Path.GetFullPath(_FileName);
        }

        public void Compress_Files()
        {
            using (var image = Aspose.Imaging.Image.Load(_FileName))
            {
                var jpegOptions = new JpegOptions()
                {
                    ColorType = JpegCompressionColorMode.Grayscale,
                    CompressionType = JpegCompressionMode.Progressive,
                };

                image.Save($"{path}_out.jpg", jpegOptions);
            }
        }
    }

    public class Compress_Image_PNG : ICompress_Other_Formats
    {
        private string _FileName;
        private string path;
        public Compress_Image_PNG(string FileName)
        {
            this._FileName = FileName;
            path = Path.GetFullPath(_FileName);
        }

        public void Compress_Files()
        {
            using (var image = Aspose.Imaging.Image.Load(_FileName))
            {
                PngOptions pngOptions = new PngOptions();
                pngOptions.CompressionLevel = 1;
                image.Save($"{path}_out.png", pngOptions);
            }
        }
    }

    //public class Compress_Video_MP4 : ICompress_Other_Formats    
}
