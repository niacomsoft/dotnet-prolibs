/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了动态创建对象实例相关的静态 <see langword="static" /> 方法。 </summary>
  public static class ActivatorHelper
  {
    #region Methods

    /// <summary> 创建 <typeparamref name="T" /> 类型的对象实例。 </summary>
    /// <typeparam name="T"> 引用类型。 </typeparam>
    /// <param name="args"> <typeparamref name="T" /> 类型构造方法所需的参数数组。 </param>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TargetInvocationException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="MethodAccessException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="MemberAccessException">
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
    public static T CreateInstance<T>(params object[] args) where T : class => CreateInstance(typeof(T), args).To<T>();

    /// <summary> 创建类型为 <paramref name="target" /> 的对象实例。 </summary>
    /// <param name="target">
    ///   目标类型。
    ///   <para> <see cref="Type" /> 类型的对象实例。 </para>
    /// </param>
    /// <param name="args"> <see cref="Type" /> 类型构造方法所需的参数数组。 </param>
    /// <returns> 类型为 <paramref name="target" /> 的对象实例。 </returns>
    /// <seealso cref="Activator" />
    /// <seealso cref="Type" />
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="TargetInvocationException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="MethodAccessException">
    ///   当调用 <see cref="Activator.CreateInstance(Type, object[])" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="MemberAccessException">
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
    public static object CreateInstance(Type target, params object[] args) => Activator.CreateInstance(target, args);

    #endregion Methods
  }
}