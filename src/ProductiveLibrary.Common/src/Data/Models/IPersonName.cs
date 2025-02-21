/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  /// <summary> 提供了描述人的姓名的接口。 </summary>
  public interface IPersonName
  {
    #region Properties

    /// <summary> 名字。 </summary>
    /// <value> 设置或获取一个字符串，用于表示名字。 </value>
    string FirstName { get; set; }

    /// <summary> 姓氏。 </summary>
    /// <value> 设置或获取一个字符串，用于表示姓氏。 </value>
    string LastName { get; set; }

    /// <summary> 姓名。 </summary>
    /// <value> 获取一个字符串，用于表示姓名。 </value>
    string Name { get; }

    #endregion Properties
  }
}