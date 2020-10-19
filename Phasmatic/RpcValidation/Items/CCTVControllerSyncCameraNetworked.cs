namespace Phasmatic.RpcValidation.Items
{
    public class CCTVControllerSyncCameraNetworked : RpcValidator<CCTVController>
    {
        public override string Name => "SyncCameraNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            int newIndex = ctx.GetArgument<int>(0);

            return true;
        }
    }
}
