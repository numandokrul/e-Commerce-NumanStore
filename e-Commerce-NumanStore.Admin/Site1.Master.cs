using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace admin2
{
    public partial class Site1 : System.Web.UI.MasterPage
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
            if ((Session["uye"] == null))
            {
                Response.Redirect("giris.aspx");
            }
            //lblIPAdd.Text = GetLocalIPAddress();
            //Session["uye"] = lblIPAdd.Text;
            uyeAdSoyad.InnerHtml = Session["uyeAdSoyad"].ToString();
            uyeResim.Src = Session["uyeResim"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("http://localhost:64664/Default.aspx");
        }

        protected void Ara_Click(object sender, EventArgs e)
        {
            Response.Redirect("urunara.aspx?q=" + AramaCubugu.Value, false);
        }
    }
}