/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Delegates

  /// <summary> 包含了松散参数、 <typeparamref name="TResult" /> 类型返回值的方法委托 </summary>
  /// <typeparam name="TResult"> 返回值类型。 </typeparam>
  /// <param name="args"> 参数数组。 </param>
  /// <returns> <typeparamref name="TResult" /> 类型的返回值。 </returns>
  public delegate TResult RestFunction<TResult>(params object[] args);

  #endregion Delegates
}