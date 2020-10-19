namespace Phasmatic.RpcValidation.Players
{
    public class DeadPlayerPlaySound : RpcValidator<DeadPlayer>
    {
        public override string Name => "PlaySound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int actorId = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
