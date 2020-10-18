namespace Phasmatic.RpcValidation {

  public abstract class RpcValidator {

    public abstract System.Type View { get; }

    public abstract string Name { get; }

    public abstract bool Validate(PhotonView view, PhotonPlayer source, string name, object[] arguments);

  }

}