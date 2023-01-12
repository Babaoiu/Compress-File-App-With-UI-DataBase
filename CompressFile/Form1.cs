using MySql.Data.MySqlClient;
namespace CompressFile
{
    public partial class Welcome_folder : Form
    {
        private const string GifPath = "E:\\Microsoft Visual Studio(projects)\\CompressFile\\CompressFile\\Reg_Background\\giphy.gif";
        private Bitmap GifBackGround;
        private Point Draw;
        private Rectangle InvalidRectangle;
        public Welcome_folder()
        {
            InitializeComponent();
            GifBackGround = new Bitmap(GifPath);
            Draw = new Point(80, 50);
            InvalidRectangle = new Rectangle(Draw, GifBackGround.Size);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ImageAnimator.UpdateFrames(GifBackGround);
            e.Graphics.DrawImage(GifBackGround, Draw);
        }

        private void OnFrameChanged(object sender, EventArgs e) => this.Invalidate();

        private void Welcome_folder_Load(object sender, EventArgs e)
        {
            Tag_Zeit();
            if(ImageAnimator.CanAnimate(GifBackGround))
            {
                ImageAnimator.Animate(GifBackGround, new EventHandler(this.OnFrameChanged));
            }
            Opacity_Of_Eingang();
        }
                
        async void Opacity_Of_Eingang()
        {
            for (Opacity = 0; Opacity < 1; Opacity += 0.03)
            {
                await Task.Delay(1);
            }
        }

        private void Tag_Zeit()
        {
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour <= 11)
                Welcome_text.Text = "Good Morning";
            else if (DateTime.Now.Hour > 11 && DateTime.Now.Hour <= 17)
                Welcome_text.Text = "Good Afternoon";
            else if (DateTime.Now.Hour > 17 && DateTime.Now.Hour <= 23)
                Welcome_text.Text = "Good Evening";
            else            
                Welcome_text.Text = "Sweet Dreams";            
        }

        private void Welcome_text_Click(object sender, EventArgs e)
        {
            Authorisation_Form OpenNext = new Authorisation_Form();
            OpenNext.Show();
            this.Hide();
        }
        
    }
}