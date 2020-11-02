using System.Collections.Generic;
using Photon;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

namespace Phasmatic {

  public class PhasmaticPun : MonoBehaviourPunCallbacks, IPunInstantiateMagicCallback, IPunOwnershipCallbacks, ILobbyCallbacks {

    private void Awake() {
      PhasmaticMod.Instance.Log("PhasmaticPun Awake");
    }

    private void Reset() {
      PhasmaticMod.Instance.Log("PhasmaticPun Reset");
    }

    private void Start() {
      Debug.Log("PhasmaticPun Start");
      if (photonWindowRect.x > 0.0)
        return;

      photonWindowRect.x = Screen.width - photonWindowRect.width;
    }

    private void OnEnable() {
      PhasmaticMod.Instance.Log("PhasmaticPun OnEnable");
    }

    private void OnDisable() {
      PhasmaticMod.Instance.Log("PhasmaticPun OnDisable");
    }

    private void OnDestroy() {
      PhasmaticMod.Instance.Log("PhasmaticPun OnDestroy");
    }
    
    public override void OnConnectedToMaster() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnConnectedToMaster");
    }


    public void OnOwnershipRequest(PhotonView targetView, Photon.Realtime.Player requestingPlayer) {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnOwnershipRequest");
    }

    public void OnOwnershipTransfered(PhotonView targetView, Photon.Realtime.Player previousOwner) {
      throw new System.NotImplementedException();
    }
    public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics) {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnLobbyStatisticsUpdate");
    }

    public void OnPhotonInstantiate(PhotonMessageInfo info) {
      // TODO: analyze
      PhasmaticMod.Instance.Log($"OnPhotonInstantiate from {info.Sender.ActorNumber} view {info.photonView.ViewID}");
    }

    public override void OnJoinedRoom() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnJoinedRoom");
    }
    
    public override void OnCreatedRoom() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnCreatedRoom");
    }

    public override void OnJoinedLobby() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnJoinedLobby");
    }

    public int photonWindowId = 100;

    public Rect photonWindowRect = new Rect(10f, 10f, 500f, 300f);

    //private bool _hostedMode;

    public void OnGUI() {
      photonWindowRect = GUILayout.Window(photonWindowId, photonWindowRect, PhotonWindowCallback, "Photon");
    }

    public void PhotonWindowCallback(int windowID) {
      try {
        GUILayout.Label($"State: {PhotonNetwork.NetworkClientState}");

        if (GUILayout.Button("Toggle Offline Mode")) {
          PhotonNetwork.OfflineMode = !PhotonNetwork.OfflineMode;
        }

        if (PhotonNetwork.IsConnected && GUILayout.Button("Disconnect")) {
          PhotonNetwork.Disconnect();
        }

        if (!PhotonNetwork.IsConnected && GUILayout.Button("Reconnect to Photon Cloud")) {
          //_hostedMode = false;
          PhotonNetwork.OfflineMode = false;
          FindObjectOfType<SteamAuth>().ConnectViaSteamAuthenticator();
        }

        /*
        _hostedMode = GUILayout.Toggle(_hostedMode, "Use Custom Photon Network");

        if (_hostedMode && !PhotonNetwork.connected && !PhotonNetwork.connecting) {
          GUILayout.Label("Server Address:");
          PhotonNetwork.PhotonServerSettings.ServerAddress
            = GUILayout.TextField(PhotonNetwork.PhotonServerSettings.ServerAddress);
          GUILayout.Label("Server Port:");
          PhotonNetwork.PhotonServerSettings.ServerPort
            = ushort.TryParse(GUILayout.TextField(
              PhotonNetwork.PhotonServerSettings.ServerPort.ToString()), out var serverPort)
              ? serverPort
              : 5055;
          GUILayout.Label("Voice Server Port:");
          PhotonNetwork.PhotonServerSettings.VoiceServerPort
            = ushort.TryParse(GUILayout.TextField(
              PhotonNetwork.PhotonServerSettings.VoiceServerPort.ToString()), out var voiceServerPort)
              ? voiceServerPort
              : 5055;
          if (!PhotonNetwork.offlineMode && !PhotonNetwork.connected && !PhotonNetwork.connecting) {
            if (GUILayout.Button("Connect")) {
              PhotonNetwork.offlineMode = false;
              PhotonNetwork.PhotonServerSettings.HostType = ServerSettings.HostingOption.SelfHosted;
              PhotonNetwork.PhotonServerSettings.PunLogging = PhotonLogLevel.Full;
              PhotonNetwork.PhotonServerSettings.NetworkLogging = DebugLevel.ALL;
              FindObjectOfType<SteamAuth>().ConnectViaSteamAuthenticator();
            }
          }
        }
        */

        GUILayout.BeginHorizontal();
        GUILayout.Label("Network Stats");
        var statsStr = PhotonNetwork.NetworkStatisticsToString()
          .Replace(". ", ".\n");
        var boxMaxWidth = 500;
        var height = GUI.skin.box.CalcHeight(new GUIContent(statsStr), boxMaxWidth);
        GUILayout.Box(
          statsStr,
          GUILayout.Width(boxMaxWidth),
          GUILayout.Height(height)
        );
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Reset Stats"))
          PhotonNetwork.NetworkStatisticsReset();
        GUILayout.EndHorizontal();

        if (GUI.changed)
          photonWindowRect.height = 100f;
      }
      catch {
        // ok
      }

      GUI.DragWindow();
    }
  }

}