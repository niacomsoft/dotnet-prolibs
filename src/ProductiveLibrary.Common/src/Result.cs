/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了无返回值方法结果相关的基本方法。 </summary>
  public class Result
  {
    #region Constructors

    /// <summary> 初始化 <see cref="Result" /> 类的新实例。 </summary>
    public Result()
    {
    }

    /// <summary> 初始化 <see cref="Result" /> 类的新实例。 </summary>
    /// <param name="error"> 方法执行过程中抛出的异常。 </param>
    public Result(Exception error)
    {
      Error = error;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 方法执行过程中抛出的异常。 </summary>
    /// <value> 获取 <see cref="Exception" /> 类型的对象实例，用于表示方法执行过程中抛出的异常。 </value>
    /// <seealso cref="Exception" />
    public virtual Exception Error { get; }

    /// <summary>
    ///   方法执行过程中是否抛出了异常。
    ///   <para>
    ///     当 <see cref="Error" /> 不等于 <see langword="null" /> 时，返回 <see langword="true" />；否则返回
    ///     <see langword="false" /> 。
    ///   </para>
    /// </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示方法执行过程中是否抛出了异常。 </value>
    public virtual bool HasError => Error.NotNull();

    #endregion Properties

    #region Methods

    /// <summary> 方法完成。 </summary>
    /// <returns> <see cref="Complete" /> 类型的对象实例。 </returns>
    public static Result Complete() => new Result();

    /// <summary> 方法失败。 </summary>
    /// <param name="error"> 方法执行过程中抛出的异常 </param>
    /// <returns> <see cref="Complete" /> 类型的对象实例。 </returns>
    /// <seealso cref="Exception" />
    public static Result Failed(Exception error) => new Result(error);

    #endregion Methods
  }
}