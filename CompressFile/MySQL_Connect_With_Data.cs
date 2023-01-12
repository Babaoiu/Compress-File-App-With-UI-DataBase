using MySql.Data.MySqlClient;
using System.Data;
using System.Media;

namespace CompressFile
{
    public enum MySQLMode
    {
        LogIn,
        SignIn
    }
    public class MySQL_Connect_With_Data
    {
        private Form form;
        private MySQLMode mode;
        private readonly string MySQL_InsertOrSelect;

        public MySQL_Connect_With_Data(MySQLMode mode, Form form)
        {
            this.form = form;
            this.mode = mode;
            if (mode == MySQLMode.SignIn)
            {
                MySQL_InsertOrSelect = "SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP";
            }
            else if (mode == MySQLMode.LogIn)
            {
                MySQL_InsertOrSelect = "INSERT INTO `users` (`login`, `pass`) VALUES(@uL, @uP)";
            }
        }
        public void Connect_By_LogIn(string login, string password)
        {
            if (mode == MySQLMode.LogIn)
            {
                DATA_BASE DataBase = new DATA_BASE();
                MySqlCommand command = new MySqlCommand(MySQL_InsertOrSelect, DataBase.GetConnection());
                if (!string.IsNullOrEmpty(login.Trim()))
                {
                    command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                }                
                command.Parameters.Add("@uP", MySqlDbType.Int32).Value = password;

                try
                {
                    DataBase.OpenConnection();

                    try
                    {
                        if (command.ExecuteNonQuery() == 1)
                        {
                            BackToSignIn();
                            MessageBox.Show("Account is created", "Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                    catch (Exception ex)
                    {
                        DialogResult result = MessageBox.Show("Invalid login or password", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            MessageBox.Show("Maybe You input symbols instead numbers in password", "Info", MessageBoxButtons.OK);
                        }
                    }

                    DataBase.CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Unfortunately host has no connection at this moment...\n{ex.Message}", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (mode == MySQLMode.SignIn)
            {
                throw new Exception("MySQLMode is invalid");
            }
        }

        public void Connect_By_SignIn(string login, string password)
        {
            if (mode == MySQLMode.SignIn)
            {
                try
                {
                    DATA_BASE data_base = new DATA_BASE();

                    DataTable table = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand sqlCommand = new MySqlCommand(MySQL_InsertOrSelect, data_base.GetConnection());

                    sqlCommand.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
                    sqlCommand.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

                    adapter.SelectCommand = sqlCommand;
                    adapter.Fill(table);
                    if (table.Rows.Count > 0)
                    {
                        Sound_Confirm_Play();
                        BackToSignIn(false);
                    }
                    else
                    {
                        //Error Login or Password
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Unfortunately host has no connection at this moment...", "Invalid data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else if (mode == MySQLMode.LogIn)
            {
                throw new Exception("MySQLMode is invalid");
            }
        }

        private void BackToSignIn(bool WhichForm = true)
        {
            if (WhichForm)
            {
                Authorisation_Form authorisation = new Authorisation_Form();
                authorisation.Show();
                form.Hide();
            }
            else if (WhichForm == false)
            {
                Bababoiu bababoiu = new Bababoiu();
                bababoiu.Show();
                form.Hide();
            }
        }

        private void Sound_Confirm_Play()
        {
            using (SoundPlayer SoundOfConfirm = new SoundPlayer(Properties.Resources.sound_wav))
            {
                SoundOfConfirm.Load();
                SoundOfConfirm.Play();
            }
        }
        
    }
}
