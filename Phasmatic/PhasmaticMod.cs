using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using BepInEx;
using BepInEx.Logging;
using ExitGames.Client.Photon;
using HarmonyLib;
using JetBrains.Annotations;
using Phasmatic.RpcValidation;
using UnityEngine;
using UnityEngine.SceneManagement;
using Debug = UnityEngine.Debug;

namespace Phasmatic {

  [PublicAPI]
  [BepInPlugin(nameof(Phasmatic), nameof(Phasmatic), "0.1.1.0")]
  public partial class PhasmaticMod : BaseUnityPlugin {

    private GameObject? _go;

    private readonly Harmony _harmony = new Harmony(nameof(PhasmaticMod));

    public static PhasmaticMod Instance { get; private set; } = null!;

    public PhasmaticMod() {
      Instance = this;
      var unityLogger = Debug.unityLogger;
      //unityLogger.logHandler = new PhasmaticLog();
      unityLogger.filterLogType = LogType.Log;
      unityLogger.logEnabled = true;

      SceneManager.sceneLoaded += (scene, mode) => {
        // TODO: analyze
        Debug.Log($"Scene Loaded: {scene.path} \"{scene.name}\"");

        if (scene.path.StartsWith("Assets/Scenes/Menu"))
          OnMenuLoaded();
      };

      AppDomain.CurrentDomain.UnhandledException += (sender, args) => {
        Debug.unityLogger.LogException((Exception) args.ExceptionObject, null);
      };

      AppDomain.CurrentDomain.FirstChanceException += (sender, args) => {
        var exc = args.Exception;
        var sf = new StackFrame(1, false);
        var mb = sf.GetMethod();
        Debug.unityLogger.LogWarning("FCE", $"{mb.FullDescription()}:IL_{sf.GetILOffset():X4}: {exc.GetType().Name}: {exc.Message}");
      };

      TaskScheduler.UnobservedTaskException += (sender, args) => {
        var aex = args.Exception;
        foreach (var exc in aex.InnerExceptions) {
          var st = new StackTrace(exc);
          var sf = st.GetFrame(1);
          var mb = sf.GetMethod();
          Debug.unityLogger.LogWarning("UTE", $"{mb.FullDescription()}:IL_{sf.GetILOffset():X4}: {exc.GetType().Name}: {exc.Message}");
        }
      };
    }

    private bool _menuLoaded;

    public static readonly RpcValidator[] RpcValidators
      = typeof(PhasmaticMod).Assembly
        .GetExportedTypes()
        .Where(t => typeof(RpcValidator).IsAssignableFrom(t) && !t.IsAbstract)
        .Select(t => (RpcValidator) Activator.CreateInstance(t))
        .ToArray();

    public static readonly Dictionary<string, RpcValidator> RpcValidatorsByRpcName
      = RpcValidators.ToDictionary(v => v.Name);

    private static readonly GetterHandler<PhotonView, MonoBehaviour[]> PhotonViewRpcMonoBehaviorsGetter = FastAccess.CreateFieldGetter<PhotonView, MonoBehaviour[]>("RpcMonoBehaviors");

    private const BindingFlags AnyBinding =
      BindingFlags.Public
      | BindingFlags.NonPublic
      | BindingFlags.Static
      | BindingFlags.Instance;

    private void OnMenuLoaded() {
      if (_menuLoaded) return;

      _menuLoaded = true;

      Debug.developerConsoleVisible = false;
      PhotonNetwork.logLevel = PhotonLogLevel.Full;

      _go = new GameObject("Phasmatic");
      _go.isStatic = true;
      _go.hideFlags |= HideFlags.HideAndDontSave | HideFlags.DontUnloadUnusedAsset;
      _go.AddComponent<PhasmaticPun>();
      _go.SetActive(true);
      DontDestroyOnLoad(_go);

      Log($"Created Phasmatic GameObject");

      if (Debug.isDebugBuild)
        Log("Welcome to the Jungle!");

      {
        // NetworkingPeer.OnEvent
        var np = typeof(PhotonNetwork).Assembly.GetType("NetworkingPeer");
        var m = np.GetMethod("OnEvent", AnyBinding);

        Log($"Patching {m.FullDescription()}");
        _harmony.Patch(m, new HarmonyMethod(typeof(PhasmaticMod), nameof(PrefixOnEvent)));
      }

      {
        // NetworkingPeer.ExecuteRpc
        var np = typeof(PhotonNetwork).Assembly.GetType("NetworkingPeer");
        var m = np.GetMethod("ExecuteRpc", AnyBinding);
        Log($"Patching {m.FullDescription()}");
        _harmony.Patch(m, new HarmonyMethod(typeof(PhasmaticMod), nameof(PrefixExecuteRpc)));
      }
    }

    internal void Log(string msg) {
      Logger.Log(LogLevel.Info, msg);
    }

    internal void LogWarning(string msg) {
      Logger.Log(LogLevel.Warning, msg);
    }

    internal void LogError(string msg) {
      Logger.Log(LogLevel.Error, msg);
    }

  }

}