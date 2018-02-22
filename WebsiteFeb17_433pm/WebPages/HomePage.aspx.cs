using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using database;
using System.Data.SqlClient;

public partial class HomePage : System.Web.UI.Page
{
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["employeeLoggedIn"] == null)
        {
            Response.Redirect("Login.aspx"); 
        }
        if (Session["employeeLoggedIn"].ToString() != "True")
        {
            Response.Redirect("Login.aspx"); 
        }
        

        Employee user = (Employee)Session["user"];

        if (user.Admin == true)
        {
            Response.Redirect("Admin.aspx");
        }

        welcomeMessage.Text = "Welcome " + user.FirstName + " " + user.LastName + " You currently have " + Decimal.Round(user.Points, 2) + " points!";
        form1.Controls.Add(new LiteralControl("<br />"));

        Image[] imgArray = new Image[100];
        TextBox[] txtArray = new TextBox[100];
        Button[] btnArray = new Button[100];
        Label[] lblArray = new Label[100];

        int displayNum = 100;

        

        for (int i = 0; i < displayNum; i++)
        {
            imgArray[i] = new Image();
            imgArray[i].Height = 50;
            imgArray[i].Width = 50;
            imgArray[i].BorderStyle = BorderStyle.Solid;

            txtArray[i] = new TextBox();
            txtArray[i].Height = 100;
            txtArray[i].Width = 200;
            txtArray[i].TextMode = TextBoxMode.MultiLine;
            txtArray[i].CssClass = "w3-light-grey";

            btnArray[i] = new Button();
            btnArray[i].Text = "Like :)";

            lblArray[i] = new Label();
            lblArray[i].Text = " Likes!";
        }

        

        for (int a = 0; a < 100; a++)
        {
            form1.Controls.Add(imgArray[a]);
            form1.Controls.Add(txtArray[a]);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(btnArray[a]);
            form1.Controls.Add(lblArray[a]);
            form1.Controls.Add(new LiteralControl("<br />"));
            form1.Controls.Add(new LiteralControl("<br />"));
            //LoginView1.Controls.Add()
        }
    }

    protected void likeClick(object sender, EventArgs e, Control cntrl)
    {

    }

    protected void postInformation()
    {
        try
        {
            string[,] postArray = new string[20, 5];
            string commandText = "SELECT TOP (20) * FROM [dbo].[FeedInformation] ORDER BY PostID DESC";
            SqlConnection conn = ProjectDB.connectToDB();
            SqlCommand select = new SqlCommand(commandText, conn);

            SqlDataReader reader = select.ExecuteReader();

            while (reader.HasRows)
            {
                reader.Read();
                postArray[0, 0] = reader["PostID"].ToString();
                postArray[0, 1] = reader["PostTime"].ToString();
                postArray[0, 2] = reader["NumOfLikes"].ToString();
                if (reader["AchievementID"] != null)
                {
                    postArray[0, 3] = reader["AchievementID"].ToString();
                }
                else
                {
                    postArray[0, 3] = "null";
                }
                if (reader["TransactionID"] != null)
                {
                    postArray[0, 4] = reader["TransactionID"].ToString();
                }
                else
                {
                    postArray[0, 4] = "null";
                }

            }

        }
        catch (Exception ex)
        {

        }
    }

