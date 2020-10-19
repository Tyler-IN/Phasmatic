namespace Phasmatic.RpcValidation.Items
{
    public class EVPRecorderNetworkUse : RpcValidator<EVPRecorder>
    {
        public override string Name => "NetworkUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int actorId = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
