/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

namespace Niacomsoft.ProductiveLibrary.Hosting
{
  public static partial class HostEnvironmentUtilities
  {
#if NETFRAMEWORK

    /// <summary> .NET 框架显示名称。 </summary>
    public const string FrameworkDisplayName = ".NET Framework";

#elif NETSTANDARD

    /// <summary> .NET 框架显示名称。 </summary>
    public const string FrameworkDisplayName = ".NET Standard";

#elif NET

    /// <summary> .NET 框架显示名称。 </summary>
    public const string FrameworkDisplayName = ".NET";

#else

    /// <summary> .NET 框架显示名称。 </summary>
    public const string FrameworkDisplayName = ".NET Core";

#endif
  }
}