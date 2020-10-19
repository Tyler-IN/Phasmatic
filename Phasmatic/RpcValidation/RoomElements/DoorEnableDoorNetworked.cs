namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorEnableDoorNetworked : RpcValidator<Door>
    {
        public override string Name => "EnableDoorNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
