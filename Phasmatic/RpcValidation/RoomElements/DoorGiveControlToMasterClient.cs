namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorGiveControlToMasterClient : RpcValidator<Door>
    {
        public override string Name => "GiveControlToMasterClient";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
