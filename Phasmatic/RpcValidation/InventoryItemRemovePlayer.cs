namespace Phasmatic.RpcValidation {

  public class InventoryItemRemovePlayer : RpcValidator {

    public override System.Type View => typeof(InventoryItem);

    public override string Name => "RemovePlayer";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments) {
      var actorId = (int) arguments[0];
      return actorId == 999 && source.IsMasterClient
        || source.ID == actorId;
    }

  }

}