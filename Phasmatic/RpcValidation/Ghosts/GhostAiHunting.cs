namespace Phasmatic.RpcValidation {

  public class GhostAiHunting : RpcValidator {

    public override System.Type View => typeof(GhostAI);

    public override string Name => "Hunting";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}