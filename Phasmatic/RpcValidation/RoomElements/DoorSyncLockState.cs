namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorSyncLockState : RpcValidator<Door>
    {
        public override string Name => "SyncLockState";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            bool isLocked = ctx.GetArgument<bool>(0);

            return true;
        }
    }
}
