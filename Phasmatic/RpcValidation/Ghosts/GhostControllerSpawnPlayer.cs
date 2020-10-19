namespace Phasmatic.RpcValidation {

  public class GhostControllerSpawnPlayer : RpcValidator {

    public override System.Type View => typeof(GhostController);

    public override string Name => "SpawnPlayer";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source?.IsMasterClient ?? true;

  }

}