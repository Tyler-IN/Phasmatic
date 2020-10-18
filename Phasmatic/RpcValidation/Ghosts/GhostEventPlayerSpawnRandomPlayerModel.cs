namespace Phasmatic.RpcValidation {

  public class GhostEventPlayerSpawnRandomPlayerModel : RpcValidator<GhostEventPlayer> {

    public override string Name => "SpawnRandomPlayerModel";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source.IsMasterClient;

  }

}