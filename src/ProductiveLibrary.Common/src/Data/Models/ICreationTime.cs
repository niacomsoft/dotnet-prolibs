/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了数据创建时间的接口。 </summary>
  public interface ICreationTime
  {
    #region Properties

    /// <summary> 数据创建时间。 </summary>
    /// <value> 设置或获取 <see cref="DateTime" /> 类型的值，用于表示数据创建时间。 </value>
    /// <seealso cref="DateTime" />
    DateTime CreatedAt { get; set; }

    #endregion Properties
  }

  #endregion Interfaces
}