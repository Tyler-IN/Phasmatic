namespace Phasmatic.RpcValidation {

  public class GhostAiMakeGhostAppear : RpcValidator {

    public override System.Type View => typeof(GhostAI);

    public override string Name => "MakeGhostAppear";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx) {
      var ghost = LevelController.instance.currentGhost;
      
      if (ghost == null) return false;
      
      return ctx.Source?.IsMasterClient ?? true;
    }

  }

}