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
        SqlConnection conn = new SqlConnection(@"Data Source=ATHENA;Initial Catalog=Vapor;Integrated Security=True");
        private void Login_Event()
        {
            String username, password;
            username = Username_Input_Box.Text;
            password = Password_Input_Box.Text;

            try
            {
                String querry = "SELECT Username, Password FROM Users WHERE username = '" + Username_Input_Box.Text + "' AND password = '" + Password_Input_Box.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = Username_Input_Box.Text;
                    password = Password_Input_Box.Text;

                    HomeMenu formhome = new HomeMenu();
                    formhome.Show();
                    this.Hide();
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
            finally
            {
                conn.Close();
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