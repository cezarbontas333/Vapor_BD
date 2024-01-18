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
    public partial class GamePage : Form
    {
        int user_id;
        int game_id;
        Form login_form;
        public GamePage(int user_id, int game_id, Form login_form)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.game_id = game_id;
            this.login_form = login_form;
        }

        private void SubmitReview_Click(object sender, EventArgs e)
        {
            int rating = RatingBox.SelectedIndex;
            string reviewText = ReviewWriteBox.Text;
            string query = $"INSERT INTO Comments(User_ID, Game_ID, Comment_Text, Rating) VALUES( " +
                user_id + "," + game_id + ", '" + reviewText + "'," + rating + ")";

        }

        private void GamePage_Load(object sender, EventArgs e)
        {
            string queryGame = "SELECT G.Name, G.Price, G.Date_of_Release, Dev.Username, ISNULL(GR.Rating, 0) AS Score " +
                "FROM Games G " +
                "JOIN Users Dev ON G.Developer_ID = Dev.User_ID " +
                "LEFT JOIN ( " +
                "SELECT Game_ID, AVG(Rating) AS Rating FROM Comments GROUP BY Game_ID ) " +
                "GR ON G.Game_ID = GR.Game_ID " +
                "WHERE G.Game_ID = " + game_id;
            SqlDataAdapter sda = new SqlDataAdapter(queryGame, Login_Page.conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            gameTitle.Text = dtable.Rows[0]["Name"].ToString();
            PublisherLabel.Text = dtable.Rows[0]["Username"].ToString();
            DateLabel.Text = dtable.Rows[0]["Date_of_Release"].ToString();
            PriceLabel.Text = dtable.Rows[0]["Price"].ToString();
            AvgRating.Text = dtable.Rows[0]["Score"].ToString();

            string queryComments = "SELECT DISTINCT U.Username, C.Rating, C.Comment_Text " +
                "FROM Users U JOIN Comments C ON U.User_ID = C.User_ID " +
                "JOIN Games G ON " + game_id + " = C.Game_ID ";
            SqlDataAdapter sdaComments = new SqlDataAdapter(queryComments, Login_Page.conn);
            DataTable dtableComments = new DataTable();
            sdaComments.Fill(dtableComments);

            ReviewsGrid.DataSource = dtableComments;
            ReviewsGrid.Refresh();
        }
    }
}
