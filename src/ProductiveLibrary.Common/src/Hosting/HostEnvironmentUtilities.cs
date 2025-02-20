/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.Threading.Tasks;

namespace Niacomsoft.ProductiveLibrary.Hosting
{
  /// <summary> 提供了访问主机环境信息相关的静态 <see langword="static" /> 方法。 </summary>
  public static partial class HostEnvironmentUtilities
  {
    #region Methods

    /// <summary>
    ///   从指定位置 <paramref name="location" /> 获取名称为 <paramref name="variable" /> 环境变量。
    /// </summary>
    /// <param name="variable"> 环境变量值。 </param>
    /// <param name="location">
    ///   检索环境变量的位置。
    ///   <para> <see cref="EnvironmentVariableTarget" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns> <see cref="Variable" /> 类型的值。 </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.Security.SecurityException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    private static Variable GetEnvironmentVariableImpl(string variable, EnvironmentVariableTarget location)
    {
      var value = new Variable(variable, Environment.GetEnvironmentVariable(variable, location), location);
      if (!value.HasValue && location != EnvironmentVariableTarget.Machine)
      {
        return GetEnvironmentVariableImpl(variable, (EnvironmentVariableTarget)((int)location + 1));
      }
      return value;
    }

    /// <summary>
    ///   从指定位置 <paramref name="start" /> 检索名称为 <paramref name="variable" /> 的环境变量值。
    /// </summary>
    /// <param name="variable"> 环境变量名称。 </param>
    /// <param name="start">
    ///   起始检索位置。
    ///   <para> <see cref="EnvironmentVariableTarget" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns> <see cref="Variable" /> 类型的值。 </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="System.Security.SecurityException">
    ///   当调用 <see cref="Environment.GetEnvironmentVariable(string, EnvironmentVariableTarget)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="ArgumentException">
    ///   当字符串 <paramref name="variable" /> 等于 <see langword="null" />、 <see cref="string.Empty" />
    ///   或空格符时，将引发此类型的异常。
    /// </exception>
    /// <seealso cref="EnvironmentVariableTarget" />
    public static Variable GetEnvironmentVariable(string variable, EnvironmentVariableTarget start = EnvironmentVariableTarget.Process)
    {
      if (AssertUtilities.IsWhiteSpace(variable))
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_string_null_or_whitespace_with_argument_name), nameof(variable)), nameof(variable));
      }

      return GetEnvironmentVariableImpl(variable.Trim(), start);
    }

    #endregion Methods
  }
}