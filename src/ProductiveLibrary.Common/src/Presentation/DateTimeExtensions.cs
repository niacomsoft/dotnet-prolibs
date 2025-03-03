/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary.Presentation
{
  /// <summary> 为 <see cref="DateTime" /> 类型提供了展示、输出所需的扩展方法。 </summary>
  public static class DateTimeExtensions
  {
    #region Methods

    /// <summary> 获取 <paramref name="value" /> 的友好描述文本内容。 </summary>
    /// <param name="value"> <see cref="DateTime" /> 类型的值。 </param>
    /// <param name="now">
    ///   需要对比的参照值。
    ///   <para>
    ///     可能为空的 <see cref="DateTime" /> 类型值。当 <paramref name="now" /> 等于 <see langword="null" />
    ///     时，将使用 <see cref="DateTime.UtcNow" />。
    ///   </para>
    /// </param>
    /// <returns> 友好描述内容。 </returns>
    public static string GetFriendlyText(this DateTime value, DateTime? now = null)
    {
      var refValue = now.GetValueOrDefault(DateTime.UtcNow);
      var interval = refValue - value;
      if (AssertUtilities.IsNegative(interval.TotalMilliseconds) || AssertUtilities.GreaterThan(interval.TotalSeconds, 0x278D00))
      {
        return (AssertUtilities.Equal(refValue.Year, value.Year)) ? value.ToString(SR.GetString(nameof(Strings.DateTime_friendly_name_same_year))) : value.ToString(SR.GetString(nameof(Strings.DateTime_friendly_name)));
      }
      else if (AssertUtilities.LessThanOrEqual(interval.TotalSeconds, 0x3C))
      {
        return SR.GetString(nameof(Strings.DateTime_friendly_name_justnow));
      }
      else if (AssertUtilities.LessThanOrEqual(interval.TotalSeconds, 0xE10))
      {
        return SR.Format(nameof(Strings.DateTime_friendly_name_60_minutes_ago), (int)interval.TotalMinutes);
      }
      else if (AssertUtilities.LessThanOrEqual(interval.TotalSeconds, 0x15180))
      {
        return SR.Format(nameof(Strings.DateTime_friendly_name_24_hours_ago), (int)interval.TotalHours);
      }

      return SR.Format(nameof(Strings.DateTime_friendly_name_30_days_ago), (int)interval.TotalDays);
    }

    #endregion Methods
  }
}