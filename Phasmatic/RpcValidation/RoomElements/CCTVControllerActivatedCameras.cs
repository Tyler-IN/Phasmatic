namespace Phasmatic.RpcValidation.RoomElements
{
    public class CCTVControllerActivatedCameras : RpcValidator<CCTVController>
    {
        public override string Name => "ActivatedCameras";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
