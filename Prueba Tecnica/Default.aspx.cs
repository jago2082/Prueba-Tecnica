using Npgsql;
using Prueba_Tecnica.Consultas;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prueba_Tecnica
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            Conexion conexion = new Conexion();

            var result = conexion.FindUser(txtCriterio.Text.Trim());
            if (result == null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('No se encontraron registro')", true);
            }
            else {

                while (result.Read())
                {
                    txtTipodoc.Text = result["nombre"].ToString();
                    txtNumDoc.Text = result["numerodocumento"].ToString();
                }
            }
        }
    }
}