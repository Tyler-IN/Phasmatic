namespace Phasmatic.RpcValidation {

  public class GhostAudioPlayOrStopAppearSourceSync : RpcValidator {

    public override System.Type View => typeof(GhostAudio);

    public override string Name => "PlayOrStopAppearSourceSync";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}