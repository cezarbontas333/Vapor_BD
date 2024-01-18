using System;
using System.Collections;
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
    public partial class StorePage : Form
    {
        int user_id;
        Form login_form;
        public StorePage(int user_id, Form login_form)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.login_form = login_form;
        }

        private void StorePage_Load(object sender, EventArgs e)
        {
            string query_best = "SELECT G.Name, G.Genre, Dev.Username, ISNULL(GR.Rating, 0) AS Score " +
                "FROM Games G " +
                "JOIN Users Dev ON G.Developer_ID = Dev.User_ID " +
                "LEFT JOIN ( " +
                "SELECT Game_ID, AVG(Rating) AS Rating FROM Comments GROUP BY Game_ID ) " +
                "GR ON G.Game_ID = GR.Game_ID " +
                "ORDER BY GR.Rating DESC";
            SqlDataAdapter sda_best = new SqlDataAdapter(query_best, Login_Page.conn);
            DataTable dtable_best = new DataTable();
            sda_best.Fill(dtable_best);
            BestGamesGrid.DataSource = dtable_best;
            BestGamesGrid.Refresh();

            string query_recommended =
                "SELECT G.Game_ID, G.Name, G.Genre\r\nFROM Games G\r\nWHERE \r\n    G.Genre = (\r\n        SELECT TOP 1 G.Genre\r\n        FROM Library L\r\n        JOIN Games G ON L.Game_ID = G.Game_ID\r\n        WHERE L.User_ID = " + user_id + "\r\n        GROUP BY G.Genre\r\n        ORDER BY COUNT(G.Game_ID) DESC\r\n    ) AND\r\n    G.Game_ID NOT IN (\r\n        SELECT Game_ID\r\n        FROM Library\r\n        WHERE User_ID = " + user_id + "\r\n    );";
            SqlDataAdapter sda_rec = new SqlDataAdapter(query_recommended, Login_Page.conn);
            DataTable dtable_rec = new DataTable();
            sda_rec.Fill(dtable_rec);
            RecommendedGrid.DataSource = dtable_rec;
            RecommendedGrid.Refresh();

            string query_other =
                "SELECT G.Game_ID, G.Name, G.Genre\r\nFROM Games G\r\nWHERE \r\n    G.Genre NOT IN (\r\n        SELECT DISTINCT G.Genre\r\n        FROM Library L\r\n        JOIN Games G ON L.Game_ID = G.Game_ID\r\n        WHERE L.User_ID = " + user_id + "\r\n    ) AND\r\n    G.Game_ID NOT IN (\r\n        SELECT Game_ID\r\n        FROM Library\r\n        WHERE User_ID = " + user_id + "\r\n    );";
            SqlDataAdapter sda_other = new SqlDataAdapter(query_other, Login_Page.conn);
            DataTable dtable_other = new DataTable();
            sda_other.Fill(dtable_other);
            RandomGrid.DataSource = dtable_other;
            RandomGrid.Refresh();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuPlayer formmenu = new MenuPlayer(user_id, login_form);
            formmenu.Show();
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

        private void SubmitSearchGame_Click(object sender, EventArgs e)
        {
            string querySearch = "SELECT Game_ID, Name\r\nFROM Games\r\nWHERE Name LIKE '" + 
                SearchGameBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querySearch, Login_Page.conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if(dtable.Rows.Count > 0)
            {
                int game_id = (int)dtable.Rows[0]["Game_ID"];
                GamePage gameform = new GamePage(user_id, game_id, login_form);
                gameform.Show();
                this.Close();
            }
        }
    }
}
