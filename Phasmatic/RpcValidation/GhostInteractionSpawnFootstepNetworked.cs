namespace Phasmatic.RpcValidation {

  public class GhostInteractionSpawnFootstepNetworked : RpcValidator {

    public override System.Type View => typeof(GhostInteraction);

    public override string Name => "SpawnFootstepNetworked";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}