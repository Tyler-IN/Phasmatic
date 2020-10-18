namespace Phasmatic.RpcValidation {

  public class GhostEventPlayerNetworkedPlaySound : RpcValidator {

    public override System.Type View => typeof(GhostEventPlayer);

    public override string Name => "NetworkedPlaySound";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}