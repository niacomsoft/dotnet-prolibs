/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="value1" /> 晚于 <paramref name="value2" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="value1"> <see cref="DateTime" /> 类型的值。 </param>
    /// <param name="value2"> <see cref="DateTime" /> 类型的值。 </param>
    /// <param name="precision"> 对比精度。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="DateTime" />
    /// <seealso cref="TimeSpan" />
    public static bool After(DateTime value1, DateTime value2, DateTimePrecision precision = DateTimePrecision.Default)
    {
      var interval = value1 - value2;
      if (precision == DateTimePrecision.Year)
      {
        return GreaterThan(value1.Year, value2.Year);
      }
      else if (precision == DateTimePrecision.Month)
      {
        return GreaterThan(value1.Year, value2.Year) || (Equal(value1.Year, value2.Year) && GreaterThan(value1.Month, value2.Month));
      }
      else if (precision == DateTimePrecision.Day)
      {
        return IsPositive(interval.TotalDays);
      }
      else if (precision == DateTimePrecision.Hour)
      {
        return IsPositive(interval.TotalHours);
      }
      else if (precision == DateTimePrecision.Minute)
      {
        return IsPositive(interval.TotalMinutes);
      }
      else if (precision == DateTimePrecision.Second || precision == DateTimePrecision.Default)
      {
        return IsPositive(interval.TotalSeconds);
      }

      return IsPositive(interval.TotalMilliseconds);
    }

    /// <summary>
    ///   当 <paramref name="value1" /> 早于 <paramref name="value2" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="value1"> <see cref="DateTime" /> 类型的值。 </param>
    /// <param name="value2"> <see cref="DateTime" /> 类型的值。 </param>
    /// <param name="precision"> 对比精度。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="DateTime" />
    /// <seealso cref="TimeSpan" />
    public static bool Before(DateTime value1, DateTime value2, DateTimePrecision precision = DateTimePrecision.Default)
    {
      var interval = value1 - value2;
      if (precision == DateTimePrecision.Year)
      {
        return LessThan(value1.Year, value2.Year);
      }
      else if (precision == DateTimePrecision.Month)
      {
        return LessThan(value1.Year, value2.Year) || (Equal(value1.Year, value2.Year) && LessThan(value1.Month, value2.Month));
      }
      else if (precision == DateTimePrecision.Day)
      {
        return IsNegative(interval.TotalDays);
      }
      else if (precision == DateTimePrecision.Hour)
      {
        return IsNegative(interval.TotalHours);
      }
      else if (precision == DateTimePrecision.Minute)
      {
        return IsNegative(interval.TotalMinutes);
      }
      else if (precision == DateTimePrecision.Second || precision == DateTimePrecision.Default)
      {
        return IsNegative(interval.TotalSeconds);
      }

      return IsNegative(interval.TotalMilliseconds);
    }

    /// <summary>
    ///   当 <paramref name="year" /> 为闰年时，返回 <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="year"> 年份数值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   当 <paramref name="year" /><c> &lt; 1 </c> 或 <c> &gt; 9999 </c> 时，将引发此类型的异常。
    /// </exception>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static bool IsLeapYear(int year)
    {
      if (LessThan(year, 1) || GreaterThan(year, 0x270F))
      {
        throw new ArgumentOutOfRangeException(nameof(year), year, SR.Format(nameof(Strings.ArgumentOutOfRangeException_with_argument_name_and_range), nameof(year), "0001 ~ 9999"));
      }

      return IsZero(year % 0x190) || (!IsZero(year % 100) && IsZero(year % 4));
    }

    /// <summary>
    ///   当 <paramref name="dateTime" /> 为闰年时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="dateTime"> 年份数值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="DateTime" />
    /// <seealso cref="IsLeapYear(int)" />
    public static bool IsLeapYear(DateTime dateTime)
    {
      return IsLeapYear(dateTime.Year);
    }

    /// <summary>
    ///   当 <paramref name="dateTime" /> 为闰年时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="dateTime"> 年份数值。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="DateTime" />
    /// <seealso cref="IsLeapYear(int)" />
    public static bool IsLeapYear(DateTimeOffset dateTime)
    {
      return IsLeapYear(dateTime.Year);
    }

    #endregion Methods
  }
}