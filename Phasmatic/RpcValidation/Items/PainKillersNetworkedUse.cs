namespace Phasmatic.RpcValidation {

  public class PainKillersNetworkedUse : RpcValidator<PainKillers> {

    public override string Name => "NetworkedUse";

        protected override bool ValidateInternal(RpcExecution execution)
        {
            var actorId = execution.GetArgument<PhotonPlayer>(0); // ?
            return execution.Source.Equals(actorId);
        }
  }
}