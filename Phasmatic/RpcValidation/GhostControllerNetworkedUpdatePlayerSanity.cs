namespace Phasmatic.RpcValidation {

  public class GhostControllerNetworkedUpdatePlayerSanity : RpcValidator {

    public override System.Type View => typeof(GhostController);

    public override string Name => "NetworkedUpdatePlayerSanity";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}