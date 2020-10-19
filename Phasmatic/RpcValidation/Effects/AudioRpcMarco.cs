namespace Phasmatic.RpcValidation.Effects
{
    public class AudioRpcMarco : RpcValidator<AudioRpc>
    {
        public override string Name => "Marco";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
