using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vapor
{
    public partial class MenuPlayer : Form
    {
        private int user_id;
        private Form login_form;
        public MenuPlayer(int user_id, Form login_form)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.login_form = login_form;
        }

        private void MenuPlayer_Load(object sender, EventArgs e)
        {
            try
            {
                // populate most played games
                string most_played_query =
                "SELECT G.Name, L.Hours_Played " +
                "FROM Games G INNER JOIN Library L ON G.Game_ID = L.Game_ID " +
                "WHERE L.User_ID = " + user_id +
                " ORDER BY L.Hours_Played DESC";


                SqlDataAdapter sda = new SqlDataAdapter(most_played_query, Login_Page.conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                MostPlayedGrid.DataSource = dtable;
                MostPlayedGrid.Refresh();

                // populate user greeting
                string user_info_query = "SELECT Username FROM Users WHERE User_ID = " + user_id + ";";
                SqlDataAdapter user_info_adapter = new SqlDataAdapter(user_info_query, Login_Page.conn);
                DataTable user_info_data = new DataTable();
                user_info_adapter.Fill(user_info_data);

                if (user_info_data.Rows.Count > 0)
                {
                    greetings.Text += ", " + user_info_data.Rows[0]["Username"].ToString() + '!';
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StorePage formstore = new StorePage(user_id, login_form);
            formstore.Show();
            this.Close();
        }

        private void libraryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryPlayer formlibrary = new LibraryPlayer(user_id, login_form);
            formlibrary.Show();
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.login_form.Show();
            this.Close();
        }
    }
}
