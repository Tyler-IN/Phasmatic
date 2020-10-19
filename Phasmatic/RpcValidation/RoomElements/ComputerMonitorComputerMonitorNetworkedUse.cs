namespace Phasmatic.RpcValidation.RoomElements
{
    public class ComputerMonitorComputerMonitorNetworkedUse : RpcValidator<ComputerMonitor>
    {
        public override string Name => "ComputerMonitorNetworkedUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
