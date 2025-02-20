/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了描述修改时间的接口。 </summary>
  public interface IModificationTime
  {
    #region Properties

    /// <summary> 最后修改时间。 </summary>
    /// <value> 设置或获取可能为空的 <see cref="DateTime" /> 类型值，用于表示最后修改时间。 </value>
    /// <seealso cref="DateTime" />
    DateTime? LastModifiedAt { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}