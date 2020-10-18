namespace Phasmatic.RpcValidation {

  public class GhostEventPlayerNetworkedPlaySound : RpcValidator<GhostEventPlayer> {

    public override string Name => "NetworkedPlaySound";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}