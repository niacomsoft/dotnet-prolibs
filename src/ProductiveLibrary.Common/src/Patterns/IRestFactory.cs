/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Patterns
{
  #region Interfaces

  /// <summary> 提供了使用松散的参数数组工厂方法的接口。 </summary>
  /// <typeparam name="TResult"> 结果类型。 </typeparam>
  /// <seealso cref="IFactory{TResult}" />
  public interface IRestFactory<TResult> : IFactory<TResult>
  {
    #region Methods

    /// <summary> 创建 <typeparamref name="TResult" /> 类型的值或对象实例。 </summary>
    /// <param name="args"> 参数数组。 </param>
    /// <returns> <typeparamref name="TResult" /> 类型的值或对象实例。 </returns>
    TResult CreateNew(params object[] args);

    #endregion Methods
  }

  #endregion Interfaces
}