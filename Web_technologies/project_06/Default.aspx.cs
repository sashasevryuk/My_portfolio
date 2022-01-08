using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
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
        string site = "https://www.google.com/search?hl=en&q=bsu&gl=us";
        WebRequest req = WebRequest.Create(site);
        WebResponse res = req.GetResponse();
        Stream stream = res.GetResponseStream();
        StreamReader reader = new StreamReader(stream);
        string Vedro = "", txt = "";
        while ((Vedro = (reader.ReadLine())) != null)
        {
            txt += Vedro + "\n\r\n\r";
        }
        Label1.Text = txt;
    }
}
