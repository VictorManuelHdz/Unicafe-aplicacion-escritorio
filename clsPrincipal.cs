using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteriaUTHH
{
    internal class clsPrincipal
    {
        public void AgregarAlContenedor(Form formulario, Panel panel)
        {
            panel.Controls.Clear();

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel.Controls.Add(formulario);

            panel.Tag = formulario;
            formulario.Show();
        }
        public void DeshabilitarOpciones(MenuStrip tsmMenu)
        {
            if (clsLogin.rol == "Empleado" || clsLogin.rol == "Vendedor")
            {
                var Item = tsmMenu.Items.Find("tsmEmpleados", true).FirstOrDefault();
                Item.Visible = false;
            }
        }
    }
}
