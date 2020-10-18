namespace Phasmatic.RpcValidation {

  public class GhostControllerSpawnPlayer : RpcValidator {

    public override System.Type View => typeof(GhostController);

    public override string Name => "SpawnPlayer";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}