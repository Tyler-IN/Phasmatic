namespace Phasmatic.RpcValidation {

  public class GhostEventPlayerSpawnRandomPlayerModel : RpcValidator<GhostEventPlayer> {

    public override string Name => "SpawnRandomPlayerModel";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}