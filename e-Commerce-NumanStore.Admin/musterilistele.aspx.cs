using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin2
{
    public partial class musterilistele : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MusteriCRUD muster = new MusteriCRUD();
            DataTable gtablomus = new DataTable();

            gtablomus = muster.tumlistemm();

            listele.InnerHtml = "<table class='table table-striped' width='100 % ' cellspacing='0' border='1'><tr><td>SIRA NO</td><td>AD Soyad</td><td>Meslek</td><td>Telefon</td><td>Adres</td><td>Şehir</td><td>Mail</td></tr>";
            for (int i = 0; i < gtablomus.Rows.Count; i++)
            {
                listele.InnerHtml += $"<tr><td>{i + 1}</td><td>{gtablomus.Rows[i][0]}</td><td>{gtablomus.Rows[i][2]}</td><td>{gtablomus.Rows[i][3]}</td><td>{gtablomus.Rows[i][4]}</td><td>{gtablomus.Rows[i][5]}</td><td>{gtablomus.Rows[i][6]}</td> </tr>    ";
            }
            listele.InnerHtml += "";
            listele.InnerHtml += "</table>";
        }
    }
}