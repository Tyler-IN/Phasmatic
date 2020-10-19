namespace Phasmatic.RpcValidation {

  public class GhostControllerNetworkedUpdatePlayerSanity : RpcValidator {

    public override System.Type View => typeof(GhostController);

    public override string Name => "NetworkedUpdatePlayerSanity";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source?.IsMasterClient ?? true;

  }

}