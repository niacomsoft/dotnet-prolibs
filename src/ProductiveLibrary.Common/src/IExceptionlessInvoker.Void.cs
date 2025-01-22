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

    /// <summary> 执行 <paramref name="action" /> 方法。 </summary>
    /// <param name="action"> <see cref="Action" /> 类型的方法委托。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Action" />
    /// <seealso cref="Result" />
    Result Invoke(Action action);

    /// <summary> 执行 <paramref name="action" /> 方法。 </summary>
    /// <param name="action"> <see cref="RestAction" /> 类型的方法委托。 </param>
    /// <param name="args"> 参数数组。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="RestAction" />
    /// <seealso cref="Result" />
    Result Invoke(RestAction action, params object[] args);

    /// <summary> 执行 <paramref name="action" /> 方法。 </summary>
    /// <typeparam name="T"> 参数类型。 </typeparam>
    /// <param name="action"> <see cref="Action{T}" /> 类型的方法委托。 </param>
    /// <param name="arg"> <typeparamref name="T" /> 类型参数。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Action{T}" />
    /// <seealso cref="Result" />
    Result Invoke<T>(Action<T> action, T arg);

    /// <summary> 执行 <paramref name="action" /> 方法。 </summary>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <param name="action"> <see cref="Action{T1, T2}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型参数。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型参数。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Action{T1, T2}" />
    /// <seealso cref="Result" />
    Result Invoke<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2);

    /// <summary> 执行 <paramref name="action" /> 方法。 </summary>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <typeparam name="T3"> 参数类型。 </typeparam>
    /// <param name="action"> <see cref="Action{T1, T2, T3}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型参数。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型参数。 </param>
    /// <param name="arg3"> <typeparamref name="T3" /> 类型参数。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Action{T1, T2, T3}" />
    /// <seealso cref="Result" />
    Result Invoke<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3);

    /// <summary> 执行 <paramref name="action" /> 方法。 </summary>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <typeparam name="T3"> 参数类型。 </typeparam>
    /// <typeparam name="T4"> 参数类型。 </typeparam>
    /// <param name="action"> <see cref="Action{T1, T2, T3, T4}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型参数。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型参数。 </param>
    /// <param name="arg3"> <typeparamref name="T3" /> 类型参数。 </param>
    /// <param name="arg4"> <typeparamref name="T4" /> 类型参数。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Action{T1, T2, T3, T4}" />
    /// <seealso cref="Result" />
    Result Invoke<T1, T2, T3, T4>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

    /// <summary> 执行 <paramref name="action" /> 方法。 </summary>
    /// <typeparam name="T1"> 参数类型。 </typeparam>
    /// <typeparam name="T2"> 参数类型。 </typeparam>
    /// <typeparam name="T3"> 参数类型。 </typeparam>
    /// <typeparam name="T4"> 参数类型。 </typeparam>
    /// <typeparam name="T5"> 参数类型。 </typeparam>
    /// <param name="action"> <see cref="Action{T1, T2, T3, T4, T5}" /> 类型的方法委托。 </param>
    /// <param name="arg1"> <typeparamref name="T1" /> 类型参数。 </param>
    /// <param name="arg2"> <typeparamref name="T2" /> 类型参数。 </param>
    /// <param name="arg3"> <typeparamref name="T3" /> 类型参数。 </param>
    /// <param name="arg4"> <typeparamref name="T4" /> 类型参数。 </param>
    /// <param name="arg5"> <typeparamref name="T5" /> 类型参数。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Action{T1, T2, T3, T4, T5}" />
    /// <seealso cref="Result" />
    Result Invoke<T1, T2, T3, T4, T5>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

    #endregion Methods
  }

  #endregion Interfaces
}