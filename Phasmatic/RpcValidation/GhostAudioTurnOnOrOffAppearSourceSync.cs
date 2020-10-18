namespace Phasmatic.RpcValidation {

  public class GhostAudioTurnOnOrOffAppearSourceSync : RpcValidator<GhostAudio> {

    public override string Name => "TurnOnOrOffAppearSourceSync";

    protected override bool ValidateInternal(RpcExecution execution)
      => execution.Source.IsMasterClient;

  }

}