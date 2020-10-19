namespace Phasmatic.RpcValidation {

  public class GhostInteractionSpawnFootstepNetworked : RpcValidator<GhostInteraction> {

    public override string Name => "SpawnFootstepNetworked";
    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source?.IsMasterClient ?? true;

  }

}