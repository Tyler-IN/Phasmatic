namespace Phasmatic.RpcValidation.Players
{

    public class PlayerDead : RpcValidator<Player>
    {
        public override string Name => "Dead";

        protected override bool ValidateInternal(RpcExecution execution) => execution.Source.IsMasterClient;

    }

}