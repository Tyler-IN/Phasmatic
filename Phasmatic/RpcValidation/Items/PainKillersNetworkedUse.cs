namespace Phasmatic.RpcValidation {

  public class PainKillersNetworkedUse : RpcValidator<PainKillers> {

    public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            var actorId = ctx.GetArgument<PhotonPlayer>(0); // ?
            return ctx.Source?.Equals(actorId) ?? false;
        }
  }
}