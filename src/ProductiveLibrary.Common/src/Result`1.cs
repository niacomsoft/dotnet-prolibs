/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了包含 <typeparamref name="T" /> 类型结果值的方法执行结果相关的基本方法。 </summary>
  /// <typeparam name="T"> 方法返回值类型。 </typeparam>
  /// <seealso cref="Result" />
  public class Result<T> : Result
  {
    #region Constructors

    /// <summary> 初始化 <see cref="Result{T}" /> 类的新实例。 </summary>
    public Result()
    {
      Value = default;
    }

    /// <summary> 初始化 <see cref="Result{T}" /> 类的新实例。 </summary>
    /// <param name="completed"> 方法是否执行成功。 </param>
    /// <param name="failureReason"> 方法执行失败原因。 </param>
    public Result(bool completed, MethodFailedReason? failureReason) : base(completed, failureReason)
    {
      Value = default;
    }

    /// <summary> 初始化 <see cref="Result{T}" /> 类的新实例。 </summary>
    /// <param name="error"> 运行时异常。 </param>
    public Result(Exception error) : base(error)
    {
      Value = default;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 方法返回值结果。 </summary>
    /// <value> 获取 <typeparamref name="T" /> 类型的值或对象实例，用于表示方法返回值结果。 </value>
    public virtual T Value { get; set; }

    #endregion Properties

    #region Methods

    /// <summary> 创建一个完成状态的结果。 </summary>
    /// <param name="value"> 方法返回值。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    public static Result<T> Complete(T value)
    {
      return new Result<T>() { Value = value };
    }

    /// <summary> 创建一个失败状态的结果。 </summary>
    /// <param name="failedReason"> 方法执行失败原因。 </param>
    /// <returns> <see cref="Result{T}" /> 类型的对象实例。 </returns>
    /// <seealso cref="MethodFailedReason" />
    public new static Result<T> Fail(MethodFailedReason failedReason = MethodFailedReason.None)
    {
      return new Result<T>(false, failedReason);
    }

    /// <summary> 创建一个包含运行时异常的结果。 </summary>
    /// <param name="error"> 运行时异常。 </param>
    /// <returns> <see cref="Result{T}" /> 类型的对象实例。 </returns>
    /// <seealso cref="Exception" />
    public new static Result<T> WhenCatched(Exception error)
    {
      return new Result<T>(error);
    }

    #endregion Methods
  }
}