namespace Phasmatic.RpcValidation {

  public class GhostInteractionSpawnFootstepNetworked : RpcValidator<GhostInteraction> {

    public override string Name => "SpawnFootstepNetworked";
    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}