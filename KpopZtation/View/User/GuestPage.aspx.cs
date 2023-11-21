using KpopZtation.Controller;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnToggle_Click(object sender, EventArgs e)
        {
            string firstText = "View Registration Form";
            string secondText = "Back";

            if (btnToggle.Text == firstText)
            {
                hiddenContent1.Style["display"] = "block";
                hiddenContent3.Style["display"] = "block";
                hiddenContent2.Style["display"] = "none";
                btnToggle.Text = secondText;
            }
            else if (btnToggle.Text == secondText)
            {
                hiddenContent1.Style["display"] = "none";
                hiddenContent3.Style["display"] = "none";
                hiddenContent2.Style["display"] = "block";
                btnToggle.Text = firstText;
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            Customer insertedCust = CustomerRepository.GetUser(email, password);

            if (!(CustomerController.loginController(email, password)))
            {
                lblStatus.Text = "Please fill all the field!";
            }
            else
            {
                if(insertedCust != null)
                {
                    if (insertedCust.CustomerRole.Equals("Admin"))
                    {
                        Response.Redirect("~/View/Admin/AdminHome.aspx");
                    }
                    else
                    {
                        Response.Redirect("CustomerPage.aspx?email=" + Server.UrlEncode(email));
                    }
                }
                else
                {
                    lblStatus.Text = "Invalid email or password";
                }
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string gender = ddlGender.SelectedValue;
            string address = txtAddress.Text;
            string password = txtPassword.Text;

            if (!(CustomerController.registerController(username, password, email, gender, address)))
            {
                lblStatus.Text = "Please fill all Registration Form fields!";
            }
            else
            {
                lblStatus.Style["color"] = "green";
                lblStatus.Text = "New user have been created! Welcome " + username;
            }
        }
    }
}