/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了包含 <typeparamref name="TResult" /> 类型返回值的返回结果相关的基本方法。 </summary>
  /// <typeparam name="TResult"> 返回结果类型。 </typeparam>
  /// <seealso cref="Result" />
  public class Result<TResult> : Result
  {
    #region Constructors

    /// <summary> 初始化 <see cref="Result{TResult}" /> 类的新实例。 </summary>
    public Result()
    {
    }

    /// <summary> 初始化 <see cref="Result{TResult}" /> 类的新实例。 </summary>
    /// <param name="error"> 方法执行过程中抛出的异常。 </param>
    public Result(Exception error) : base(error)
    {
    }

    /// <summary> 初始化 <see cref="Result{TResult}" /> 类的新实例。 </summary>
    /// <param name="value"> <typeparamref name="TResult" /> 类型的返回值。 </param>
    public Result(TResult value)
    {
      Value = value;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 返回值。 </summary>
    /// <value> 设置或获取 <typeparamref name="TResult" /> 类型的值或对象实例，用于表示返回值。 </value>
    public virtual TResult Value { get; set; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   新建一个 <typeparamref name="TResult" /> 类型结果值的 <see cref="Result{TResult}" /> 类型的对象实例。
    /// </summary>
    /// <param name="value"> 返回值结果。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    public static Result<TResult> Complete(TResult value) => new Result<TResult>(value);

    /// <summary> 新建一个包含运行时异常的 <see cref="Result{TResult}" /> 类型的对象实例。 </summary>
    /// <param name="error"> 运行时异常。 </param>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    public new static Result<TResult> Failed(Exception error) => new Result<TResult>(error);

    /// <summary> 新建一个 <see cref="Result{TResult}" /> 类型的对象实例。 </summary>
    /// <returns> <see cref="Result{TResult}" /> 类型的对象实例。 </returns>
    public static Result<TResult> New() => new Result<TResult>();

    #endregion Methods
  }
}