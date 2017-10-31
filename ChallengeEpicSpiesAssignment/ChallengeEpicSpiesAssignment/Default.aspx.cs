using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //rule1
            if (!Page.IsPostBack)
            {
                Calendar1.SelectedDate = DateTime.Now.Date;
                Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
                Calendar3.SelectedDate = DateTime.Now.Date.AddDays(21);
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //rule3
            TimeSpan doa = Calendar3.SelectedDate.Subtract(Calendar2.SelectedDate);
            double tc = doa.TotalDays * 500.0;

            //rule4
            if (doa.TotalDays > 21)
            {
                tc += 1000.0;
            }
            //this isnt showing up at all
            Label1.Text = String.Format("Assignment of {0} to the assignment  {1} is authorized the amount of {2:C}", TextBox1.Text, TextBox2.Text, tc);
            
            //rule2
            TimeSpan tba = Calendar2.SelectedDate.Subtract(Calendar1.SelectedDate);
            if (tba.TotalDays < 14)
            {
                Label1.Text = "Error, must allow at least 2 weeks in between assignmetns.";             
            }
            DateTime enad = Calendar1.SelectedDate.AddDays(14);
            Calendar2.SelectedDate = enad;
            Calendar2.VisibleDate = enad;
        }
    }
}
/*
Rule1:
first calender set to today.
second calender set 14 days from today.
third calender set 21 days from today.

Rule2:
Must be 14 days, if not selected correctly a error msg will show up.
Also show earliest available date on calender by selecting and showing 
date in the second calendar.

1= if not 14 days(error msg) else(concenated code)
2= 

Rule3:
Cost $500 a day; display in label.
Rule4:
 If assignment is  over 3 weeks, and extra $1000 will be added.*/