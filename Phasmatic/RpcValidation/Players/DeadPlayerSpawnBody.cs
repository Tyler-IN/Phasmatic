namespace Phasmatic.RpcValidation.Players
{
    public class DeadPlayerSpawnBody : RpcValidator<DeadPlayer>
    {
        public override string Name => "SpawnBody";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int modelId = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
