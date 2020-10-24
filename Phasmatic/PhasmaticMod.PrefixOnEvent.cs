using System.Diagnostics.CodeAnalysis;
using ExitGames.Client.Photon;

namespace Phasmatic {

  public partial class PhasmaticMod {

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    private static bool PrefixOnEvent(object __instance, ref EventData photonEvent) {
      var code = photonEvent.Code;
      var id = photonEvent.Sender;
      Instance.Log($"Photon Event Code {code:X2} Id {id}");
      return true;
    }

  }

}