using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        float m = float.Parse(TextBox1.Text);
        float A = m * 1.35f * 0.6f;
        float min = m * 0.10f * 0.6f;
        float sr = m * 0.15f * 0.6f;
        float max = m * 0.20f * 0.6f;
        Label1.Text = "<br>" + "Cognak - " + "<font color=red>"
            + Math.Round(A / 0.4f) + "gr. " + "</font>"
            + Math.Round(min / 0.4f) + "gr./h. " 
            + "<font color=blue>" + Math.Round(sr / 0.4f)
            + "gr./h. " + "</font>" + "<font color=green>"
            + Math.Round(max / 0.4f) + "gr./h. " + "</font>"
            + "<br>" + "Portwine - " + "<font color=red>"
            + Math.Round(A / 0.19f) + "gr. " + "</font>" 
            + Math.Round(min / 0.19f) + "gr./h. "
            + "<font color=blue>" + Math.Round(sr / 0.19F)
            + "gr./h. " + "</font>" + "<font color=green>"
            + Math.Round(max / 0.19f) + "gr./h. " + "</font>"
            + "<br>" + "Dry wine - " + "<font color=red>"
            + Math.Round(A / 0.12f) + "gr. " + "</font>"
            + Math.Round(min / 0.12f) + "gr./h. "
            + "<font color=blue>" + Math.Round(sr / 0.12f)
            + "gr./h. " + "</font>" + "<font color=green>" + Math.Round(max / 0.12f)
            + "gr./h. " + "</font>"
            + "<br>" + "Beer - " + "<font color=red>"
            + Math.Round(A / 0.06f) + "gr. " + "</font>"
            + Math.Round(min / 0.06f) + "gr./h. " + "<font color=blue>"
            + Math.Round(sr / 0.06f) + "gr./h. " + "</font>" + "<font color=green>"
            + Math.Round(max / 0.06f) + "gr./h. " + "</font>";
    }
}
