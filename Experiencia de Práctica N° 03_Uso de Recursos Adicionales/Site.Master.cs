using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConversorDeTemperaturas
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                Electrod.Items.Add(new ListItem("Lavadora", "1"));
                Electrod.Items.Add(new ListItem("Televisor", "2"));
                Electrod.Items.Add(new ListItem("Microondas", "3"));
            }
            Grafico.Visible = false;
        }
        protected void MostrarGrafico_ServerClick(Object sender, EventArgs e)
        {
            Grafico.Src = "figura" + Electrod.SelectedIndex.ToString() +".jpg";
            Grafico.Alt = "Grafico Temperatura";
            Grafico.Visible = true;
        }
        protected void Convertir_ServerClick(Object sender, EventArgs e)
        {
            ListItem elemento = Electrod.Items[Electrod.SelectedIndex];
            if (elemento.Value == "1")
            {
                Resultado.InnerText = "Codigo:		3947254 \n" + "Nombre:       WT16BSB \n" + "Descripcion:	16kg, negra \n" + "Marca:		LG \n" + "Precio:		1549 \n";
            }
            if (elemento.Value == "2")
            {
                Resultado.InnerText = "Codigo:		4037316 \n" + "Nombre:       QN50Q60AAGXPE \n" + "Descripcion:	Smart QLED 4K 50'' \n" + "Marca:		Samsung \n" + "Precio:		2449 \n";
            }
            if (elemento.Value == "3")
            {
                Resultado.InnerText = "Codigo:		2673711 \n" + "Nombre:       POGJ91101G \n" + "Descripcion:	30L \n" + "Marca:		Oster \n" + "Precio:		419 \n";
            }
        }
    }
}