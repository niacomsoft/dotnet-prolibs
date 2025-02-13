/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AttributeUtilities
  {
    #region Methods

    /// <summary> 获取类型为 <typeparamref name="T" /> 的注解特性。 </summary>
    /// <typeparam name="T"> 派生自 <see cref="Attribute" /> 的类型。 </typeparam>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttribute(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <seealso cref="Assembly" />
    public static T GetCustomAttribute<T>(Assembly assm, bool inherit = true) where T : Attribute
    {
      return Attribute.GetCustomAttribute(assm, typeof(T), inherit) as T;
    }

    /// <summary> 获取类型为 <paramref name="attrType" /> 的注解特性。 </summary>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="attrType"> 派生自 <see cref="Attribute" /> 的类型。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <see cref="Attribute" /> 类型的对象实例。 </returns>
    /// <seealso cref="Assembly" />
    /// <seealso cref="Attribute" />
    /// <seealso cref="Type" />
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttribute(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static Attribute GetCustomAttribute(Assembly assm, Type attrType, bool inherit = true)
    {
      NotAttributeType(attrType);
      return Attribute.GetCustomAttribute(assm, attrType, inherit);
    }

    /// <summary> 获取类型为 <typeparamref name="T" /> 的注解特性。 </summary>
    /// <typeparam name="T"> 派生自 <see cref="Attribute" /> 的类型。 </typeparam>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <typeparamref name="T" /> 类型的数组或集合。 </returns>
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttributes(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <seealso cref="Assembly" />
    /// <seealso cref="IEnumerable{T}" />
    public static IEnumerable<T> GetCustomAttributes<T>(Assembly assm, bool inherit = true) where T : Attribute
    {
      return Attribute.GetCustomAttributes(assm, typeof(T), inherit)?.Select(item => item as T).ToArray();
    }

    /// <summary> 获取类型为 <paramref name="attrType" /> 的注解特性。 </summary>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="attrType"> 派生自 <see cref="Attribute" /> 的类型。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <see cref="Attribute" /> 类型的数组。 </returns>
    /// <seealso cref="Assembly" />
    /// <seealso cref="Attribute" />
    /// <seealso cref="Type" />
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttributes(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static Attribute[] GetCustomAttributes(Assembly assm, Type attrType, bool inherit = true)
    {
      NotAttributeType(attrType);
      return Attribute.GetCustomAttributes(assm, attrType, inherit);
    }

    /// <summary>
    ///   当 <paramref name="assm" /> 使用了 <typeparamref name="T" /> 类型的注解特性时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <typeparam name="T"> 派生自 <see cref="Attribute" /> 的类型。 </typeparam>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="attr"> <see cref="Attribute" /> 类型的对象实例。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Assembly" />
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttribute(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static bool TryGetCustomAttribute<T>(Assembly assm, out T attr, bool inherit = true) where T : Attribute
    {
      attr = GetCustomAttribute<T>(assm, inherit);
      return AssertUtilities.NotNull(attr);
    }

    /// <summary>
    ///   当 <paramref name="assm" /> 使用了 <paramref name="attrType" /> 类型的注解特性时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="attrType"> 派生自 <see cref="Attribute" /> 的类型。 </param>
    /// <param name="attr"> <see cref="Attribute" /> 类型的对象实例。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Assembly" />
    /// <seealso cref="Attribute" />
    /// <seealso cref="Type" />
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttribute(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static bool TryGetCustomAttribute(Assembly assm, Type attrType, out Attribute attr, bool inherit = true)
    {
      attr = GetCustomAttribute(assm, attrType, inherit);
      return AssertUtilities.NotNull(attr);
    }

    /// <summary>
    ///   当 <paramref name="assm" /> 使用了 <typeparamref name="T" /> 类型的注解特性时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <typeparam name="T"> 派生自 <see cref="Attribute" /> 的类型。 </typeparam>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="attrs"> <see cref="Attribute" /> 类型的数组或集合。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Assembly" />
    /// <seealso cref="IEnumerable{T}" />
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttributes(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static bool TryGetCustomAttributes<T>(Assembly assm, out IEnumerable<T> attrs, bool inherit = true) where T : Attribute
    {
      attrs = GetCustomAttributes<T>(assm, inherit);
      return AssertUtilities.NotEmptyCollection<T>(attrs);
    }

    /// <summary>
    ///   当 <paramref name="assm" /> 使用了 <paramref name="attrType" /> 类型的注解特性时，返回
    ///   <see langword="true" />；否则返回 <see langword="false" /> 。
    /// </summary>
    /// <param name="assm"> <see cref="Assembly" /> 类型的对象实例。 </param>
    /// <param name="attrType"> 派生自 <see cref="Attribute" /> 的类型。 </param>
    /// <param name="attrs"> <see cref="Attribute" /> 类型的数组。 </param>
    /// <param name="inherit"> 是否检索继承链。 </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="Assembly" />
    /// <seealso cref="Attribute" />
    /// <seealso cref="Type" />
    /// <exception cref="AmbiguousMatchException">
    ///   当调用 <see cref="Attribute.GetCustomAttributes(Assembly, Type, bool)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static bool TryGetCustomAttributes(Assembly assm, Type attrType, out Attribute[] attrs, bool inherit = true)
    {
      attrs = GetCustomAttributes(assm, attrType, inherit);
      return AssertUtilities.NotEmptyArray(attrs);
    }

    #endregion Methods
  }
}