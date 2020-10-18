namespace Phasmatic.RpcValidation {

  public class GhostInteractionSpawnEMFNetworked : RpcValidator<GhostInteraction> {

    public override string Name => "SpawnEMFNetworked";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}