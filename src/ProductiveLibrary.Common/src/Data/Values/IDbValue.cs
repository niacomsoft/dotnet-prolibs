/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Values
{
  #region Interfaces

  /// <summary> 提供了数据库值的接口。 </summary>
  /// <typeparam name="T"> 数据库值类型。 </typeparam>
  public interface IDbValue<T>
  {
    #region Properties

    /// <summary> 数据库值。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示数据库值。 </value>
    T Value { get; }

    #endregion Properties
  }

  #endregion Interfaces
}