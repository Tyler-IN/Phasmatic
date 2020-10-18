namespace Phasmatic.RpcValidation {

  public class GhostEventPlayerSpawnRandomPlayerModel : RpcValidator {

    public override System.Type View => typeof(GhostEventPlayer);

    public override string Name => "SpawnRandomPlayerModel";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}