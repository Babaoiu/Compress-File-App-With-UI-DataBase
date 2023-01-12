namespace CompressFile
{
    public partial class Authorisation_Form : Form
    {        
        private String login;
        private String password;
        public Authorisation_Form()
        {
            
            InitializeComponent();            
        }
        
        private void Registration_form_Load(object sender, EventArgs e)
        {
            
        }

        private void Registration_form_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit(); 
                                                       
        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            error_register.Text = "Error login or password";
            login = Login_input.Text;
            password = Password_input.Text;
            new MySQL_Connect_With_Data(MySQLMode.SignIn, form: this).Connect_By_SignIn(login, password);
        }

        private void Pass_Toggle_Switch_CheckedChanged(object sender)
        {
            if(Pass_Toggle_Switch.Checked == true)
            {
                Password_input.UseSystemPasswordChar = false;
            }
            else
            {
                Password_input.UseSystemPasswordChar = true;
            }
        }

        private void Clip_box_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.Clear();
                Clipboard.SetText(Password_input.Text);
            }
            catch(Exception ex)
            {
                Clipboard.SetText(ex.Message);
            }            
        }

        private void Registration_label_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_Form registration = new Registration_Form();
            registration.Show();
            this.Hide();
        }

        private void Login_input_Enter(object sender, EventArgs e) => error_register.Text = string.Empty;
                            
        private void Password_input_Enter(object sender, EventArgs e) => error_register.Text = string.Empty;                                  
    }
}
