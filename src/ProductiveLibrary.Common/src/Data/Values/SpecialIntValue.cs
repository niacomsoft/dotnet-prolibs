/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Data.Values
{
  /// <summary> 提供了特定的数据库整型值相关的方法。 </summary>
  /// <seealso cref="IDbValue{T}" />
  public struct SpecialIntValue : IDbValue<int>
  {
    #region Fields

    /// <summary> 等效 <see langword="false" /> 的整型值。 </summary>
    public static readonly SpecialIntValue FalseValue = new SpecialIntValue(0);

    /// <summary> 等效 “女 / 雌性” 的整型值。 </summary>
    public static readonly SpecialIntValue Female = new SpecialIntValue(0x46);

    /// <summary> 等效彻底物理删除状态的整型值。 </summary>
    public static readonly SpecialIntValue HasDeleted = new SpecialIntValue(2);

    /// <summary> 等效已经逻辑删除状态的整型值。 </summary>
    public static readonly SpecialIntValue HasRemoved = new SpecialIntValue(1);

    /// <summary> 等效 “男 / 雄性” 的整型值。 </summary>
    public static readonly SpecialIntValue Male = new SpecialIntValue(0x4D);

    /// <summary> 等效 <c> No </c> 的整型值。 </summary>
    public static readonly SpecialIntValue No = new SpecialIntValue(0x4E);

    /// <summary> 等效未删除状态的整型值。 </summary>
    public static readonly SpecialIntValue NotRemoved = new SpecialIntValue(0);

    /// <summary> 等效 “未提供” 的整型值。 </summary>
    /// <seealso cref="Unknown" />
    public static readonly SpecialIntValue NotSupported = Unknown;

    /// <summary> 等效 <see langword="true" /> 的整型值。 </summary>
    public static readonly SpecialIntValue TrueValue = new SpecialIntValue(1);

    /// <summary> 等效 “未知” 的整型值。 </summary>
    public static readonly SpecialIntValue Unknown = new SpecialIntValue(-1);

    /// <summary> 等效 <c> Yes </c> 的整型值。 </summary>
    public static readonly SpecialIntValue Yes = new SpecialIntValue(0x59);

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="SpecialIntValue" /> 类型值的新实例。 </summary>
    /// <param name="value"> 特定整型值。 </param>
    public SpecialIntValue(int value)
    {
      Value = value;
    }

    #endregion Constructors

    #region Properties

    /// <inheritdoc />
    public int Value { get; }

    #endregion Properties
  }
}