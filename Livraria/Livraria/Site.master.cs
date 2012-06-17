using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class SiteMaster : System.Web.UI.MasterPage
{
    private fMaster MasterFacade = new fMaster();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (MasterFacade.IsCliente())
        {
            NavigationMenuCliente.Visible = true;
            NavigationMenuVendedor.Visible = false;
        }
        else if (MasterFacade.IsVendedor())
        {
            NavigationMenuCliente.Visible = false;
            NavigationMenuVendedor.Visible = true;
        }
        else
        {
            NavigationMenuCliente.Visible = false;
            NavigationMenuVendedor.Visible = false;
        }
    }
}
