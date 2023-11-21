using KpopZtation.Handler;
using KpopZtation.Model;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View.Admin
{
    public partial class AdminHomeUpdate : System.Web.UI.Page
    {
        public Artist artists = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            ArtistRepository.GetArtistByID(Convert.ToInt32(id));
            lblArtistID.Text = id;
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            UploadImage.SaveAs(Server.MapPath("~/Asset/" + UploadImage.FileName));
            string name = txtArtistName.Text;
            string image = UploadImage.FileName;
            string id = Request.QueryString["id"];
            if(TypeHandler.InsertArtist(Convert.ToInt32(id), name, image))
            {
                Response.Redirect("AdminHome.aspx");
            }


            
        }
    }
}