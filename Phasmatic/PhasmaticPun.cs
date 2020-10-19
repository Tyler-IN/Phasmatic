using Photon;
using UnityEngine;

namespace Phasmatic {

  public class PhasmaticPun : PunBehaviour {

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

    public override void OnPhotonPlayerPropertiesChanged(object[] playerAndUpdatedProps) {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnPhotonPlayerPropertiesChanged");
    }

    public override void OnOwnershipRequest(object[] viewAndPlayer) {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnOwnershipRequest");
    }

    public override void OnLobbyStatisticsUpdate() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnLobbyStatisticsUpdate");
    }

    public override void OnPhotonPlayerActivityChanged(PhotonPlayer otherPlayer) {
      // TODO: analyze
      PhasmaticMod.Instance.Log($"OnPhotonPlayerActivityChanged {otherPlayer.ID}");
    }

    public override void OnConnectedToPhoton() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnConnectedToPhoton");
    }

    public override void OnDisconnectedFromPhoton() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnDisconnectedFromPhoton");
    }

    public override void OnPhotonInstantiate(PhotonMessageInfo info) {
      // TODO: analyze
      PhasmaticMod.Instance.Log($"OnPhotonInstantiate from {info.sender.ID} view {info.photonView.viewID}");
    }

    public override void OnJoinedRoom() {
      // TODO: analyze
      PhasmaticMod.Instance.Log("OnJoinedRoom");
    }

    public override void OnPhotonPlayerConnected(PhotonPlayer newPlayer) {
      // TODO: analyze
      PhasmaticMod.Instance.Log($"OnPhotonPlayerConnected {newPlayer.ID}");
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
        GUILayout.Label($"State: {PhotonNetwork.connectionStateDetailed.ToString()}");

        if (GUILayout.Button("Toggle Offline Mode")) {
          PhotonNetwork.offlineMode = !PhotonNetwork.offlineMode;
        }

        if ((PhotonNetwork.connected || PhotonNetwork.connecting) && GUILayout.Button("Disconnect")) {
          PhotonNetwork.Disconnect();
        }

        if (!PhotonNetwork.connected && !PhotonNetwork.connecting
          && GUILayout.Button("Reconnect to Photon Cloud")) {
          //_hostedMode = false;
          PhotonNetwork.offlineMode = false;
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
          GUILayout.MaxWidth(boxMaxWidth),
          GUILayout.MinHeight(height)
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