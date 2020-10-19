namespace Phasmatic.RpcValidation.Interactables
{
    public class CarTurnAlarmOn : RpcValidator<Car>
    {
        public override string Name => "TurnAlarmOn";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
