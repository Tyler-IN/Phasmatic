namespace Phasmatic.RpcValidation {

  public class PlayerSetPlayerData : RpcValidator {

    public override System.Type View => typeof(Player);

    public override string Name => "SetPlayerData";

    protected override bool ValidateInternal(RpcExecution execution) {

      var playerId = execution.GetArgument<int>(0);
      var player = PhotonPlayer.Find(playerId);
      return player != null && execution.Source.Equals(player);
    }

  }

}