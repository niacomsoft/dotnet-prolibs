/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了动态解析服务依赖关系相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <seealso cref="IServiceResolver" />
  public abstract class ServiceResolver : IServiceResolver
  {
    #region Fields

    private static Lazy<IServiceResolver> s_defaultServiceResolver;

    #endregion Fields

    #region Properties

    /// <summary> 默认的服务解析程序。 </summary>
    /// <value> 获取 <see cref="IServiceResolver" /> 类型的对象实例，用于表示默认的服务解析程序。 </value>
    /// <seealso cref="IServiceResolver" />
    public static IServiceResolver Default
    {
      get { return s_defaultServiceResolver.Value; }
    }

    #endregion Properties

    #region Methods

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
    protected abstract object ResolveImpl(string serviceName, Type serviceType);

    /// <summary> 解析 <paramref name="serviceType" /> 类型的服务实例。 </summary>
    /// <param name="serviceType">
    ///   服务类型。
    ///   <para> <see cref="Type" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <paramref name="serviceType" /> 类型的服务实例。 </returns>
    /// <seealso cref="Type" />
    protected abstract object ResolveImpl(Type serviceType);

    /// <summary> 设置默认的服务解析程序。 </summary>
    /// <param name="resolver">
    ///   默认的服务解析程序。
    ///   <para> 实现了 <see cref="IServiceResolver" /> 类型接口的对象实例。 </para>
    /// </param>
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="resolver" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    public static void SetResolver(IServiceResolver resolver)
    {
      if (AssertUtilities.IsNull(resolver))
      {
        throw new ArgumentNullException(nameof(resolver), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(resolver)));
      }

      SetResolver(() => resolver);
    }

    /// <summary> 设置默认的服务解析程序。 </summary>
    /// <param name="provider"> 返回 <see cref="IServiceResolver" /> 类型的对象实例的工厂方法。 </param>
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="provider" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    /// <seealso cref="IServiceResolver" />
    /// <seealso cref="System.Func{TResult}" />
    public static void SetResolver(System.Func<IServiceResolver> provider)
    {
      if (AssertUtilities.IsNull(provider))
      {
        throw new ArgumentNullException(nameof(provider), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(provider)));
      }

      s_defaultServiceResolver = new Lazy<IServiceResolver>(provider, true);
    }

    /// <inheritdoc />
    object IServiceProvider.GetService(Type serviceType)
    {
      return Resolve(serviceType);
    }

    /// <inheritdoc />
    public virtual TService Resolve<TService>() where TService : class
    {
      return Resolve(typeof(TService)) as TService;
    }

    /// <inheritdoc />
    public virtual TService Resolve<TService>(string serviceName) where TService : class
    {
      return Resolve(serviceName, typeof(TService)) as TService;
    }

    /// <inheritdoc />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="serviceType" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    public virtual object Resolve(string serviceName, Type serviceType)
    {
      if (AssertUtilities.IsEmpty(serviceName))
        return Resolve(serviceType);

      if (AssertUtilities.IsNull(serviceType))
      {
        throw new ArgumentNullException(nameof(serviceType), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(serviceType)));
      }

      return ResolveImpl(serviceName, serviceType);
    }

    /// <inheritdoc />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="serviceType" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    public virtual object Resolve(Type serviceType)
    {
      if (AssertUtilities.IsNull(serviceType))
      {
        throw new ArgumentNullException(nameof(serviceType), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(serviceType)));
      }

      return ResolveImpl(serviceType);
    }

    #endregion Methods
  }
}