using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class EVPRecorderPlayLocationSound : RpcValidator<EVPRecorder>
    {
        public override string Name => "PlayLocationSound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int index = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
