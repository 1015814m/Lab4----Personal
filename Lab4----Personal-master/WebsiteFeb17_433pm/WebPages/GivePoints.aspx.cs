﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using database;
using System.Data.SqlClient;

public partial class GivePoints : System.Web.UI.Page
{
    public static int valueIndex;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["employeeLoggedIn"] == null)
        {
            Response.Redirect("Login.aspx"); //check that the filepath is correct
        }
        if (Session["employeeLoggedIn"].ToString() != "True")
        {
            Response.Redirect("Login.aspx"); //check that the filepath works
        }
    }

    protected void SubmitGivePointsBtn_Click(object sender, EventArgs e)
    {

        //GivePoints newForm = new GivePoints(txtName.Value, DateTime.Parse(txtDate.Value), txtDescription.Value, int.Parse(PointsGivenddl.SelectedValue),    );


    }
    //private void CollectInformation()
    //{
    //    SqlConnection conn = ProjectDB.connectToDB();
    //    string commandText = "INSERT into [dbo].[Achievement] (Name, Description, PointsAmount, LastUpdatedBy, LastUpdated, EmployeeID, ValueID, Date) " +
    //        "values (@Name, @Description, @PointsAmount, @LastUpdatedBy, @LastUpdated, @EmployeeID, @ValueID, @Date)";
    //    System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand(commandText, conn);
    //    insert.Parameters.AddWithValue("@Name",  )

    //}
}