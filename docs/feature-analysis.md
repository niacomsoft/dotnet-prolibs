# 功能分析 Features Analysis

- 应用程序公共模块 **Common Application Block**

   > 命名空间 (*Root Namespace*) - `Niacomsoft.ProductiveLibrary.*`
   >
   > 程序集名称 (*Assembly Name*) - `ProLib.*`
   >
   > NuGet 包名称 (Package Name) - `{AssemblyName}`
   
   - **多语言支持资源包 Multilingual Resources Pack**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Resources`
     - 程序集名称 *Assembly Name*: `ProLib.Resources`
   - **公共类库 Common**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary`
     - 程序集名称 *Assembly Name*: `ProLib.Common`
   - **公共扩展类库 Extensions**
     - 命名空间 *Namespace*: **System or Microsoft and etc.**
     - 程序集名称 *Assembly Name*: `ProLib.Common.Extensions`
   - **运行时日志抽象 Runtime Logging Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Diagnostics`
     - 程序集名称 *Assembly Name*: `ProLib.Logging.Abstractions`
   - **运行时日志实现 Runtime Logging** (*Microsoft.Extensions.Logging*)
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Diagnostics`
     - 程序集名称 *Assembly Name*: `ProLib.Logging.MicrosoftLogging`
   - **运行时日志实现 Runtime Logging** (*NLog*)
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Diagnostics`
     - 程序集名称 *Assembly Name*: `ProLib.Logging.NLog`
     - 其他依赖项目 *Other Dependent*
       - `ProLibrary.Logging.NLog.Shared`：**Shared Project for NLog Configuration**
