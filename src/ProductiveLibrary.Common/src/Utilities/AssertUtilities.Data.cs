/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System.Data;

namespace Niacomsoft.ProductiveLibrary.Utilities
{
  public static partial class AssertUtilities
  {
    #region Methods

    /// <summary>
    ///   当数据集 <paramref name="dataSet" /> 不等于 <see langword="null" /> 且 <c>
    ///   <paramref name="dataSet" />.Tables &gt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="dataSet">
    ///   数据集。
    ///   <para> <see cref="DataSet" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="DataSet" />
    public static bool HasData(DataSet dataSet)
    {
      return NotNull(dataSet?.Tables) && IsPositive(dataSet.Tables.Count);
    }

    /// <summary>
    ///   当数据表 <paramref name="dataTable" /> 不等于 <see langword="null" /> 且 <c>
    ///   <paramref name="dataTable" />.Rows &gt; 0 </c> 时，返回 <see langword="true" />；否则返回
    ///   <see langword="false" /> 。
    /// </summary>
    /// <param name="dataTable">
    ///   数据表。
    ///   <para> <see cref="DataTable" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <see cref="bool" /> 类型的值。 </returns>
    /// <seealso cref="DataTable" />
    public static bool HasData(DataTable dataTable)
    {
      return NotNull(dataTable?.Rows) && IsPositive(dataTable.Rows.Count);
    }

    #endregion Methods
  }
}