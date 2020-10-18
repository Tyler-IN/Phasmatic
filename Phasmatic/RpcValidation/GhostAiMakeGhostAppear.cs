namespace Phasmatic.RpcValidation {

  public class GhostAiMakeGhostAppear : RpcValidator {

    public override System.Type View => typeof(GhostAI);

    public override string Name => "MakeGhostAppear";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments)
      => source.IsMasterClient;

  }

}