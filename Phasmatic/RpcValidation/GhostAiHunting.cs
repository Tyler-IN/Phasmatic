namespace Phasmatic.RpcValidation {

  public class GhostAiHunting : RpcValidator {

    public override System.Type View => typeof(GhostAI);

    public override string Name => "Hunting";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}