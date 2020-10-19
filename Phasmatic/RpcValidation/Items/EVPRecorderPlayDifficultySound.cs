using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class EVPRecorderPlayDifficultySound : RpcValidator<EVPRecorder>
    {
        public override string Name => "PlayDifficultySound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int index = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
