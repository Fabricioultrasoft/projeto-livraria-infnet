using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;

public partial class Endereco_Endereco : System.Web.UI.Page
{

    protected void Button1_Click(object sender, EventArgs e)
    {
        Endereco endereco = new Endereco();

        endereco.Bairro=TbBairro.Text;
        endereco.Cidade=TbBairro.Text;
        endereco.Complemento=TbComplemento.Text;
        endereco.Logradouro = TbLogradouro.Text;
        endereco.UF = TbUf.Text;
    
    }
}