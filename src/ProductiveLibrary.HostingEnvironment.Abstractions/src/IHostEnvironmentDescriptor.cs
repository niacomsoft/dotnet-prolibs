/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Hosting;

using System;

namespace Niacomsoft.ProductiveLibrary.Runtime.Hosting
{
  #region Interfaces

  /// <summary> 提供了描述主机环境信息的接口。 </summary>
  public interface IHostEnvironmentDescriptor
  {
    #region Properties

    /// <summary> 公共语言运行时版本信息。 </summary>
    /// <value> 获取 <see cref="Version" /> 类型的对象实例，用于表示公共语言运行时版本信息。 </value>
    /// <seealso cref="Version" />
    Version CLRVersion { get; }

    /// <summary>
    ///   标识主机环境名称的环境变量。
    ///   <para> 默认为 <c> %DOTNETX_ENVIRONMENT% </c> </para>
    /// </summary>
    /// <value> 获取 <see cref="Variable" /> 类型的值，用于表示标识主机环境名称的环境变量。 </value>
    /// <seealso cref="Variable" />
    Variable EnvironmentName { get; }

    /// <summary> 是否为 64 位操作系统。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否为 64 位操作系统。 </value>
    bool Is64BitOperatingSystem { get; }

    /// <summary> 是否为 64 位进程。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示是否为 64 位进程。 </value>
    bool Is64BitProcess { get; }

    /// <summary> 当前主机操作系统相关版本信息。 </summary>
    /// <value> 获取 <see cref="OperatingSystem" /> 类型的对象实例，用于表示当前主机操作系统相关版本信息。 </value>
    OperatingSystem OSVersion { get; }

    /// <summary>
    ///   标识主机的虚拟节点标识环境变量。
    ///   <para> 默认为 <c> %DOTNETX_VIRTUALNODEID% </c> </para>
    /// </summary>
    /// <value> 获取 <see cref="Variable" /> 类型的值，用于表示标识主机的虚拟节点标识环境变量。 </value>
    /// <seealso cref="Variable" />
    Variable VirtualNodeID { get; }

    #endregion Properties
  }

  #endregion Interfaces
}