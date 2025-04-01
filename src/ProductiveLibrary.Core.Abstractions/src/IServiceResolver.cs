/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  /// <summary> 提供了动态解析服务依赖的接口。 </summary>
  /// <seealso cref="IServiceProvider" />
  public interface IServiceResolver : IServiceProvider
  {
    #region Methods

    /// <summary> 解析 <typeparamref name="TService" /> 类型的服务实例。 </summary>
    /// <typeparam name="TService"> 服务类型。 </typeparam>
    /// <returns> <typeparamref name="TService" /> 类型的对象实例。 </returns>
    TService Resolve<TService>() where TService : class;

    /// <summary>
    ///   解析名称为 <paramref name="serviceName" /> 的 <typeparamref name="TService" /> 类型的服务实例。
    /// </summary>
    /// <typeparam name="TService"> 服务类型。 </typeparam>
    /// <param name="serviceName"> 服务注册名称。 </param>
    /// <returns> <typeparamref name="TService" /> 类型的对象实例。 </returns>
    TService Resolve<TService>(string serviceName) where TService : class;

    /// <summary>
    ///   解析名称为 <paramref name="serviceName" /> 的 <paramref name="serviceType" /> 类型的服务实例。
    /// </summary>
    /// <param name="serviceName"> 服务注册名称。 </param>
    /// <param name="serviceType">
    ///   服务类型。
    ///   <para> <see cref="Type" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <paramref name="serviceType" /> 类型的服务实例。 </returns>
    /// <seealso cref="Type" />
    object Resolve(string serviceName, Type serviceType);

    /// <summary> 解析 <paramref name="serviceType" /> 类型的服务实例。 </summary>
    /// <param name="serviceType">
    ///   服务类型。
    ///   <para> <see cref="Type" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <paramref name="serviceType" /> 类型的服务实例。 </returns>
    /// <seealso cref="Type" />
    object Resolve(Type serviceType);

    #endregion Methods
  }

  #endregion Interfaces
}