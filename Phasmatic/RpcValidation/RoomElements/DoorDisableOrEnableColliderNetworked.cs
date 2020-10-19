namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorDisableOrEnableColliderNetworked : RpcValidator<Door>
    {
        public override string Name => "DisableOrEnableColliderNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            bool active = ctx.GetArgument<bool>(0);

            return true;
        }
    }
}
