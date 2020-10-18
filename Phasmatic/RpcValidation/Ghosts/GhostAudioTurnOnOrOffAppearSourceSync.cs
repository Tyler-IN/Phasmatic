namespace Phasmatic.RpcValidation {

  public class GhostAudioTurnOnOrOffAppearSourceSync : RpcValidator<GhostAudio> {

    public override string Name => "TurnOnOrOffAppearSourceSync";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source.IsMasterClient;

  }

}