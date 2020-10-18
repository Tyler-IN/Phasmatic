namespace Phasmatic.RpcValidation {

    public class InventoryItemChangeTotalAmountNetworked : RpcValidator
    {

        public override System.Type View => typeof(InventoryItem);

        public override string Name => "ChangeTotalAmountNetworked";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            var actorId = execution.GetArgument<int>(0);
            return actorId == 999 && (execution.Source.IsMasterClient
              || execution.Source.ID == actorId);
        }

    }

}