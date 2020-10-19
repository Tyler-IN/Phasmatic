namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorNetworkedPlayUnlockSound : RpcValidator<Door>
    {
        public override string Name => "NetworkedPlayUnlockSound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
