namespace Phasmatic.RpcValidation
{

    public class InventoryItemRemovePlayer : RpcValidator
    {

        public override System.Type View => typeof(InventoryItem);

        public override string Name => "RemovePlayer";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            var actorId = ctx.GetArgument<int>(0);
            return actorId == 999 && ctx.Source.IsMasterClient
              || ctx.Source.ID == actorId;
        }

    }

}