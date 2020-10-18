namespace Phasmatic.RpcValidation {

  public class PlayerSetPlayerData : RpcValidator {

    public override System.Type View => typeof(Player);

    public override string Name => "SetPlayerData";

    protected override bool ValidateInternal(ref RpcExecutionContext ctx) {

      var playerId = ctx.GetArgument<int>(0);
      var player = PhotonPlayer.Find(playerId);
      return player != null && ctx.Source.Equals(player);
    }

  }

}