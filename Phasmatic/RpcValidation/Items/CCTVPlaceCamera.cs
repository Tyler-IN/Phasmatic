using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class CCTVPlaceCamera : RpcValidator<CCTV>
    {
        public override string Name => "PlaceCamera";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int id = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
