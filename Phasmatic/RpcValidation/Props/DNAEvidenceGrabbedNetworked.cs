using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Props
{
    public class DNAEvidenceGrabbedNetworked : RpcValidator<DNAEvidence>
    {
        public override string Name => "GrabbedNetworked";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
