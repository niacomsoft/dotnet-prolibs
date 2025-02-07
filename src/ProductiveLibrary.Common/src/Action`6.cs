/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Delegates

  /// <summary> 无返回值的方法委托。 </summary>
  /// <typeparam name="T1"> 参数类型。 </typeparam>
  /// <typeparam name="T2"> 参数类型。 </typeparam>
  /// <typeparam name="T3"> 参数类型。 </typeparam>
  /// <typeparam name="T4"> 参数类型。 </typeparam>
  /// <typeparam name="T5"> 参数类型。 </typeparam>
  /// <typeparam name="T6"> 参数类型。 </typeparam>
  /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数。 </param>
  /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数。 </param>
  /// <param name="arg3"> <typeparamref name="T3" /> 类型的参数。 </param>
  /// <param name="arg4"> <typeparamref name="T4" /> 类型的参数。 </param>
  /// <param name="arg5"> <typeparamref name="T5" /> 类型的参数。 </param>
  /// <param name="arg6"> <typeparamref name="T6" /> 类型的参数。 </param>
  /// <param name="args"> 附加参数数组。 </param>
  public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, params object[] args);

  #endregion Delegates
}