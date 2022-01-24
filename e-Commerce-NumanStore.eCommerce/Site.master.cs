using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

public partial class Site : System.Web.UI.MasterPage
{
    public static string GetLocalIPAddress()
    {
        var host = Dns.GetHostEntry(Dns.GetHostName());
        foreach (var ip in host.AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
            {
                return ip.ToString();
            }
        }
        throw new Exception("No network adapters with an IPv4 address in the system!");
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //Session["uye"] = "";
        Session["uye"] = GetLocalIPAddress();
        lblIPAdd.Text = Session["uye"].ToString();
        //Session["uye"] = lblIPAdd.Text;
    }


    protected void searchbutton_ServerClick(object sender, EventArgs e)
    {
        Response.Redirect("urunara.aspx?q=" + keyword.Value.ToString().Trim(), false);
    }
}
