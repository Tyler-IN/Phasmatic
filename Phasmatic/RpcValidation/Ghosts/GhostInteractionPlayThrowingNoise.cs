namespace Phasmatic.RpcValidation {

  public class GhostInteractionPlayThrowingNoise : RpcValidator<GhostInteraction> {

    public override string Name => "PlayThrowingNoise";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source.IsMasterClient;

  }

}