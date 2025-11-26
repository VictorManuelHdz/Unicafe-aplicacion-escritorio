using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteriaUTHH
{
    internal class clsColoresMenu : ProfessionalColorTable
    {
        public override Color MenuItemSelected => Color.FromArgb(42, 157, 143);
        public override Color MenuItemSelectedGradientBegin => Color.FromArgb(42, 157, 143);
        public override Color MenuItemSelectedGradientEnd => Color.FromArgb(42, 157, 143);
        public override Color MenuItemBorder => Color.Black;

        // tsmVentas.BackColor = Color.FromArgb(42, 157, 143);

    }
}
