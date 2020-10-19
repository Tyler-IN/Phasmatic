namespace Phasmatic.RpcValidation.Effects
{
    public class AnimationObjectNetworkedUse : RpcValidator<AnimationObject>
    {
        public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
