namespace Phasmatic.RpcValidation {

  public class GhostControllerNetworkedUpdatePlayerSanity : RpcValidator {

    public override System.Type View => typeof(GhostController);

    public override string Name => "NetworkedUpdatePlayerSanity";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}