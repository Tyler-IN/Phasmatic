using System;

namespace Phasmatic.RpcValidation.Props
{
    public class DrawerNetworkedPlayClosedSound : RpcValidator<Drawer>
    {
        public override Type View => typeof(Drawer);

        public override string Name => "NetworkedPlayClosedSound";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
