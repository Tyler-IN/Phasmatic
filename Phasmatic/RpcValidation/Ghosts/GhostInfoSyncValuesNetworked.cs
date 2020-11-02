namespace Phasmatic.RpcValidation {

  public class GhostInfoSyncValuesNetworked : RpcValidator {

    public override System.Type View => typeof(GhostInfo);

    public override string Name => "SyncValuesNetworked";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx) {
      //if (!PhasmaticMod.GameController.allPlayersAreConnected) return false;
      if (!PhasmaticMod.GameController.दतऩटऩणणचझढत) return false;
      
      var ghost = PhasmaticMod.GhostAI;
      
      if (ghost != null) return false;
      
      return ctx.Source?.IsMasterClient ?? true;
    }

  }

}