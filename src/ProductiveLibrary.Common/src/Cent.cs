/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  /// <summary> 提供了货币 “分” 相关的方法。 </summary>
  public readonly partial struct Cent
  {
    #region Fields

    /// <summary> 用于表示免费。 </summary>
    public static readonly Cent Free = new Cent(0);

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="Cent" /> 类型值的新实例。 </summary>
    /// <param name="value"> 货币数值。 </param>
    /// <param name="unit"> 货币单位。 </param>
    public Cent(double value, CurrencyUnit unit) : this((long)value, unit)
    {
    }

    /// <summary> 初始化 <see cref="Cent" /> 类型值的新实例。 </summary>
    /// <param name="value"> 以分为单位的货币值。 </param>
    public Cent(long value)
    {
      Value = value;
    }

    /// <summary> 初始化 <see cref="Cent" /> 类型值的新实例。 </summary>
    /// <param name="value"> 货币数值。 </param>
    /// <param name="unit"> 货币单位。 </param>
    public Cent(long value, CurrencyUnit unit) : this(value * (int)unit)
    {
    }

    #endregion Constructors

    #region Properties

    /// <summary> 表示货币 “分”。 </summary>
    /// <value> 获取 <see cref="long" /> 类型的值，用于表示货币 “分”。 </value>
    public long Value { get; }

    #endregion Properties

    #region Methods

    /// <summary> 获取 <see cref="Value" /> 等效的值。 </summary>
    /// <param name="unit">
    ///   货币单位。
    ///   <para> <see cref="CurrencyUnit" /> 枚举类型中的一个值。 </para>
    /// </param>
    /// <returns> 等效的值。 </returns>
    /// <seealso cref="CurrencyUnit" />
    public double GetValue(CurrencyUnit unit = CurrencyUnit.Default)
    {
      return Value / (int)unit;
    }

    /// <summary> 获取分等效的以“元”为单位的字符串。 </summary>
    /// <returns> 以元为单位的字符串。 </returns>
    public override string ToString()
    {
      return ToString(true, 2);
    }

    /// <summary> 获取分等效的以“元”为单位的字符串。 </summary>
    /// <param name="useThousands"> 是否启用千分符进行分割。 </param>
    /// <param name="precision"> 小数点后保留位数。 </param>
    /// <returns> 以元为单位的字符串。 </returns>
    public string ToString(bool useThousands, int precision)
    {
      return (useThousands) ? GetValue().ToString($"N{precision}") : GetValue().ToString($"F{precision}");
    }

    #endregion Methods
  }
}