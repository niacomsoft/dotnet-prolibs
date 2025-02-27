/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System.Collections.Generic;
using System.IO;

namespace Niacomsoft.ProductiveLibrary.IO
{
  /// <summary> 为 <see cref="DirectoryInfo" /> 类型提供了扩展方法。 </summary>
  public static class DirectoryInfoExtensions
  {
    #region Methods

    /// <summary> 将 <paramref name="rootDir" /> 与 <paramref name="parts" /> 组合为一个路径字符串。 </summary>
    /// <param name="rootDir"> 表示根路径。 </param>
    /// <param name="parts"> 其他组成部分。 </param>
    /// <returns> 路径字符串。 </returns>
    /// <exception cref="PathTooLongException">
    ///   当访问 <c> <see cref="DirectoryInfo" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.Security.SecurityException">
    ///   当访问 <c> <see cref="DirectoryInfo" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    public static string Combine(this DirectoryInfo rootDir, params string[] parts)
    {
      var paths = new List<string>(new string[1] { rootDir.FullName });

      if (AssertUtilities.NotEmptyArray(parts))
        paths.AddRange(paths);

      return Path.Combine(paths.ToArray());
    }

    /// <summary> 将 <paramref name="rootDir" /> 与 <paramref name="parts" /> 组合为一个全新的路径。 </summary>
    /// <param name="rootDir"> 表示根路径。 </param>
    /// <param name="parts"> 其他组成部分。 </param>
    /// <returns> <see cref="DirectoryInfo" /> 类型的对象实例。 </returns>
    /// <exception cref="PathTooLongException">
    ///   当访问 <c> <see cref="DirectoryInfo" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.Security.SecurityException">
    ///   当访问 <c> <see cref="DirectoryInfo" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    public static DirectoryInfo CombineDirectory(this DirectoryInfo rootDir, params string[] parts)
    {
      return new DirectoryInfo(rootDir.Combine(parts));
    }

    /// <summary> 将 <paramref name="rootDir" /> 与 <paramref name="parts" /> 组合为一个文件信息。 </summary>
    /// <param name="rootDir"> 表示根路径。 </param>
    /// <param name="parts"> 其他组成部分。 </param>
    /// <returns> <see cref="FileInfo" /> 类型的对象实例。 </returns>
    /// <exception cref="PathTooLongException">
    ///   当访问 <c> <see cref="DirectoryInfo" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.Security.SecurityException">
    ///   当访问 <c> <see cref="DirectoryInfo" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.UnauthorizedAccessException">
    ///   当初始化 <see cref="FileInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.NotSupportedException">
    ///   当初始化 <see cref="FileInfo" /> 类的新实例时，可能引发此类型的异常。
    /// </exception>
    public static FileInfo CombineFile(this DirectoryInfo rootDir, params string[] parts)
    {
      return new FileInfo(rootDir.Combine(parts));
    }

    /// <summary>
    ///   确保路径 <paramref name="dir" /> 存在。
    ///   <para>
    ///     当 <c> <paramref name="dir" />.Exists </c> 返回 <see langword="false" /> 时，自动创建。
    ///   </para>
    /// </summary>
    /// <param name="dir"> <see cref="DirectoryInfo" /> 类型的对象实例。 </param>
    /// <returns> <see cref="DirectoryInfo" /> 类型的对象实例 <paramref name="dir" />。 </returns>
    /// <exception cref="IOException">
    ///   当调用 <see cref="FileSystemInfoExtensions.RefreshAndCheckExists(FileSystemInfo)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.Security.SecurityException">
    ///   当访问 <c> <paramref name="dir" />.FullName </c> 属性时，可能引发此类型的异常。
    /// </exception>
    public static DirectoryInfo EnsureDirectoryExists(this DirectoryInfo dir)
    {
      if (!Doctor.WarningElse(dir.RefreshAndCheckExists(), SR.Format(nameof(Strings.Diagnostics_filesysteminfo_not_exists), dir.FullName)))
      {
        dir.Create();
        dir.Refresh();
      }

      return dir;
    }

    #endregion Methods
  }
}