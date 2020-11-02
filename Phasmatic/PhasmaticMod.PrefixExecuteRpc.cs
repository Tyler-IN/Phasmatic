using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using ExitGames.Client.Photon;
using Phasmatic.RpcValidation;
using Photon.Pun;

namespace Phasmatic {

  public partial class PhasmaticMod {

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static bool PrefixExecuteRpc(object __instance,
      ref Hashtable rpcData,
      ref int senderID,
      ref object ___keyByteZero,
      ref object ___keyByteThree,
      ref object ___keyByteFour,
      ref object ___keyByteFive) {
      Photon.Realtime.Player? sender = null;
      try {
        sender = PhotonNetwork.CurrentRoom.GetPlayer(senderID);
      }
      catch {
        // can't find sender
      }

      var viewId = (int) rpcData[___keyByteZero];

      PhotonView? view = null;
      try {
        view = PhotonView.Find(viewId);
      }
      catch {
        // can't find view
      }

      var viewDesc = view == null
        ? "Invalid View #{viewId}"
        : $"{view.gameObject.name} #{viewId} (owned by {view.OwnerActorNr})";

      var senderDesc = $"{sender?.NickName ?? "Invalid Player"} #{senderID} STEAM:{sender?.UserId}";

      string rpcName;
      if (!rpcData.ContainsKey(___keyByteFive))
        rpcName = (string) rpcData[___keyByteThree];
      else {
        int rpcIndex = (byte) rpcData[___keyByteFive];
        if (rpcIndex > PhotonNetwork.PhotonServerSettings.RpcList.Count - 1) {
          Instance.LogError($"Invalid RPC #{rpcIndex} from {senderDesc} on {viewDesc}");
          return true;
        }

        rpcName = PhotonNetwork.PhotonServerSettings.RpcList[rpcIndex];
      }

      var rpcArgs = (object[]) rpcData[___keyByteFour];

      var rpcArgsDesc = string.Join(", ", rpcArgs.Select(a => a.ToString()));

      Instance.Log($"Photon RPC {rpcName} from {senderDesc}: {rpcArgsDesc}");

      MethodInfo? method = null;

      if (view != null) {
        var rpcMonoBehaviors = PhotonViewRpcMonoBehaviorsGetter(view);
        if (!PhotonNetwork.UseRpcMonoBehaviourCache && rpcMonoBehaviors == null) {
          view.RefreshRpcMonoBehaviourCache();
          rpcMonoBehaviors = PhotonViewRpcMonoBehaviorsGetter(view);
        }

        foreach (var behavior in rpcMonoBehaviors) {
          var type = behavior.GetType();
          method = type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .FirstOrDefault(mi => mi.Name == rpcName && mi.GetCustomAttribute<PunRPC>() != null);
        }
      }

      var context = new RpcExecutionContext(view, sender, rpcName, method, rpcArgs);

      // will probably need to organize by view type then by name later since rpcs can have same names
      if (RpcValidatorsByRpcName.TryGetValue(rpcName, out var validator)) {
        if (view == null) {
          Instance.LogError($"No View to match against validators");
          if (validator.View == null)
            if (!validator.Validate(ref context)) {
              Instance.LogError($"RPC Validation failed!");
              // can return false to ignore RPC
              return false;
            }
        }
        else {
          /*
          var comp = view.ObservedComponents
            .FirstOrDefault(c => validator.View.IsInstanceOfType(c));
          if (comp == null)
            Instance.LogError($"No matching component on view for {validator.GetType().Name}");
          else {
            Instance.LogError($"Matched component on view for {validator.GetType().Name}");
          }
            */

          if (!validator.Validate(ref context)) {
            Instance.LogError($"RPC Validation failed!");
            // can return false to ignore RPC
            return false;
          }
        }
      }

      return true;
    }

  }

}