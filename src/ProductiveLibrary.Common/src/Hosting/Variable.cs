/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary.Hosting
{
  /// <summary> 提供了环境变量信息相关的方法。 </summary>
  public struct Variable
  {
    #region Fields

    private readonly EnvironmentVariableTarget _location;

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="Variable" /> 类型值的新实例。 </summary>
    /// <param name="name"> 环境变量名称。 </param>
    public Variable(string name) : this()
    {
      Name = name;
    }

    /// <summary> 初始化 <see cref="Variable" /> 类型值的新实例。 </summary>
    /// <param name="name"> 环境变量名称。 </param>
    /// <param name="value"> 环境变量值。 </param>
    /// <param name="location"> 检索到环境变量的位置。 </param>
    public Variable(string name, string value, EnvironmentVariableTarget location) : this(name)
    {
      Name = name;
      Value = value;
      _location = location;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 环境变量是否有值。 </summary>
    /// <value> 获取 <see cref="bool" /> 类型的值，用于表示环境变量是否有值。 </value>
    public bool HasValue => !AssertUtilities.NotEmpty(Value);

    /// <summary>
    ///   检索到环境变量 <see cref="Name" /> 的位置。
    ///   <para> 当未找到环境变量时，此属性为 <see langword="null" /> 值。 </para>
    /// </summary>
    /// <value>
    ///   获取可能为空的 <see cref="EnvironmentVariableTarget" /> 类型值，用于表示检索到环境变量 <see cref="Name" /> 的位置。
    /// </value>
    /// <seealso cref="EnvironmentVariableTarget" />
    public EnvironmentVariableTarget? Location
    {
      get
      {
        return HasValue ? _location : null as EnvironmentVariableTarget?;
      }
    }

    /// <summary> 环境变量名称。 </summary>
    /// <value> 获取一个字符串，用于表示环境变量名称。 </value>
    public string Name { get; }

    /// <summary> 环境变量值。 </summary>
    /// <value> 获取一个字符串，用于表示环境变量值。 </value>
    public string Value { get; }

    #endregion Properties

    #region Methods

    /// <summary>
    ///   当 <see cref="HasValue" /> 等于 <see langword="true" /> 时返回 <see cref="Value" /> 否则返回
    ///   <paramref name="default" />。
    /// </summary>
    /// <param name="default">
    ///   当 <see cref="HasValue" /> 等于 <see langword="false" /> 时需要返回的默认值。
    /// </param>
    /// <returns> 环境变量值。 </returns>
    public string GetValueOrDefault(string @default)
    {
      return Guard.DefaultIfEmpty(Value, @default);
    }

    #endregion Methods
  }
}