/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 为 <see cref="Exception" /> 类型提供了扩展方法。 </summary>
  public static class ExceptionExtensions
  {
    #region Methods

    /// <summary> 获取异常 <paramref name="me" /> 的描述信息。 </summary>
    /// <param name="me"> <see cref="Exception" /> 类型的对象实例。 </param>
    /// <returns> <see cref="ExceptionInfo" /> 类型的对象实例。 </returns>
    public static ExceptionInfo GetExceptionInfo(this Exception me) => ExceptionInfo.FromException(me);

    #endregion Methods
  }
}