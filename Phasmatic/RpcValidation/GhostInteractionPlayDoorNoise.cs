namespace Phasmatic.RpcValidation {

  public class GhostInteractionPlayDoorNoise : RpcValidator<GhostInteraction> {

    public override string Name => "PlayDoorNoise";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}