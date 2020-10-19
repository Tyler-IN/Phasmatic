namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorNetworkedPlayClosedSound : RpcValidator<Door>
    {
        public override string Name => "NetworkedPlayClosedSound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
