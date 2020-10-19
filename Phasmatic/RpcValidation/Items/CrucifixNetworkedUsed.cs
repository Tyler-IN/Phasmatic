namespace Phasmatic.RpcValidation.Items
{
    public class CrucifixNetworkedUsed : RpcValidator<Crucifix>
    {
        public override string Name => "NetworkedUsed";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
