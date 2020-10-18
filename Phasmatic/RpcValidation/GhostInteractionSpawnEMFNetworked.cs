namespace Phasmatic.RpcValidation {

  public class GhostInteractionSpawnEMFNetworked : RpcValidator {

    public override System.Type View => typeof(GhostInteraction);

    public override string Name => "SpawnEMFNetworked";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}