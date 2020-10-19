namespace Phasmatic.RpcValidation.Effects
{
    public class AudioRpcPolo : RpcValidator<AudioRpc>
    {
        public override string Name => "Polo";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
