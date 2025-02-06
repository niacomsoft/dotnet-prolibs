/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Diagnostics
{
  /// <summary> 提供了诊断源头分类相关的方法。 </summary>
  public readonly struct DiagnosticsSourceCategory
  {
    #region Fields

    /// <summary> 共用应用程序模块。 </summary>
    public static readonly DiagnosticsSourceCategory Common = new DiagnosticsSourceCategory("DOTNET:PROD:COMMON");

    #endregion Fields

    #region Constructors

    /// <summary> 初始化 <see cref="DiagnosticsSourceCategory" /> 类型值的新实例。 </summary>
    /// <param name="category"> 源头类别名称。 </param>
    public DiagnosticsSourceCategory(string category)
    {
      Category = category.ToUpper().Trim();
    }

    #endregion Constructors

    #region Properties

    /// <summary> 源头类别名称。 </summary>
    /// <value> 获取一个字符串，用于表示源头类别名称。 </value>
    public string Category { get; }

    #endregion Properties

    #region Methods

    /// <summary> 返回诊断源头类别名称 <see cref="Category" />。 </summary>
    /// <returns> <see cref="Category" />。 </returns>
    public override string ToString() => Category;

    #endregion Methods
  }
}