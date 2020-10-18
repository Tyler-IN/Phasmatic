namespace Phasmatic.RpcValidation {

  public class GhostInteractionSyncSaltFalse : RpcValidator {

    public override System.Type View => typeof(GhostInteraction);

    public override string Name => "SyncSaltFalse";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}