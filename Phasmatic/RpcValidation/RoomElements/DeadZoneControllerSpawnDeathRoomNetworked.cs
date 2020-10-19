namespace Phasmatic.RpcValidation.RoomElements
{
    public class DeadZoneControllerSpawnDeathRoomNetworked : RpcValidator<DeadZoneController>
    {
        public override string Name => "SpawnDeathRoomNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
