using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Effects
{
    public class AudioRpcPolo : RpcValidator<AudioRpc>
    {
        public override string Name => "Polo";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            return true;
        }
    }
}
