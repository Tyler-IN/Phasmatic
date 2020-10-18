namespace Phasmatic.RpcValidation {

    public class InventoryItemChangeTotalAmountNetworked : RpcValidator
    {

        public override System.Type View => typeof(InventoryItem);

        public override string Name => "ChangeTotalAmountNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            var actorId = ctx.GetArgument<int>(0);
            return actorId == 999 && (ctx.Source.IsMasterClient
              || ctx.Source.ID == actorId);
        }

    }

}