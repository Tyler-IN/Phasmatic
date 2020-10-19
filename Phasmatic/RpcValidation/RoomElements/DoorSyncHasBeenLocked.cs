namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorSyncHasBeenLocked : RpcValidator<Door>
    {
        public override string Name => "SyncHasBeenLocked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
