using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StaffAspWeb
{
    public partial class About : Page
    {
        StaffAspWeb.Context.MyContext MyContext;
        protected void Page_Load(object sender, EventArgs e)
        {
            MyContext = new Context.MyContext();
        }

        protected void btn_Save_Click(object sender, EventArgs e)
        {
            string namefam = txt_NameFam.Text;
            int code_org = int.Parse(txt_Code.Text);
            float salary = Single.Parse(txt_Salary.Text);

            StaffAspWeb.Models.Staffclass staff = new Models.Staffclass()
            {
                Name = namefam,
                Organismic_code = code_org,
                Salary = salary
            };
            MyContext.staff.Add(staff);
            MyContext.SaveChanges();
            txt_NameFam.Text = "";
            txt_Code.Text = "";
            txt_Salary.Text = "";


        }
    }
}