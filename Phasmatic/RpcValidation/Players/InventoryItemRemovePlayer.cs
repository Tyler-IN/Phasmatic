namespace Phasmatic.RpcValidation
{

    public class InventoryItemRemovePlayer : RpcValidator
    {

        public override System.Type View => typeof(InventoryItem);

        public override string Name => "RemovePlayer";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            var actorId = execution.GetArgument<int>(0);
            return actorId == 999 && execution.Source.IsMasterClient
              || execution.Source.ID == actorId;
        }

    }

}