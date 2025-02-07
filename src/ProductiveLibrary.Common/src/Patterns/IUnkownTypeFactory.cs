﻿/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了创建 <typeparamref name="TResult" /> 类型对象实例的工厂方法的接口。 </summary>
  /// <typeparam name="TResult">
  ///   返回值类型。
  ///   <para> 引用类型。 </para>
  /// </typeparam>
  /// <seealso cref="IKnownTypeFactory{TResult}" />
  public interface IUnknownTypeFactory<out TResult> : IKnownTypeFactory<TResult> where TResult : class
  {
    #region Methods

    /// <summary> 创建 <typeparamref name="TResult" /> 类型的对象实例。 </summary>
    /// <param name="args"> 未知类型的参数数组。 </param>
    /// <returns> <typeparamref name="TResult" /> 类型的对象实例。 </returns>
    TResult CreateInstance(params object[] args);

    #endregion Methods
  }

  #endregion Interfaces
}