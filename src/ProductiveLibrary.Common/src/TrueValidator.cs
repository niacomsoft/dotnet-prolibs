/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  #region Delegates

  /// <summary> 用于校验 <paramref name="value" /> 是否与 <see langword="true" /> 等效。 </summary>
  /// <typeparam name="T"> 等效值类型。 </typeparam>
  /// <param name="value">
  ///   等效 <see langword="true" /> 的 <typeparamref name="T" /> 类型的值或对象实例。
  /// </param>
  /// <returns> <see cref="bool" /> 类型的值。 </returns>
  public delegate bool TrueValidator<T>(T value);

  #endregion Delegates
}