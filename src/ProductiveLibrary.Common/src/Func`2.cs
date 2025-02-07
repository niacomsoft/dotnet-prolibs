/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Delegates

  /// <summary> <typeparamref name="TResult" /> 类型返回值的方法委托。 </summary>
  /// <typeparam name="T1"> 参数类型。 </typeparam>
  /// <typeparam name="TResult"> 返回值结果类型。 </typeparam>
  /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数。 </param>
  /// <param name="args"> 附加参数数组。 </param>
  /// <returns> <typeparamref name="TResult" /> 类型返回值。 </returns>
  public delegate TResult Func<in T1, out TResult>(T1 arg1, params object[] args);

  #endregion Delegates
}