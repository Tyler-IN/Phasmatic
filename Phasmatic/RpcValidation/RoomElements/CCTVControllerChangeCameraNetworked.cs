namespace Phasmatic.RpcValidation.RoomElements
{
    public class CCTVControllerChangeCameraNetworked : RpcValidator<CCTVController>
    {
        public override string Name => "ChangeCameraNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
