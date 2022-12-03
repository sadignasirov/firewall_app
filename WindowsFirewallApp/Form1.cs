using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFirewallApp
{

    public partial class LoginForm : Form
    {
        private MySqlConnection conn;

        public void connectionToMySQL()
        {
            string connString;
            connString = $"SERVER=localhost;DATABASE=firewall;UID=root;PASSWORD='';";
            conn = new MySqlConnection(connString);
        }

        public LoginForm()
        {
            connectionToMySQL();
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user = username_txt.Text;
            string pass = password_txt.Text;
            if (isLogin(user, pass)){
                MainForm main = new MainForm();
                Hide(); 
                main.Show();
            }else{
                MessageBox.Show($"{user} daxil olarkən xəta baş verdi!");
            }
        }
        public bool isLogin(string user, string pass)
        {
            string query = $"SELECT * FROM users WHERE username='{user}' AND password='{pass}';";
            try{
                if (OpenConnection()){
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read()){
                        reader.Close();
                        conn.Close();
                        return true;
                    }else{
                        reader.Close();
                        conn.Close();
                        return false;
                    }
                }
            }
            catch (Exception){
                conn.Close();
                return false;
            }
            return true;
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

        private void _register_btn_Click(object sender, EventArgs e)
        {
            registerForm register = new registerForm();
            Hide();
            register.Show();
        }
    }
}
