namespace Phasmatic.RpcValidation.RoomElements
{
    public class DoorUnlockDoorTimer : RpcValidator<Door>
    {
        public override string Name => "UnlockDoorTimer";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            float timer = ctx.GetArgument<float>(0);

            return true;
        }
    }
}
