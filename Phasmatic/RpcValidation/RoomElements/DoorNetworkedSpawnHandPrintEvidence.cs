namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorNetworkedSpawnHandPrintEvidence : RpcValidator<Door>
    {
        public override string Name => "NetworkedSpawnHandPrintEvidence";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
