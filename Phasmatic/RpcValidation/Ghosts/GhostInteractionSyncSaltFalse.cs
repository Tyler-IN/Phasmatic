namespace Phasmatic.RpcValidation {

  public class GhostInteractionSyncSaltFalse : RpcValidator<GhostInteraction> {

    public override System.Type View => typeof(GhostInteraction);

    public override string Name => "SyncSaltFalse";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx)
      => ctx.Source?.IsMasterClient ?? true;

  }

}