namespace Phasmatic.RpcValidation {

  public class GhostInteractionPlayDoorNoise : RpcValidator {

    public override System.Type View => typeof(GhostInteraction);

    public override string Name => "PlayDoorNoise";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}