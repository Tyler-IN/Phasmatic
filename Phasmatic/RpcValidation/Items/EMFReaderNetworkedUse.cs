using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class EMFReaderNetworkedUse : RpcValidator<EMFReader>
    {
        public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            int actorId = execution.GetArgument<int>(0);

            return true;
        }
    }
}
