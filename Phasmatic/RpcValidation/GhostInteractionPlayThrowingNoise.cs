namespace Phasmatic.RpcValidation {

  public class GhostInteractionPlayThrowingNoise : RpcValidator {

    public override System.Type View => typeof(GhostInteraction);

    public override string Name => "PlayThrowingNoise";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}