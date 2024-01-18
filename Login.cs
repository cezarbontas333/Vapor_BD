using System.Data;
using System.Data.SqlClient;


namespace Vapor
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }
        public static SqlConnection conn = new SqlConnection(@"Data Source=ATHENA;Initial Catalog=Vapor;Integrated Security=True");
        private void Login_Event()
        {
            string username, password;
            username = Username_Input_Box.Text;
            password = Password_Input_Box.Text;

            try
            {
                string query = "SELECT User_ID, Username, Password, Account_Type FROM Users WHERE username = '" + Username_Input_Box.Text + "' AND password = '" + Password_Input_Box.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    int user_id = (int) dtable.Rows[0]["User_ID"];
                    char account_type = dtable.Rows[0]["Account_Type"].ToString()?.ToCharArray()[0]??' ';

                    switch(account_type)
                    {
                        case 'A':
                            MenuAdmin formhomeadmin = new MenuAdmin();
                            formhomeadmin.Show();
                            this.Hide();
                            break;
                        case 'D':
                            MenuDev formhomedev = new MenuDev();
                            formhomedev.Show();
                            this.Hide();
                            break;
                        case 'P':
                            MenuPlayer formhomeplayer = new MenuPlayer(user_id, this);
                            formhomeplayer.Show();
                            this.Hide();
                            break;
                        default:
                            MessageBox.Show("Account type missing or is not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Username_Input_Box.Clear();
                            Password_Input_Box.Clear();

                            Username_Input_Box.Focus();
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username_Input_Box.Clear();
                    Password_Input_Box.Clear();

                    Username_Input_Box.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Unknown Error");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Login_Event();
        }

        private void Username_Input_Box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Input_Box_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}