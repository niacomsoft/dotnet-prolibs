/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.ComponentModel;

namespace Niacomsoft.ProductiveLibrary
{
  #region Delegates

  /// <summary> 包含了松散参数的无返回值的方法委托。 </summary>
  /// <param name="args"> 参数数组。 </param>
  public delegate void RestAction(params object[] args);

  #endregion Delegates
}