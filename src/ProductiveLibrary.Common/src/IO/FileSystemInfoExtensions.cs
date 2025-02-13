/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.IO;

namespace Niacomsoft.ProductiveLibrary.IO
{
  /// <summary> 为 <see cref="FileSystemInfo" /> 类型提供了扩展方法。 </summary>
  public static class FileSystemInfoExtensions
  {
    #region Methods

    /// <summary> 刷新并返回 <paramref name="source" /> 是否存在。 </summary>
    /// <param name="source"> 派生自 <see cref="FileSystemInfo" /> 类型的对象实例。 </param>
    /// <returns> <see cref="FileSystemInfo.Exists" /> </returns>
    /// <exception cref="IOException">
    ///   当调用 <see cref="FileSystemInfo.Refresh()" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static bool RefreshAndCheckExists(this FileSystemInfo source)
    {
      source.Refresh();
      return source.Exists;
    }

    #endregion Methods
  }
}