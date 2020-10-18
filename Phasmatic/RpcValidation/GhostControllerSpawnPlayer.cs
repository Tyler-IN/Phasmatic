namespace Phasmatic.RpcValidation {

  public class GhostControllerSpawnPlayer : RpcValidator {

    public override System.Type View => typeof(GhostController);

    public override string Name => "SpawnPlayer";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}