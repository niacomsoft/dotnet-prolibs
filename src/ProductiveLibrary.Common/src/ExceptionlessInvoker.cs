/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了无异常抛出的方法调用相关的基本方法。 </summary>
  /// <seealso cref="IExceptionlessInvoker" />
  public class ExceptionlessInvoker : IExceptionlessInvoker
  {
    #region Methods

    /// <inheritdoc />
    public virtual Result Invoke(Action action)
    {
      try
      {
        action?.Invoke();
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
      return Result.Done();
    }

    /// <inheritdoc />
    public virtual Result Invoke<T>(Action<T> action, T arg)
    {
      try
      {
        action(arg);
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
      return Result.Done();
    }

    /// <inheritdoc />
    public virtual Result Invoke<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
      try
      {
        action(arg1, arg2, arg3, arg4, arg5);
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
      return Result.Done();
    }

    /// <inheritdoc />
    public virtual Result Invoke<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
      try
      {
        action(arg1, arg2, arg3, arg4);
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
      return Result.Done();
    }

    /// <inheritdoc />
    public virtual Result Invoke<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
    {
      try
      {
        action(arg1, arg2, arg3);
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
      return Result.Done();
    }

    /// <inheritdoc />
    public virtual Result Invoke<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
    {
      try
      {
        action(arg1, arg2);
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
      return Result.Done();
    }

    /// <inheritdoc />
    public virtual Result<TResult> Invoke<TResult, T>(Func<T, TResult> func, T arg)
    {
      try
      {
        return Result<TResult>.Done(func(arg));
      }
      catch (Exception error)
      {
        return Result<TResult>.FromException(error);
      }
    }

    /// <inheritdoc />
    public virtual Result<TResult> Invoke<TResult, T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
    {
      try
      {
        return Result<TResult>.Done(func(arg1, arg2, arg3, arg4, arg5));
      }
      catch (Exception error)
      {
        return Result<TResult>.FromException(error);
      }
    }

    /// <inheritdoc />
    public virtual Result<TResult> Invoke<TResult, T1, T2, T3, T4>(Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
      try
      {
        return Result<TResult>.Done(func(arg1, arg2, arg3, arg4));
      }
      catch (Exception error)
      {
        return Result<TResult>.FromException(error);
      }
    }

    /// <inheritdoc />
    public virtual Result<TResult> Invoke<TResult, T1, T2, T3>(Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3)
    {
      try
      {
        return Result<TResult>.Done(func(arg1, arg2, arg3));
      }
      catch (Exception error)
      {
        return Result<TResult>.FromException(error);
      }
    }

    /// <inheritdoc />
    public virtual Result<TResult> Invoke<TResult, T1, T2>(Func<T1, T2, TResult> func, T1 arg1, T2 arg2)
    {
      try
      {
        return Result<TResult>.Done(func(arg1, arg2));
      }
      catch (Exception error)
      {
        return Result<TResult>.FromException(error);
      }
    }

    /// <inheritdoc />
    public virtual Result<TResult> Invoke<TResult>(Func<TResult> func)
    {
      try
      {
        return Result<TResult>.Done(func());
      }
      catch (Exception error)
      {
        return Result<TResult>.FromException(error);
      }
    }

    /// <inheritdoc />
    public virtual Result Invoke(RestAction action, params object[] args)
    {
      try
      {
        action(args);
      }
      catch (Exception error)
      {
        return Result.FromException(error);
      }
      return Result.Done();
    }

    /// <inheritdoc />
    public virtual Result<TResult> Invoke<TResult>(RestFunction<TResult> func, params object[] args)
    {
      try
      {
        return Result<TResult>.Done(func(args));
      }
      catch (Exception error)
      {
        return Result<TResult>.FromException(error);
      }
    }

    #endregion Methods
  }
}