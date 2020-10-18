using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class CCTVNonVRPlaceCamera : RpcValidator<CCTV>
    {

        public override string Name => "NonVRPlaceCamera";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            Vector3 point = ctx.GetArgument(0, Vector3.Zero);
            Quaternion quaternion = ctx.GetArgument<Quaternion>(1);

            return true;
        }
    }
}
