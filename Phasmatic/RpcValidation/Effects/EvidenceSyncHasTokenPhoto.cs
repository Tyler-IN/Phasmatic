namespace Phasmatic.RpcValidation.Effects
{
    public class EvidenceSyncHasTokenPhoto : RpcValidator<Evidence>
    {
        public override string Name => "SyncHasTakenPhoto";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
