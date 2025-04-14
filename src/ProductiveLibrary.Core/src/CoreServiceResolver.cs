/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Microsoft.Extensions.DependencyInjection;

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了基于 <see cref="IServiceProvider" /> 动态解析服务实例相关的方法。 </summary>
  /// <seealso cref="ServiceResolver" />
  public class CoreServiceResolver : ServiceResolver
  {
    #region Constructors

    /// <summary> 初始化 <see cref="CoreServiceResolver" /> 类的新实例。 </summary>
    /// <param name="services">
    ///   服务依赖注入容器。
    ///   <para> 实现了 <see cref="IServiceCollection" /> 类型接口的对象实例。 </para>
    /// </param>
    public CoreServiceResolver(IServiceCollection services) : this(services.BuildServiceProvider())
    {
    }

    /// <summary> 初始化 <see cref="CoreServiceResolver" /> 类的新实例。 </summary>
    /// <param name="provider"> 动态解析服务依赖关系的方法。 </param>
    public CoreServiceResolver(IServiceProvider provider)
    {
      Provider = provider;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 动态解析服务依赖关系的方法。 </summary>
    /// <value> 获取 <see cref="IServiceProvider" /> 类型的对象实例，用于表示动态解析服务依赖关系的方法。 </value>
    /// <seealso cref="IServiceProvider" />
    protected virtual IServiceProvider Provider { get; }

    #endregion Properties

    #region Methods

    /// <inheritdoc />
    protected override object ResolveImpl(string serviceName, Type serviceType)
    {
      return Provider.GetRequiredKeyedService(serviceType, serviceName);
    }

    /// <inheritdoc />
    protected override object ResolveImpl(Type serviceType)
    {
      return Provider.GetService(serviceType);
    }

    #endregion Methods
  }
}