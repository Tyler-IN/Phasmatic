namespace Phasmatic.RpcValidation {

  public class InventoryItemChangeTotalAmountNetworked : RpcValidator {

    public override System.Type View => typeof(InventoryItem);

    public override string Name => "ChangeTotalAmountNetworked";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx) {
      var src = ctx.Source;
      var actorId = ctx.GetArgument<int>(0);
      return (src == null || src.IsMasterClient) && actorId == 999
        || src?.ID == actorId;
    }

  }

}