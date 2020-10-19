namespace Phasmatic.RpcValidation.RoomElements
{
    public class CCTVControllerNetworkedChangeNightVision : RpcValidator<CCTVController>
    {
        public override string Name => "NetworkedChangeNightVision";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            bool on = ctx.GetArgument<bool>(0);

            return true;
        }
    }
}
