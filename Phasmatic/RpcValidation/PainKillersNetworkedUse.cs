namespace Phasmatic.RpcValidation {

  public class PainKillersNetworkedUse : RpcValidator {

    public override System.Type View => typeof(PainKillers);

    public override string Name => "NetworkedUse";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments) {
      var actorId = (PhotonPlayer) arguments[0]; // ?
      return source.Equals(actorId);
    }

  }

}