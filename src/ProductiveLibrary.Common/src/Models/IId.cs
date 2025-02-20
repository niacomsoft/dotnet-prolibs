/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary.Models
{
  #region Interfaces

  /// <summary> 提供了 <see cref="Guid" /> 类型标识符的接口。 </summary>
  /// <seealso cref="Guid" />
  /// <seealso cref="IId{T}" />
  public interface IGuidId : IId<Guid>
  {
  }

  /// <summary> 提供了模型标识符的接口。 </summary>
  /// <typeparam name="T"> 标识符类型。 </typeparam>
  public interface IId<T>
  {
    #region Properties

    /// <summary> 标识值。 </summary>
    /// <value> 设置或获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示标识值。 </value>
    T Id { get; set; }

    #endregion Properties
  }

  /// <summary> 提供了整型标识符的接口。 </summary>
  /// <seealso cref="IId{T}" />
  public interface IIntId : IId<int>
  {
  }

  /// <summary> 提供了长整型标识符的接口。 </summary>
  /// <seealso cref="IId{T}" />
  public interface ILongId : IId<long>
  {
  }

  /// <summary> 提供了字符串类型标识符的接口。 </summary>
  /// <seealso cref="IId{T}" />
  public interface IStringId : IId<string>
  {
  }

  #endregion Interfaces
}