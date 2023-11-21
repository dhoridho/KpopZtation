using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace KpopZtation.View.User
{
    public partial class CustomerPage : Page
    {
        private static string currEmail;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string email = Server.UrlDecode(Request.QueryString["email"]);
                currEmail = email;

                Customer user = CustomerRepository.GetUserByEmail(email);
                List<Customer> custList = new List<Customer> { user };

                BindCustomerData(custList);
                BindArtistData();
                BindAlbumData();
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("GuestPage.aspx");
        }

        protected void btnViewUpdate_Click(object sender, EventArgs e)
        {
            string firstText = "View Update Profile Form";
            string secondText = "Back";

            if (btnViewUpdate.Text == firstText)
            {
                hiddenContent2.Style["display"] = "block";
                btnViewUpdate.Text = secondText;
            }
            else if (btnViewUpdate.Text == secondText)
            {
                hiddenContent2.Style["display"] = "none";
                btnViewUpdate.Text = firstText;
            }
        }

        protected void btnView_Click(object sender, EventArgs e)
        {
            string firstText = "Display Profile Detail";
            string secondText = "Back";

            if (btnView.Text == firstText)
            {
                hiddenContent1.Style["display"] = "block";
                btnView.Text = secondText;
            }
            else if (btnView.Text == secondText)
            {
                hiddenContent1.Style["display"] = "none";
                btnView.Text = firstText;
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(txtID.Text);
            string Name = txtName.Text;
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            string Gender = ddlGender.SelectedValue;
            string Address = txtAddress.Text;

            Customer existingCustomer = CustomerRepository.GetUserByEmail(Email);
            if (existingCustomer != null && existingCustomer.CustomerID != ID)
            {
                lblEmailStatus.Text = "Email is already in use by another customer.";
            }
            else
            {
                CustomerRepository.UpdateCustomer(ID, Name, Email, Password, Gender, Address);

                Customer user = CustomerRepository.GetUserByEmail(currEmail);
                List<Customer> custList = new List<Customer> { user };
                BindCustomerData(custList);
            }
        }

        //protected void btnAddToCart_Click(object sender, EventArgs e)
        //{
        //    int selectedArtistId = int.Parse(GridViewArtist.SelectedDataKey.Value.ToString());
        //    int selectedAlbumId = int.Parse(GridViewAlbum.SelectedDataKey.Value.ToString());

        //    // Add the selected item to the cart
        //    CartRepository.AddToCart(selectedArtistId, selectedAlbumId);

        //    // You can redirect to the cart page or show a success message
        //}

        private void BindCustomerData(List<Customer> customers)
        {
            GridView1.DataSource = customers;
            GridView1.DataBind();

            if (customers.Count > 0)
            {
                Customer user = customers[0];
                lblAfterLogin.Text = user.CustomerName;
                txtID.Text = user.CustomerID.ToString();
                txtName.Text = user.CustomerName;
                txtEmail.Text = user.CustomerEmail;
                txtPassword.Text = user.CustomerPassword;
                txtAddress.Text = user.CustomerAddress;

                txtID.ReadOnly = true;
            }
            else
            {
                // Seharusnya data customer yang login langsung ada..
            }
        }

        private void BindArtistData()
        {
            List<Artist> artists = ArtistRepository.GetAllArtist();
            GridViewArtist.DataSource = artists;
            GridViewArtist.DataBind();
        }

        private void BindAlbumData()
        {
            List<Album> albums = AlbumRepository.GetAllAlbums();
            GridViewAlbum.DataSource = albums;
            GridViewAlbum.DataBind();
        }
    }
}
