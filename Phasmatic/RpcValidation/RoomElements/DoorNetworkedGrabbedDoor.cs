namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorNetworkedGrabbedDoor : RpcValidator<Door>
    {
        public override string Name => "NetworkedGrabbedDoor";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
