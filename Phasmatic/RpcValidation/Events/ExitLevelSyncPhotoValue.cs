using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Events
{
    public class ExitLevelSyncPhotoValue : RpcValidator<ExitLevel>
    {
        public override string Name => "SyncPhotoValue";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int value = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
