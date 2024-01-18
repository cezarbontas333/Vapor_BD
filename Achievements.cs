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
    public partial class Achievements : Form
    {
        private int user_id;
        private int game_id;

        public Achievements(int user_id, int game_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.game_id = game_id;
        }

        private void Achievements_Load(object sender, EventArgs e)
        {
            try
            {
                // game achievements
                string game_achievements_query = "SELECT A.Description, AL.Date_of_Add \"Date Earned\" " +
                    "FROM Achievements A " +
                    "JOIN AchievementLibrary AL ON A.Achievement_ID = AL.Achievement_ID " +
                    "JOIN Library L ON AL.Purchase_ID = L.Purchase_ID " +
                    "WHERE A.Game_ID = " + game_id + " AND L.User_ID = " + user_id + ";";

                SqlDataAdapter sda = new SqlDataAdapter(game_achievements_query, Login_Page.conn);
                DataTable game_achievements_data = new DataTable();
                sda.Fill(game_achievements_data);
                AchievementsView.DataSource = game_achievements_data;
                AchievementsView.Refresh();
            }
            catch
            {

            }
        }

        private void AchievementsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
