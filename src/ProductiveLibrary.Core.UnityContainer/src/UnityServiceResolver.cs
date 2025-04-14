/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

using Unity;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了基于 UnityContainer 的服务解析程序相关的方法。 </summary>
  /// <seealso cref="ServiceResolver" />
  public class UnityServiceResolver : ServiceResolver
  {
    #region Constructors

    /// <summary> 初始化 <see cref="UnityServiceResolver" /> 类的新实例。 </summary>
    /// <param name="container"> 服务依赖注入容器。 </param>
    public UnityServiceResolver(IUnityContainer container)
    {
      Container = container;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 服务依赖注入容器。 </summary>
    /// <value> 获取 <see cref="IUnityContainer" /> 类型的对象实例，用于表示服务依赖注入容器。 </value>
    /// <seealso cref="IUnityContainer" />
    protected virtual IUnityContainer Container { get; }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    protected override object ResolveImpl(string serviceName, Type serviceType)
    {
      return Container.Resolve(serviceType, serviceName);
    }

    /// <inheritdoc />
    protected override object ResolveImpl(Type serviceType)
    {
      return Container.Resolve(serviceType);
    }

    #endregion Methods
  }
}