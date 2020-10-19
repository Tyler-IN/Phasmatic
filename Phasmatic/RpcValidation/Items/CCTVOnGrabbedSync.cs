namespace Phasmatic.RpcValidation.Items
{
    public class CCTVOnGrabbedSync : RpcValidator<CCTV>
    {
        public override string Name => "OnGrabbedSync";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
