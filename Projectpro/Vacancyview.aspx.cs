using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Projectpro
{
    public partial class Vacancyview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindData();
            }
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void bindData()
        {
            VacancyDB maari = new VacancyDB();
            List<Vacancy> thoori = maari.fetchvacancy();

            GridView1.DataSource = thoori;

            GridView1.DataBind();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

            Response.ClearContent();  //clearing all content from response buffers
            Response.AppendHeader("content-disposition", "attachment;filename=Vacancies.xls"); //content disposition used to specify name to excel sheet
            Response.ContentType = "application/excel";

            StringWriter stringwriter = new StringWriter();
            HtmlTextWriter htmltextwriter = new HtmlTextWriter(stringwriter); // stringwriter passed as it inherits the Textwriter which is the super class (the content in htmltextwriter moves to stringworter object)
            GridView1.RenderControl(htmltextwriter);   //all the data and the html content in the grid view mmoves to html text writer object
            Response.Write(stringwriter.ToString());
            Response.End();
        }


            public override void VerifyRenderingInServerForm(Control control)     //since we are rendering something out of form we are override this method
        {
            
        }


    }
    }
