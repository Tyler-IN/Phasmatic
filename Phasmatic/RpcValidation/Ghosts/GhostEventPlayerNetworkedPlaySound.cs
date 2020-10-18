namespace Phasmatic.RpcValidation {

  public class GhostEventPlayerNetworkedPlaySound : RpcValidator<GhostEventPlayer> {

    public override string Name => "NetworkedPlaySound";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source.IsMasterClient;

  }

}