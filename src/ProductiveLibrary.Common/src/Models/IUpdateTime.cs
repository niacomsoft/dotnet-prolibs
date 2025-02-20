/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述更新时间的接口。 </summary>
  /// <seealso cref="ICreationTime" />
  /// <seealso cref="IModificationTime" />
  public interface IUpdateTime : ICreationTime, IModificationTime
  {
    #region Properties

    /// <summary>
    ///   最后更新时间。
    ///   <para>
    ///     当 <see cref="IModificationTime.LastModifiedAt" /> 等于 <see langword="null" /> 时；返回
    ///     <see cref="ICreationTime.CreatedAt" />；否则返回 <c>
    ///     <see cref="IModificationTime.LastModifiedAt" />.Value </c>
    ///   </para>
    /// </summary>
    /// <value> 设置或获取 <see cref="DateTime" /> 类型的值，用于表示最后更新时间。 </value>
    /// <seealso cref="DateTime" />
    /// <seealso cref="ICreationTime.CreatedAt" />
    /// <seealso cref="IModificationTime.LastModifiedAt" />
    DateTime LastUpdatedAt { get; }

    #endregion Properties
  }

  #endregion Interfaces
}