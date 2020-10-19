namespace Phasmatic.RpcValidation {

  public class GhostAiHunting : RpcValidator {

    public override System.Type View => typeof(GhostAI);

    public override string Name => "Hunting";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source?.IsMasterClient ?? true;

  }

}