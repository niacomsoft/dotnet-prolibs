/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Diagnostics;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  /// <summary> 提供了断言相关相关的静态 <see langword="static" /> 方法。 </summary>
  public static class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="childType" /> 继承自 <paramref name="baseType" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="childType"> 子类型。 </param>
    /// <param name="baseType"> 父类型。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Type" />
    private static bool InheritFromImpl(Type childType, Type baseType)
    {
      return childType.IsSubclassOf(baseType);
    }

    /// <summary>
    ///   当 <paramref name="childType" /> 继承自 <typeparamref name="T" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <typeparam name="T"> 父类型。 </typeparam>
    /// <param name="childType"> 子类型。 </param>
    /// <param name="ifNull">
    ///   当 <paramref name="childType" /> 等于 <see langword="null" /> 时需要返回的值。
    ///   <para> 默认值 <see langword="true" />。 </para>
    /// </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="InheritFrom(Type, Type, bool)" />
    public static bool InheritFrom<T>(Type childType, bool ifNull = true)
    {
      return InheritFrom(childType, typeof(T), ifNull);
    }

    /// <summary>
    ///   当 <paramref name="childType" /> 继承自 <paramref name="baseType" /> 时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="childType"> 子类型。 </param>
    /// <param name="baseType"> 父类型。 </param>
    /// <param name="ifNull">
    ///   当 <paramref name="childType" /> 或 <paramref name="baseType" /> 等于 <see langword="null" />
    ///   时需要返回的值。
    ///   <para> 默认值 <see langword="true" />。 </para>
    /// </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static bool InheritFrom(Type childType, Type baseType, bool ifNull = true)
    {
      if (Doctor.DebugIf(IsNull(childType) || IsNull(baseType), SR.GetString(nameof(Strings.Diagnostics_inherit_from))))
      {
        return ifNull;
      }

      return InheritFromImpl(childType, baseType);
    }

    /// <summary>
    ///   当 <paramref name="o" /> 为 <paramref name="type" /> 类型的实例时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="o"> <see cref="object" /> 类型的值或对象实例。 </param>
    /// <param name="type"> 目标类型。 </param>
    /// <param name="ifNull">
    ///   当 <paramref name="o" /> 或 <paramref name="type" /> 等于 <see langword="null" /> 时需要返回的值。
    ///   <para> 默认值 <see langword="false" />。 </para>
    /// </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="InheritFrom(Type, Type, bool)" />
    /// <seealso cref="Type" />
    public static bool InstanceOf(object o, Type type, bool ifNull = false)
    {
      return InheritFrom(o?.GetType(), type, ifNull);
    }

    /// <summary>
    ///   当 <paramref name="o" /> 为 <typeparamref name="T" /> 类型的实例时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <typeparam name="T"> 目标类型。 </typeparam>
    /// <param name="o"> <see cref="object" /> 类型的值或对象实例。 </param>
    /// <param name="ifNull">
    ///   当 <paramref name="o" /> 等于 <see langword="null" /> 时需要返回的值。
    ///   <para> 默认值 <see langword="false" />。 </para>
    /// </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static bool InstanceOf<T>(object o, bool ifNull = false)
    {
      if (Doctor.DebugIf(IsNull(o), SR.GetString(nameof(Strings.Diagnostics_inherit_from))))
      {
        return ifNull;
      }

      return o is T;
    }

    /// <summary>
    ///   当 <paramref name="o" /> 等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="o"> 需要验证的 <see cref="object" /> 类型的值或对象实例。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    public static bool IsNull(object o)
    {
      return Doctor.DebugIf(o is null, SR.GetString(nameof(Strings.Diagnostics_message_isnull)));
    }

    /// <summary>
    ///   当 <paramref name="o" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="o"> 需要验证的 <see cref="object" /> 类型的值或对象实例。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="IsNull(object)" />
    public static bool NotNull(object o)
    {
      return !IsNull(o);
    }

    #endregion Methods
  }
}