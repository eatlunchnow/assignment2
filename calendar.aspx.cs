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
        string schoolStart = "4/3/2017";
        string petDay = "4/11/2017";
        string birthday = "5/9/2017";
        string momDay = "5/14/2017";
        string dadDay = "6/18/2017";


        if (myDate.Equals(schoolStart))
        {
            Label.Text = "Spring Quarter Starts";
        }

        else if (myDate.Equals(petDay))
        {
            Label.Text = "National Pet Day";
        }
        else if (myDate.Equals(birthday))
        {
            Label.Text = "My Birthday";

        }
        else if (myDate.Equals(momDay))
        {
            Label.Text = "Mother's Day";
        }

        else if (myDate.Equals(dadDay))
        {
            Label.Text = "Father's Day";
        }
        else
        {
            Label.Text = Calendar.SelectedDate.ToShortDateString();
        }

    }

  

}
