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
    public partial class AdminHome : System.Web.UI.Page
    {
        public List<Artist> Artists = null;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Artists = ArtistRepository.GetArtist();
        }

    }
}