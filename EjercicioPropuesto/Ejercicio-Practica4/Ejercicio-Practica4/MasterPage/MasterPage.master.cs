using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio_Practica4.MasterPage
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                ListItem refrigeradora = new ListItem("Refrigeradora", "1000");
                ListItem microondas = new ListItem("Microondas", "200");

                articulos.Items.Add(refrigeradora);
                articulos.Items.Add(microondas);

            }
        }

        protected void DropDownList1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }
    }
}