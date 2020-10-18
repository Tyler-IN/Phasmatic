using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class CrucifixNetworkedUsed : RpcValidator<Crucifix>
    {
        public override string Name => "NetworkedUsed";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
