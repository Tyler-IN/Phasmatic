namespace Phasmatic.RpcValidation {

  public class PlayerSetPlayerData : RpcValidator {

    public override System.Type View => typeof(Player);

    public override string Name => "SetPlayerData";

    public override bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments) {
      var playerId = (int) arguments[0];
      var player = PhotonPlayer.Find(playerId);
      return player != null && source.Equals(player);
    }

  }

}