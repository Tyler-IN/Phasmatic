namespace Phasmatic.RpcValidation {

  public class GhostInteractionPlayThrowingNoise : RpcValidator<GhostInteraction> {

    public override string Name => "PlayThrowingNoise";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}