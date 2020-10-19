namespace Phasmatic.RpcValidation.RoomElements
{
    public class DeadZoneControllerDespawnDeathRoomNetworked : RpcValidator<DeadZoneController>
    {
        public override string Name => "DespawnDeathRoomNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
