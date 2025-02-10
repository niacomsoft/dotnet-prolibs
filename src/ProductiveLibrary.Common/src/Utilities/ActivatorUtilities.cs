/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  /// <summary> 提供了动态创建对象实例相关的静态 <see langword="static" /> 方法。 </summary>
  public static class ActivatorUtilities
  {
    #region Methods

    /// <summary> 创建 <typeparamref name="T" /> 类型的对象实例。 </summary>
    /// <typeparam name="T"> 引用类型。 </typeparam>
    /// <param name="args"> 初始化 <typeparamref name="T" /> 类型的类的新实例所需的参数。 </param>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    /// <seealso cref="CreateInstance(Type, object[])" />
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TargetInvocationException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="InvalidComObjectException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="COMException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TypeLoadException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public static T CreateInstance<T>(params object[] args) where T : class
    {
      return CreateInstance(typeof(T), args) as T;
    }

    /// <summary> 创建 <paramref name="type" /> 类型的对象实例。 </summary>
    /// <param name="type"> 目标类型。 </param>
    /// <param name="args"> 初始化 <paramref name="type" /> 类型的类的新实例所需的参数。 </param>
    /// <returns> 对象实例。 </returns>
    /// <seealso cref="Activator" />
    /// <seealso cref="Activator.CreateInstance(Type, object[])" />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="type" /> 等于 <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TargetInvocationException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="InvalidComObjectException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="COMException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TypeLoadException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    [SuppressMessage("Style", "IDE0046:转换为条件表达式", Justification = "<挂起>")]
    public static object CreateInstance(Type type, params object[] args)
    {
      if (AssertUtilities.IsNull(type))
      {
        throw new ArgumentNullException(nameof(type), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(type)));
      }

      return Activator.CreateInstance(type, args);
    }

    #endregion Methods
  }
}