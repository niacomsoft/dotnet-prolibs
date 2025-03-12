/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;

namespace Niacomsoft.ProductiveLibrary.Net
{
  /// <summary> 提供了网络通信端口号相关的方法。 </summary>
  public readonly struct Port
  {
    #region Constants

    private const int MAX_VALUE = 0xFFFF;

    private const int MIN_VALUE = 0;

    #endregion Constants

    #region Fields

    /// <summary> 应用程序默认暴露的网络端口号基础值 <c> 60000 </c>。 </summary>
    public static readonly Port ApplicationBaseValue = new Port(0xEA60);

    /// <summary> 默认的 HTTP 端口号 <c> 80 </c>。 </summary>
    public static readonly Port HTTP = new Port(0x50);

    /// <summary> 默认的 HTTPS 端口号 <c> 443 </c>。 </summary>
    public static readonly Port HTTPS = new Port(0x1BB);

    /// <summary> 最大端口号。 </summary>
    public static readonly Port MaximumValue = new Port(MAX_VALUE);

    /// <summary> 最小的端口号。 </summary>
    public static readonly Port MinimumValue = new Port(MIN_VALUE);

    /// <summary> MongoDB 默认通信端口号 <c> 27017 </c>。 </summary>
    public static readonly Port MongoDB = new Port(0x69E3);

    /// <summary> MQTT 默认通信端口号 <c> 1883 </c>。 </summary>
    public static readonly Port MQTT = new Port(0x75B);

    /// <summary> MySQL 默认通信端口号。 </summary>
    public static readonly Port MySQL = new Port(0xCEA);

    /// <summary> PostgreSQL 默认通信端口号。 </summary>
    public static readonly Port PostgreSQL = new Port(0x1538);

    /// <summary> RabbitMQ 默认通信端口号 <c> 5672 </c>。 </summary>
    public static readonly Port RabbitMQ = new Port(0x1628);

    /// <summary> Redis 默认通信端口 <c> 6379 </c>。 </summary>
    public static readonly Port Redis = new Port(0x18EB);

    /// <summary> Microsoft SQL Server 默认通信端口 <c> 1443 </c>。 </summary>
    public static readonly Port SQLServer = new Port(0x5A3);

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="Port" /> 类型值的新实例。 </summary>
    /// <param name="value"> 网络通信端口号数值。 </param>
    /// <exception cref="ArgumentOutOfRangeException">
    ///   当 <paramref name="value" /> &lt; 0 或 <paramref name="value" /> &gt; 65535 时，将引发此类型的异常。
    /// </exception>
    public Port(int value)
    {
      if (AssertUtilities.LessThan(value, MIN_VALUE) || AssertUtilities.GreaterThan(value, MAX_VALUE))
      {
        throw new ArgumentOutOfRangeException(nameof(value), value, SR.Format(nameof(Strings.ArgumentOutOfRangeException_with_argument_name_and_range), nameof(Port), "0 <= Port <= 65535"));
      }

      Value = value;
    }

    #endregion Constructors

    #region Properties

    /// <summary> 网络通信端口号数值。 </summary>
    /// <value> 获取 <see cref="int" /> 类型的值，用于表示网络通信端口号数值。 </value>
    public int Value { get; }

    #endregion Properties

    /// <summary> 重载的 <c> - </c> 运算。 </summary>
    /// <param name="a"> <see cref="Port" /> 类型的值。 </param>
    /// <param name="b"> <see cref="Port" /> 类型的值 </param>
    /// <returns> <see cref="Port" /> 类型的值 </returns>
    public static Port operator -(Port a, Port b)
    {
      return new Port(a.Value + b.Value);
    }

    /// <summary> 重载的 <c> + </c> 运算。 </summary>
    /// <param name="a"> <see cref="Port" /> 类型的值。 </param>
    /// <param name="b"> <see cref="Port" /> 类型的值 </param>
    /// <returns> <see cref="Port" /> 类型的值 </returns>
    public static Port operator +(Port a, Port b)
    {
      return new Port(a.Value - b.Value);
    }
  }
}