using System;
using System.Reflection;
using System.Diagnostics.CodeAnalysis;
using JetBrains.Annotations;
using Photon.Pun;

namespace Phasmatic.RpcValidation {

  [PublicAPI]
  public struct RpcExecutionContext {

    public RpcExecutionContext(PhotonView? view, Photon.Realtime.Player? source, string? name, MethodInfo? method, object[]? arguments) {
      Received = DateTime.Now;
      Source = source;
      Name = name;
      Method = method;
      Arguments = arguments ?? new object[0];
      View = view;
      Validator = null;
      IsValid = false;
    }

    public DateTime Received { get; }

    public PhotonView? View { get; }

    public Photon.Realtime.Player? Source { get; }

    public string? Name { get; }

    public MethodInfo? Method { get; }

    public Type? ViewType => Method?.DeclaringType;

    public object[] Arguments { get; }

    public RpcValidator? Validator { get; set; }

    public bool IsValid { get; set; }

    // ReSharper disable once MethodOverloadWithOptionalParameter
    public T? GetArgument<T>(int index, T? defaultObj = null) where T : class {
      if (index < 0 || Arguments.Length <= index) throw new ArgumentOutOfRangeException(nameof(index));

      return Arguments[index] switch {
        T value => value,
        null => defaultObj,
        _ => throw new ArgumentException("Type does not match.", nameof(T))
      };
    }

    public T GetArgument<T>(int index) where T : notnull {
      if (index < 0 || Arguments.Length <= index) throw new ArgumentOutOfRangeException(nameof(index));

      return Arguments[index] is T value ? value
        : throw new ArgumentException("Type does not match.", nameof(T));
    }

    public bool TryGetArgument<T>(int index, [NotNullWhen(true)] out T? value) where T : class {
      try {
        value = GetArgument<T>(index);
        return true;
      }
      catch {
        value = default;
        return false;
      }
    }

    public bool TryGetValueArgument<T>(int index, out T value) where T : struct {
      try {
        value = GetArgument<T>(index);
        return true;
      }
      catch {
        value = default;
        return false;
      }
    }

  }

}