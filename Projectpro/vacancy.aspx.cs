using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Projectpro
{


    public partial class WebForm1 : System.Web.UI.Page
    {
        Vacancy objbo2 = new Vacancy();
        VacancyDB objbll = new VacancyDB();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void subbutton_Click(object sender, EventArgs e)
        {
            try
            {
                
                objbo2.Name = ttname.Text;
                objbo2.Place = ttplace.Text;
                objbo2.Country = ttcountry.Text;



                int ret = objbll.AddVacancy(objbo2);
                if (ret != 0)
                {
                    ttname.Text = null;
                    ttplace.Text = null;
                    ttcountry.Text = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void viewlist_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Vacancyview.aspx");
        }
    }
}