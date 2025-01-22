/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了描述运行时异常信息相关的基本方法。 </summary>
  [Serializable]
  public class ExceptionInfo
  {
    #region Constructors

    /// <summary> 初始化 <see cref="ExceptionInfo" /> 类的新实例。 </summary>
    public ExceptionInfo()
    {
    }

    /// <summary> 初始化 <see cref="ExceptionInfo" /> 类的新实例。 </summary>
    /// <param name="exception"> 运行时异常。 </param>
    public ExceptionInfo(Exception exception) : this()
    {
      CurrentException = exception;
      Initialize();
    }

    #endregion Constructors

    #region Properties

    /// <summary> 当前的异常。 </summary>
    /// <value> 设置或获取 <see cref="Exception" /> 类型的对象实例，用于表示当前的异常。 </value>
    protected virtual Exception CurrentException { get; set; }

    /// <summary>
    ///   包含了程序集版本信息的完整异常描述名称。
    ///   <para> <see cref="Type.AssemblyQualifiedName" /> </para>
    /// </summary>
    /// <value> 设置或获取一个字符串，用于表示包含了程序集版本信息的完整异常描述名称。 </value>
    public virtual string FullName { get; set; }

    /// <summary> 介绍运行时异常的文档 URL 链接地址。 </summary>
    /// <value> 设置或获取一个字符串，用于表示介绍运行时异常的文档 URL 链接地址。 </value>
    public virtual string HelpUrl { get; set; }

    /// <summary> 引发当前异常的异常描述信息。 </summary>
    /// <value> 设置或获取 <see cref="ExceptionInfo" /> 类型的数组，用于表示引发当前异常的异常描述信息。 </value>
    public virtual ExceptionInfo[] InnerExceptions { get; set; }

    /// <summary> 描述异常的信息。 </summary>
    /// <value> 设置或获取一个字符串，用于表示描述异常的信息。 </value>
    public virtual string Message { get; set; }

    /// <summary>
    ///   异常描述名称。
    ///   <para> <see cref="Type.FullName" /> </para>
    /// </summary>
    /// <value> 设置或获取一个字符串，用于表示异常描述名称。 </value>
    public virtual string Name { get; set; }

    /// <summary> 导致运行时异常的应用程序或对象名称。 </summary>
    /// <value> 设置或获取一个字符串，用于表示导致运行时异常的应用程序或对象名称。 </value>
    public virtual string Source { get; set; }

    /// <summary> 导致运行时异常的堆栈描述信息。 </summary>
    /// <value> 设置或获取一个字符串，用于表示导致运行时异常的堆栈描述信息。 </value>
    public virtual string StackTrace { get; set; }

    /// <summary> 导致运行时异常的方法信息。 </summary>
    /// <value> 设置或获取一个字符串，用于表示导致运行时异常的方法信息。 </value>
    public virtual string Target { get; set; }

    #endregion Properties

    #region Methods

    /// <summary> 初始化。 </summary>
    protected virtual void Initialize()
    {
      var exceptionType = CurrentException.GetType();
      Name = exceptionType.FullName;
      FullName = exceptionType.AssemblyQualifiedName;
      Source = CurrentException.Source;
      StackTrace = CurrentException.StackTrace;
      if (CurrentException.TargetSite.NotNull())
      {
        Target = $"{CurrentException.TargetSite.DeclaringType?.FullName.GetSafeString().GetDefaultIfWhiteSpace("~")}::{CurrentException.TargetSite.Name}<{CurrentException.TargetSite.MemberType}>";
      }
      Message = CurrentException.Message;
      HelpUrl = CurrentException.HelpLink;
      if (CurrentException.Is<AggregateException>() && CurrentException.As<AggregateException>().InnerExceptions.NotNull())
      {
        InnerExceptions = InitializeInnerExceptions(CurrentException.As<AggregateException>().InnerExceptions).ToArray();
      }
      else if (CurrentException.InnerException.NotNull())
      {
        InnerExceptions = InitializeInnerExceptions(new Exception[1] { CurrentException.InnerException }).ToArray();
      }
    }

    /// <summary> 初始化内部异常。 </summary>
    /// <param name="innerExceptions"> <see cref="Exception" /> 类型的数组或集合。 </param>
    /// <returns> <see cref="ExceptionInfo" /> 类型的数组。 </returns>
    protected virtual IEnumerable<ExceptionInfo> InitializeInnerExceptions(IEnumerable<Exception> innerExceptions)
    {
      foreach (var item in innerExceptions)
      {
        yield return new ExceptionInfo(item);
      }
    }

    /// <summary> 创建描述 <paramref name="error" /> 的描述信息。 </summary>
    /// <param name="error"> <see cref="Exception" /> 类型的对象实例。 </param>
    /// <returns> <see cref="ExceptionInfo" /> 类型的对象实例。 </returns>
    /// <seealso cref="Exception" />
    public static ExceptionInfo FromException(Exception error) => new ExceptionInfo(error);

    #endregion Methods
  }
}