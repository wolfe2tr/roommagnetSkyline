﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListPropertyForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
    }

    protected void btnListPropert_Click(object sender, EventArgs e)
    {
        Property newProperty = new Property(HttpUtility.HtmlEncode(txtHouseNum.Text), HttpUtility.HtmlEncode(txtStreet.Text), HttpUtility.HtmlEncode(txtCity.Text), ddState.SelectedValue, HttpUtility.HtmlEncode(txtZip.Text), HttpUtility.HtmlEncode(txtCountry.Text));

        if (cbGuest.Checked == true)
            txtOtherRules.Text = "it works";

        System.Data.SqlClient.SqlConnection sc = new System.Data.SqlClient.SqlConnection();
        sc.ConnectionString = "server=aa1evano00xv2xb.cqpnea2xsqc1.us-east-1.rds.amazonaws.com;database=roommagnetdb;uid=admin;password=Skylinejmu2019;";
        System.Data.SqlClient.SqlCommand insert = new System.Data.SqlClient.SqlCommand();
        insert.Connection = sc;
        sc.Open();

        insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@houseNum", newProperty.getHouseNumber()));
        insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@street", newProperty.getStreet()));
        insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@city", newProperty.getCity()));
        insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@homeState", newProperty.getHomeState()));
        insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@zip", newProperty.getZip()));
        insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@country", newProperty.getCountry()));
        insert.Parameters.Add(new System.Data.SqlClient.SqlParameter("@date", newProperty.getModDate()));

        insert.CommandText = "INSERT INTO PROPERTY VALUES(@houseNum, @street, @city, @homeState, @zip, @country, 0, 0, 0, 0, @date, 7)";

        string check = insert.CommandText;
        Console.Write(check);
        insert.ExecuteNonQuery();

        sc.Close();

        txtHouseNum.Text = "";
        txtStreet.Text = "";
        txtCity.Text = "";
        ddState.ClearSelection();
        txtZip.Text = "";
        txtCountry.Text = "";

        cbApartment.Checked = true;
    }
}