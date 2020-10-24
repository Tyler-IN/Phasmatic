using System.Diagnostics.CodeAnalysis;
using ExitGames.Client.Photon;
using UnityEngine;
using UnityEngine.Analytics;

namespace Phasmatic {

  public partial class PhasmaticMod {

    [SuppressMessage("ReSharper", "InconsistentNaming")]
    private static bool PrefixOnEvent(object __instance, ref EventData photonEvent) {
      var code = photonEvent.Code;
      var id = photonEvent.Sender;
      Instance.Log($"Photon Event Code {code:X2} Id {id}");

      switch (code) {
        case 201:
        case 206: // sync object?
        {
          var eventData = (Hashtable) photonEvent[245];
          var timestamp = (int) eventData[0];
          var hasPrefix = eventData.ContainsKey(1);
          var prefix = hasPrefix ? (short) eventData[1] : -1;
          var argKeyA = 10;
          var argKeyB = 10;
          var maxArgKey = eventData.Count - (hasPrefix ? 2 : 1);
          while ((argKeyA - argKeyB) > maxArgKey) {
            var args = eventData[argKeyA];
            argKeyA += 1;
          }
          
          // TODO: validate
          
          break;
        }
        case 202: // Instantiate
        {
          var eventData = (Hashtable) photonEvent[245];
          var prefabId = (string) eventData[0];
          var position = eventData.ContainsKey(1) ? (Vector3) eventData[1] : default;
          var rotation = eventData.ContainsKey(2) ? (Quaternion) eventData[2] : default;
          var group = eventData.ContainsKey(3) ? (byte) eventData[3] : -1;
          var viewData = eventData.ContainsKey(4) ? (int[]) eventData[4] : null;
          var timestamp = (int) eventData[6];
          var instanceId = (int) eventData[7];
          var prefix = eventData.ContainsKey(8) ? (short) eventData[8] : -1;

          var viewId = viewData?[0] ?? instanceId;

          /* view may not exist, may be created after call
          PhotonView? view = null;
          try {
            view = PhotonView.Find(viewId);
          }
          catch {
            // can't find view
          }
          */
          
          // TODO: validate

          break;
        }

        case 204: // Destroy
        {
          var eventData = (Hashtable) photonEvent[245];
          var viewId = (int) eventData[0];

          PhotonView? view = null;
          try {
            view = PhotonView.Find(viewId);
          }
          catch {
            // can't find view
          }
          
          // TODO: validate

          break;
        }
        case 207: // DestroyAll
        {
          
          // TODO: validate
          break;
        }
        case 209: // OwnershipRequest
        {
          
          // TODO: validate
          break;
        }
        case 210: // OwnershipTransfer
        {
          
          // TODO: validate
          break;
        }
        case 212: // reload level?
        {
          
          var isAsync = (bool) photonEvent.Parameters[245];
          var scene = SceneManagerHelper.ActiveSceneName;
          // TODO: validate
          break;
        }
      }

      return true;
    }

  }

}