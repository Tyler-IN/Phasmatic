namespace Phasmatic.RpcValidation {

  public class PlayerDead : RpcValidator {

    public override System.Type View => typeof(Player);

    public override string Name => "Dead";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}