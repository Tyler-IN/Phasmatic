namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorForceDropDoorNetworked : RpcValidator<Door>
    {
        public override string Name => "ForceDropDoorNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
