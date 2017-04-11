using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calendar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar_SelectionChanged(object sender, EventArgs e)
    {
        string myDate = Calendar.SelectedDate.ToShortDateString();
        string birthday = "5/9/2017";


        if (myDate.Equals(birthday))
        {
            Label.Text = "Happy Birthday!";

        }
        else
        {
            Label.Text = Calendar.SelectedDate.ToShortDateString();
        }
     

    }

}
