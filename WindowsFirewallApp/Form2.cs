using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace WindowsFirewallApp
{
    public partial class registerForm : Form
    {
        private MySqlConnection conn;
   
        public registerForm()
        {
            string connString;
            connString = $"SERVER=localhost;DATABASE=firewall;UID=root;PASSWORD='';";
            conn = new MySqlConnection(connString);
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            string username = _username_txt.Text;
            string password = _password_txt.Text;
            string confirm_password = confirm_password_txt.Text;

            if (Register(username, password, confirm_password)){
                MessageBox.Show($"User {username} adlı istifadəçi yaradıldı!");
            }else{
                MessageBox.Show($"User {username} adlı istifadəçi yaradıla bilmədi!");
            }
        }
        public bool Register(string username, string password, string confirm_password)
        {
            string query = $"INSERT INTO users(id, username,password,confirm_password) VALUES('','{username}', '{password}', '{confirm_password}');";
            try{
                if (OpenConnection()){
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    try{
                        cmd.ExecuteNonQuery();
                        return true;
                    }catch (Exception){
                        return false;
                    }
                }else{
                    conn.Close();
                    return false;
                }
            }catch (Exception){
                conn.Close();
                return false;
            }
        }

        private bool OpenConnection()
        {
            try{
                conn.Open();
                return true;
            }catch (MySqlException ex){
                switch (ex.Number){
                    case 0:
                        MessageBox.Show("Bağlantı xətası");
                        break;
                    case 1045:
                        MessageBox.Show("Bağlantı məlumatları səhvdir.");
                        break;
                }
                return false;
            }
        }

        private void _login_btn_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            Hide();
            login.Show();
        }
    }
}
