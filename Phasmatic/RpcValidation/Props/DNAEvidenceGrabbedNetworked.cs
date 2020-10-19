namespace Phasmatic.RpcValidation.Props
{
    public class DNAEvidenceGrabbedNetworked : RpcValidator<DNAEvidence>
    {
        public override string Name => "GrabbedNetworked";

        protected override bool ValidateInternal(ref RpcExecutionContext ctx)
        {
            return true;
        }
    }
}
