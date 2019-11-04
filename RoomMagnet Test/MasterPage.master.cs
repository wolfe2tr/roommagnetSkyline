﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
        sc.ConnectionString = "server=aa1evano00xv2xb.cqpnea2xsqc1.us-east-1.rds.amazonaws.com;database=roommagnetdb;uid=admin;password=Skylinejmu2019;";
        sc.Open();

        System.Data.SqlClient.SqlCommand findPass = new System.Data.SqlClient.SqlCommand();
        findPass.Connection = sc;
        // SELECT PASSWORD STRING WHERE THE ENTERED USERNAME MATCHES
        findPass.CommandText = "SELECT PasswordHash from Password where Email = @email";
        findPass.Parameters.Add(new SqlParameter("@email", HttpUtility.HtmlEncode(txtEmail.Text)));

        SqlDataReader reader = findPass.ExecuteReader(); // create a reader

        if (reader.HasRows) // if the email exists, it will continue
        {
            while (reader.Read()) // this will read the single record that matches the entered email
            {
                string storedHash = reader["PasswordHash"].ToString(); // store the database password into this variable

                if (PasswordHash.ValidatePassword(HttpUtility.HtmlEncode(txtPassword.Text), storedHash)) // if the entered password matches what is stored, it will show success
                {
                    lblStatus.Text = "Success!";
                    btnLogin.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPassword.Enabled = false;
                }
                else
                    lblStatus.Text = "Password is wrong.";
            }
        }
        else // if the email doesn't exist, it will show failure
            lblStatus.Text = "Email does not exist.";

        sc.Close();
    }
}
