/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了方法结果相关的基本方法。 </summary>
  [Serializable]
  public class Result
  {
    #region Constructors

    /// <summary> 初始化 <see cref="Result" /> 类的新实例。 </summary>
    public Result()
    {
      Completed = true;
      Error = null;
      FailureReason = MethodFailedReason.None;
    }

    /// <summary> 初始化 <see cref="Result" /> 类的新实例。 </summary>
    /// <param name="completed"> 方法是否执行成功。 </param>
    /// <param name="failureReason"> 方法执行失败原因。 </param>
    public Result(bool completed, MethodFailedReason? failureReason = null) : this()
    {
      Completed = completed;
      FailureReason = failureReason ?? MethodFailedReason.None;
    }

    /// <summary> 初始化 <see cref="Result" /> 类的新实例。 </summary>
    /// <param name="error"> 运行时异常。 </param>
    public Result(Exception error) : this()
    {
      if (AssertUtilities.NotNull(Error = error))
      {
        Completed = false;
        FailureReason = MethodFailedReason.Exception;
      }
    }

    #endregion Constructors

    #region Properties

    /// <summary> 是否执行成功。 </summary>
    /// <value> 设置或获取 <see cref="bool" /> 类型的值，用于表示是否执行成功。 </value>
    public virtual bool Completed { get; set; }

    /// <summary> 运行时异常。 </summary>
    /// <value> 设置或获取 <see cref="Exception" /> 类型的对象实例，用于表示运行时异常。 </value>
    /// <seealso cref="Exception" />
    public virtual Exception Error { get; set; }

    /// <summary>
    ///   失败原因。
    ///   <para> <see cref="MethodFailedReason" /> 枚举类型中的一个或多个值。 </para>
    /// </summary>
    /// <value> 设置或获取 <see cref="MethodFailedReason" /> 类型的值，用于表示失败原因。 </value>
    /// <seealso cref="MethodFailedReason" />
    public virtual MethodFailedReason FailureReason { get; set; }

    /// <summary> 方法执行过程中是否抛出了异常。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示方法执行过程中是否抛出了异常。 </value>
    public virtual bool HasError => AssertUtilities.NotNull(Error);

    #endregion Properties

    #region Methods

    /// <summary> 创建一个完成状态的结果。 </summary>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    public static Result Complete()
    {
      return new Result();
    }

    /// <summary> 创建一个失败状态的结果。 </summary>
    /// <param name="failedReason"> 方法执行失败原因。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="MethodFailedReason" />
    public static Result Fail(MethodFailedReason failedReason = MethodFailedReason.None)
    {
      return new Result(false, failedReason);
    }

    /// <summary> 创建一个包含运行时异常的结果。 </summary>
    /// <param name="error"> 运行时异常。 </param>
    /// <returns> <see cref="Result" /> 类型的对象实例。 </returns>
    /// <seealso cref="Exception" />
    public static Result WhenCatched(Exception error)
    {
      return new Result(error);
    }

    #endregion Methods
  }
}