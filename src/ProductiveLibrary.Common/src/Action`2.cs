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
  /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数。 </param>
  /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数。 </param>
  /// <param name="args"> 附加参数数组。 </param>
  public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2, params object[] args);

  #endregion Delegates
}