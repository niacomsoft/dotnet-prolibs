/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  #region Interfaces

  public partial interface IExceptionlessInvoker
  {
    #region Methods

    /// <summary> 执行 <paramref name="func" /> 方法。 </summary>
    /// <typeparam name="TResult"> 方法 <paramref name="func" /> 返回值类型。 </typeparam>
    /// <param name="func"> <see cref="Func{TResult}" /> 类型的方法委托。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Func{TResult}" />
    /// <seealso cref="Result{TResult}" />
    Result<TResult> Invoke<TResult>(Func<TResult> func);

    /// <summary> 执行 <paramref name="func" /> 方法。 </summary>
    /// <typeparam name="TResult"> 方法实际返回值类型。 </typeparam>
    /// <param name="func"> <see cref="RestFunction{TResult}" /> 类型的方法委托。 </param>
    /// <param name="args"> 参数数组。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    /// <seealso cref="RestFunction{TResult}" />
    /// <seealso cref="Result{TResult}" />
    Result<TResult> Invoke<TResult>(RestFunction<TResult> func, params object[] args);

    /// <summary> 执行 <paramref name="func" /> 方法。 </summary>
    /// <typeparam name="TResult"> 方法 <paramref name="func" /> 返回值类型。 </typeparam>
    /// <typeparam name="T"> 参数类型。 </typeparam>
    /// <param name="func"> <see cref="Func{T, TResult}" /> 类型的方法委托。 </param>
    /// <param name="arg"> <typeparamref name="T" /> 类型的参数值。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Func{T, TResult}" />
    /// <seealso cref="Result{TResult}" />
    Result<TResult> Invoke<TResult, T>(Func<T, TResult> func, T arg);

    /// <summary> 执行 <paramref name="func" /> 方法。 </summary>
    /// <typeparam name="TResult"> 方法 <paramref name="func" /> 返回值类型。 </typeparam>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <param name="func"> <see cref="Func{T1, T2, TResult}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数值。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数值。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Func{T1, T2, TResult}" />
    /// <seealso cref="Result{TResult}" />
    Result<TResult> Invoke<TResult, T1, T2>(Func<T1, T2, TResult> func, T1 arg1, T2 arg2);

    /// <summary> 执行 <paramref name="func" /> 方法。 </summary>
    /// <typeparam name="TResult"> 方法 <paramref name="func" /> 返回值类型。 </typeparam>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <typeparam name="T3"> 参数类型。 </typeparam>
    /// <param name="func"> <see cref="Func{T1, T2, T3, TResult}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数值。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数值。 </param>
    /// <param name="arg3"> <typeparamref name="T3" /> 类型的参数值。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Func{T1, T2, T3, TResult}" />
    /// <seealso cref="Result{TResult}" />
    Result<TResult> Invoke<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3);

    /// <summary> 执行 <paramref name="func" /> 方法。 </summary>
    /// <typeparam name="TResult"> 方法 <paramref name="func" /> 返回值类型。 </typeparam>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <typeparam name="T3"> 参数类型。 </typeparam>
    /// <typeparam name="T4"> 参数类型。 </typeparam>
    /// <param name="func"> <see cref="Func{T1, T2, T3, T4, TResult}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数值。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数值。 </param>
    /// <param name="arg3"> <typeparamref name="T3" /> 类型的参数值。 </param>
    /// <param name="arg4"> <typeparamref name="T4" /> 类型的参数值。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Func{T1, T2, T3, T4, TResult}" />
    /// <seealso cref="Result{TResult}" />
    Result<TResult> Invoke<TResult, T1, T2, T3, T4>(Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    /// <summary> 执行 <paramref name="func" /> 方法。 </summary>
    /// <typeparam name="TResult"> 方法 <paramref name="func" /> 返回值类型。 </typeparam>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <typeparam name="T3"> 参数类型。 </typeparam>
    /// <typeparam name="T4"> 参数类型。 </typeparam>
    /// <typeparam name="T5"> 参数类型。 </typeparam>
    /// <param name="func"> <see cref="Func{T1, T2, T3, T4, T5, TResult}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型的参数值。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型的参数值。 </param>
    /// <param name="arg3"> <typeparamref name="T3" /> 类型的参数值。 </param>
    /// <param name="arg4"> <typeparamref name="T4" /> 类型的参数值。 </param>
    /// <param name="arg5"> <typeparamref name="T5" /> 类型的参数值。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Func{T1, T2, T3, T4, T5, TResult}" />
    /// <seealso cref="Result{TResult}" />
    Result<TResult> Invoke<TResult, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    #endregion Methods
  }

  #endregion Interfaces
}