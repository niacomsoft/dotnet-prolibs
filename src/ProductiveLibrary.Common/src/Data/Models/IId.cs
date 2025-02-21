/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Data.Models
{
  #region Interfaces

  /// <summary> 提供了 <see cref="Guid" /> 类型数据标识符的接口。 </summary>
  /// <seealso cref="Guid" />
  /// <seealso cref="IId{T}" />
  public interface IGuidId : IId<Guid>
  { }

  /// <summary> 提供了描述数据标识符的接口。 </summary>
  /// <typeparam name="T"> 描述数据标识符的类型。 </typeparam>
  public interface IId<T>
  {
    #region Properties

    /// <summary> 数据标识。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示数据标识。 </value>
    T Id { get; set; }

    #endregion Properties
  }

  /// <summary> 提供了 32 位整型值数据标识符的接口。 </summary>
  /// <seealso cref="IId{T}" />
  public interface IIntId : IId<int>
  { }

  /// <summary> 提供了 64 位整型值数据标识符的接口。 </summary>
  /// <seealso cref="IId{T}" />
  public interface ILongId : IId<long>
  { }

  /// <summary> 提供了字符串类型数据标识符的接口。 </summary>
  /// <seealso cref="IId{T}" />
  public interface IStringId : IId<string>
  { }

  #endregion Interfaces
}