/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了描述是否为选填项的接口。 </summary>
  /// <typeparam name="T"> 描述是否为选填项的类型。 </typeparam>
  public interface IOptional<T>
  {
    #region Properties

    /// <summary> 是否为选填项。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示是否为选填项。 </value>
    T Optional { get; set; }

    #endregion Properties
  }

  /// <summary> 提供了使用 32 位整型值描述是否为选填项的接口。 </summary>
  /// <seealso cref="IOptional{T}" />
  public interface IOptional : IOptional<int>
  { }

  #endregion Interfaces
}