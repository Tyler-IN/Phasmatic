namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorNetworkedPlayLockSound : RpcValidator<Door>
    {
        public override string Name => "NetworkedPlayLockSound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
