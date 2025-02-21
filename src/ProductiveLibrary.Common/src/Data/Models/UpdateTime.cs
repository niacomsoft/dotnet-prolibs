/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  /// <summary> 提供了描述数据更新时间相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <seealso cref="ICreationTime" />
  /// <seealso cref="IModificationTime" />
  public abstract class UpdateTime : ICreationTime, IModificationTime
  {
    #region Constructors

    /// <summary> 初始化 <see cref="UpdateTime" /> 类的新实例。 </summary>
    protected UpdateTime()
    {
      CreatedAt = DateTime.UtcNow;
      LastModifiedAt = null;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public virtual DateTime CreatedAt { get; set; }

    /// <inheritdoc />
    public virtual DateTime? LastModifiedAt { get; set; }

    /// <summary>
    ///   数据最后更新时间。
    ///   <para>
    ///     当 <c> <see cref="LastModifiedAt" />.HasValue </c> 等于 <see langword="false" /> 时，返回
    ///     <see cref="CreatedAt" />；否则返回 <c> <see cref="LastModifiedAt" />.Value </c>。
    ///   </para>
    /// </summary>
    /// <value> 获取 <see cref="DateTime" /> 类型的值，用于表示最后修改时间。 </value>
    /// <seealso cref="Nullable{T}.GetValueOrDefault(T)" />
    public virtual DateTime LastUpdatedAt => LastModifiedAt.GetValueOrDefault(CreatedAt);

    #endregion Properties
  }
}