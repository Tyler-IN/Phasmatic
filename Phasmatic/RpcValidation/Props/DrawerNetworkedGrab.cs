using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Props
{
    public class DrawerNetworkedGrab : RpcValidator<Drawer>
    {
        public override string Name => "NetworkedGrab";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
