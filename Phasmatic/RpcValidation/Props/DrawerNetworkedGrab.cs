namespace Phasmatic.RpcValidation.Props
{
    public class DrawerNetworkedGrab : RpcValidator<Drawer>
    {
        public override string Name => "NetworkedGrab";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
