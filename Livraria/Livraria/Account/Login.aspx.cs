﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Account_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void LoginUser_LoggedIn(object sender, EventArgs e)
    {
        Response.Redirect(@"~/Pessoa/CadastrarPessoa.aspx");
    }
}