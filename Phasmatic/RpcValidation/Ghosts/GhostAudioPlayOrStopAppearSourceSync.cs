namespace Phasmatic.RpcValidation {

  public class GhostAudioPlayOrStopAppearSourceSync : RpcValidator<GhostAudio> {

    public override string Name => "PlayOrStopAppearSourceSync";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source?.IsMasterClient ?? true;

  }

}