using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Items
{
    public class CCTVPlaceCamera : RpcValidator<CCTV>
    {
        public override string Name => "PlaceCamera";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            int id = execution.GetArgument<int>(0);

            return true;
        }
    }
}
