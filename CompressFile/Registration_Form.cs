namespace CompressFile
{
    public partial class Registration_Form : Form
    {
        private const string RegistrationGif_path = "E:\\Microsoft Visual Studio(projects)\\CompressFile\\CompressFile\\Reg_Background\\giphy_Registration.gif";
        private Bitmap Reg_Background;
        private Point Draw;
        private Rectangle rectangle;
        private String reg_login;
        private String reg_password;
        public Registration_Form()
        {
            InitializeComponent();
            Reg_Background = new Bitmap(RegistrationGif_path);
            Draw = new Point(-180, -60);
            rectangle = new Rectangle(Draw, Reg_Background.Size);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            panel1.BackColor = Color.FromArgb(80, Color.Black);
        }

        protected override void OnPaint(PaintEventArgs args)
        {            
            ImageAnimator.UpdateFrames(Reg_Background);
            args.Graphics.DrawImage(Reg_Background, Draw);            
        }

        private void OnFrameChanged(object sender, EventArgs e) => this.Invalidate();

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            if (ImageAnimator.CanAnimate(Reg_Background))
            {
                ImageAnimator.Animate(Reg_Background, new EventHandler(this.OnFrameChanged));
            }

            Animated_Welcome_Label();
        }

        private void Registration_Form_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
         
        private void Button_confirm_Click(object sender, EventArgs e)
        {
            reg_login = Login_textBox.Text;
            reg_password = Password_textBox.Text;
            new MySQL_Connect_With_Data(MySQLMode.LogIn, form: this).Connect_By_LogIn(reg_login, reg_password);
        }

        private void Sign_In_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => BackToSignIn();

        private void BackToSignIn()
        {
            Authorisation_Form ReSigningIn = new Authorisation_Form();
            ReSigningIn.Show();
            this.Hide();
        }

        private async void Animated_Welcome_Label()
        {
            string Welcome = "Welcome to Compress File App";
            for(int i = 0; i < Welcome.Length; i++)
            {
                Welcome_label.Text += Welcome[i].ToString();
                await Task.Delay(100);
            }
        }              
    }
}
