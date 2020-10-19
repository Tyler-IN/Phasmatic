using System.Numerics;

namespace Phasmatic.RpcValidation.Items
{
    public class CCTVNonVRPlaceCamera : RpcValidator<CCTV>
    {

        public override string Name => "NonVRPlaceCamera";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            Vector3 point = ctx.GetArgument<Vector3>(0);
            Quaternion quaternion = ctx.GetArgument<Quaternion>(1);

            return true;
        }
    }
}
