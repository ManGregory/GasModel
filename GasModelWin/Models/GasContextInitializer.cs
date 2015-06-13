using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasModelWin.Models
{
    class GasContextInitializer : DropCreateDatabaseAlways<GasContext>
    {
        protected override void Seed(GasContext context)
        {
            base.Seed(context);
        }
    }
}
