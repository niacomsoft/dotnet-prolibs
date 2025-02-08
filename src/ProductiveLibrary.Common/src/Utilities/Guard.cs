/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  /// <summary> 提供了安全值相关的静态 <see langword="static" /> 方法。 </summary>
  public static partial class Guard
  {
    #region Methods

    /// <summary>
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时返回
    ///   <paramref name="default" />；否则返回 <paramref name="value" />。
    /// </summary>
    /// <param name="value"> 需要校验的原始值。 </param>
    /// <param name="default">
    ///   构建当 <paramref name="value" /> 等于 <see langword="null" /> 时需要返回的值的方法。
    /// </param>
    /// <param name="args"> 参数数组。 </param>
    /// <returns> <see cref="object" /> 类型的值或对象实例。 </returns>
    /// <seealso cref="Func{TResult}" />
    public static object DefaultIfNull(object value, Func<object> @default, params object[] args)
    {
      return DefaultIfNull(value, @default?.Invoke(args));
    }

    /// <summary>
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时返回
    ///   <paramref name="default" />；否则返回 <paramref name="value" />。
    /// </summary>
    /// <param name="value"> 需要校验的原始值。 </param>
    /// <param name="default">
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时需要返回的值。
    /// </param>
    /// <returns> <see cref="object" /> 类型的值或对象实例。 </returns>
    public static object DefaultIfNull(object value, object @default)
    {
      return AssertUtilities.IsNull(value) ? @default : value;
    }

    /// <summary>
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时返回
    ///   <paramref name="default" />；否则返回 <paramref name="value" />。
    /// </summary>
    /// <param name="value"> 需要校验的原始值。 </param>
    /// <param name="default">
    ///   构建当 <paramref name="value" /> 等于 <see langword="null" /> 时需要返回的值的方法。
    /// </param>
    /// <returns> <see cref="object" /> 类型的值或对象实例。 </returns>
    /// <seealso cref="System.Func{TResult}" />
    public static object DefaultIfNull(object value, System.Func<object> @default)
    {
      return DefaultIfNull(value, @default?.Invoke());
    }

    /// <summary>
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时返回
    ///   <paramref name="default" />；否则返回 <paramref name="value" />。
    /// </summary>
    /// <typeparam name="T"> 目标类型。 </typeparam>
    /// <param name="value"> 需要校验的原始值。 </param>
    /// <param name="default">
    ///   构建当 <paramref name="value" /> 等于 <see langword="null" /> 时需要返回的值的方法。
    /// </param>
    /// <param name="args"> 参数数组。 </param>
    /// <returns> <see cref="object" /> 类型的值或对象实例。 </returns>
    /// <seealso cref="Func{TResult}" />
    public static T DefaultIfNull<T>(T value, Func<T> @default, params object[] args)
    {
      return DefaultIfNull(value, @default.Invoke(args));
    }

    /// <summary>
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时返回
    ///   <paramref name="default" />；否则返回 <paramref name="value" />。
    /// </summary>
    /// <typeparam name="T"> 目标类型。 </typeparam>
    /// <param name="value"> 需要校验的原始值。 </param>
    /// <param name="default">
    ///   构建当 <paramref name="value" /> 等于 <see langword="null" /> 时需要返回的值的方法。
    /// </param>
    /// <returns> <see cref="object" /> 类型的值或对象实例。 </returns>
    /// <seealso cref="System.Func{TResult}" />
    public static T DefaultIfNull<T>(T value, System.Func<T> @default)
    {
      return DefaultIfNull(value, @default.Invoke());
    }

    /// <summary>
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时返回
    ///   <paramref name="default" />；否则返回 <paramref name="value" />。
    /// </summary>
    /// <typeparam name="T"> 目标类型。 </typeparam>
    /// <param name="value"> 需要校验的原始值。 </param>
    /// <param name="default">
    ///   当 <paramref name="value" /> 等于 <see langword="null" /> 时需要返回的值。
    /// </param>
    /// <returns> <typeparamref name="T" /> 类型的值或对象实例。 </returns>
    public static T DefaultIfNull<T>(T value, T @default)
    {
      return AssertUtilities.IsNull(value) ? @default : value;
    }

    #endregion Methods
  }
}