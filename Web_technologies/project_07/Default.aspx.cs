using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
interface IBite
{
    string Power();
}

interface IFly
{
    string High();
}

class AAnimal
{
    virtual internal string Say()
    {
        return "Hi";
    }
}

class ARooster : AAnimal, IFly
{
    override internal string Say()
    {
        return "Ku-ka-re-ku";
    }

    public string High()
    {
        return " 1.5 meters";
    }
}

class ACat:AAnimal, IBite
{
    override internal string Say()
    {
        return "Miau";
    }

    public string Power()
    {
        return " not strong";
    }

    public override string ToString()
    {
        return "Kitty";
    }

}
class ADog:AAnimal, IBite
{
    override internal string Say()
    {
        return "Gav";
    }
    public string Power()
    {
        return " strong";
    }
}
class ADonkey:AAnimal
{
    override internal string Say()
    {
        return "Ia";
    }
}
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        AAnimal[] a = new AAnimal[4];
        a[0] = new ACat();
        a[1] = new ADog();
        a[2] = new ADonkey();
        a[3] = new ARooster();

        string s = "";
        int j = 0;
        s = (new ACat()).ToString() + "<br>";
        for (int i = 0; i < a.Length; i++)
        {
            j = i + 1;
            if (j >= a.Length) j = 0;
            s += "<br>" + a[i].GetType() + ": " + a[j].Say();
        }
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] is IBite) 
                s += "<br>" + a[i].GetType() + " can bite" + ((IBite)a[i]).Power();
            if (a[i] is IFly)
                s += "<br>" + a[i].GetType() + " can fly" + ((IFly)a[i]).High();
        }

        Stack st = new Stack();
        st.Push(a[0]);
        st.Push(new ADog());
        st.Push(new ADonkey());

        s += "<hr>";
        s += st.Pop().GetType() + "<br>";

            Label1.Text = s;
    }
}