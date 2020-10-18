using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phasmatic.RpcValidation.Effects
{
    public class EvidenceSyncEvidenceAmount : RpcValidator<Evidence>
    {
        public override string Name => "SyncEvidenceAmount";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            int amount = execution.GetArgument<int>(0);
            string argumentTypeName = execution.GetArgument<string>(1);
            Enum.TryParse<EvidenceTypeEnum>(argumentTypeName.Replace(' ', '_'), out var evidenceType);

            return true;
        }
    }
}
