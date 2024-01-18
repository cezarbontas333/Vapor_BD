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
    public partial class LibraryPlayer : Form
    {
        private int user_id;
        private DataTable game_library_data = new DataTable();
        Form login_form;

        public LibraryPlayer(int user_id, Form login_form)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.login_form = login_form;
        }

        private void LibraryPlayer_Load(object sender, EventArgs e)
        {
            try
            {
                // populate most played games
                string game_library_query = "SELECT G.Game_ID, G.Name, G.Genre FROM Games G JOIN Library L ON G.Game_ID = L.Game_ID WHERE L.User_ID = " + user_id;

                SqlDataAdapter sda = new SqlDataAdapter(game_library_query, Login_Page.conn);
                sda.Fill(this.game_library_data);
                LibraryView.DataSource = this.game_library_data;
                LibraryView.Refresh();
            }
            catch
            {

            }
        }
        private void LibraryView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ShowAchievements_Click(object sender, EventArgs e)
        {
            if (LibraryView.CurrentCell != null)
            {
                int selected = LibraryView.CurrentCell.RowIndex;
                if (selected < this.game_library_data.Rows.Count)
                {
                    Achievements formAchievements = new Achievements(user_id, (int)this.game_library_data.Rows[selected]["Game_ID"]);
                    formAchievements.Show();
                }
            }
        }
    }
}
