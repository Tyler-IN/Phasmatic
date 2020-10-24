namespace Phasmatic.RpcValidation {

  public class GhostInfoSyncValuesNetworked : RpcValidator {

    public override System.Type View => typeof(GhostInfo);

    public override string Name => "SyncValuesNetworked";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx) {
      if (!GameController.instance.allPlayersAreConnected) return false;
      
      var ghost = LevelController.instance.currentGhost;
      
      if (ghost != null) return false;
      
      return ctx.Source?.IsMasterClient ?? true;
    }

  }

}