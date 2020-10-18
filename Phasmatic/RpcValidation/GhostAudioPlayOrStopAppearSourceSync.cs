namespace Phasmatic.RpcValidation {

  public class GhostAudioPlayOrStopAppearSourceSync : RpcValidator<GhostAudio> {

    public override string Name => "PlayOrStopAppearSourceSync";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}