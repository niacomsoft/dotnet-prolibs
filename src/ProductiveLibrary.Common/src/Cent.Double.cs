/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary
{
  public partial struct Cent
  {
    #region Methods

    /// <summary> 从元 <paramref name="value" /> 值转换为 <see cref="Cent" /> 类型的值。 </summary>
    /// <param name="value"> 代表元。 </param>
    /// <returns> <see cref="Cent" /> 类型的值。 </returns>
    public static Cent FromJiao(double value)
    {
      return new Cent(value, CurrencyUnit.Yuan);
    }

    /// <summary> 从角 <paramref name="value" /> 值转换为 <see cref="Cent" /> 类型的值。 </summary>
    /// <param name="value"> 代表角。 </param>
    /// <returns> <see cref="Cent" /> 类型的值。 </returns>
    public static Cent FromYuan(double value)
    {
      return new Cent(value, CurrencyUnit.Jiao);
    }

    #endregion Methods
  }
}