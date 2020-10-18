namespace Phasmatic.RpcValidation {

  public class GhostAudioTurnOnOrOffAppearSourceSync : RpcValidator {

    public override System.Type View => typeof(GhostAudio);

    public override string Name => "TurnOnOrOffAppearSourceSync";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}