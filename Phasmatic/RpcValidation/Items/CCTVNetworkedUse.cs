namespace Phasmatic.RpcValidation.Items
{
    public class CCTVNetworkedUse : RpcValidator<CCTV>
    {

        public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
