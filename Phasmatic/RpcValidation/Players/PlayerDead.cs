namespace Phasmatic.RpcValidation.Players
{

    public class PlayerDead : RpcValidator<Player>
    {
        public override string Name => "Dead";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx) => ctx.Source?.IsMasterClient ?? true;

    }

}