# 功能分析 Features Analysis

- 应用程序公共模块 **Common Application Block**

   > 命名空间 (*Root Namespace*) - `Niacomsoft.ProductiveLibrary.*`
   >
   > 程序集名称 (*Assembly Name*) - `ProductiveLibrary.*`
   >
   > NuGet 包名称 (Package Name) - `{AssemblyName}`
   
   - **[多语言支持资源包 Multilingual Resources Pack](../src/ProductiveLibrary.Resources/src/README.md)**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Resources`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Resources`
   - **公共类库 Common**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Common`
   - **公共扩展类库 Extensions**
     - 命名空间 *Namespace*: **System or Microsoft and etc.**
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Common.Extensions`
   - **ID 生成器抽象 ID Generator Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IDGenerator.Abstractions`
   - **.NET 内置的 ID 生成器 ID Generator**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IDGenerator`
   - **ULID 生成器 ULID Generator**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IDGenerator.Ulid`
   - **NanoID 生成器 NanoID Generator**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IDGenerator.NanoId`
   - **运行时序列化抽象 Runtime Serialization Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.Abstractions`
   - **运行时日志抽象 Runtime Logging Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Diagnostics`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Logging.Abstractions`
   - **运行时日志实现 Runtime Logging** (*Microsoft.Extensions.Logging*)
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Diagnostics`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Logging.Microsoft`
   - **运行时日志实现 Runtime Logging** (*NLog*)
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Diagnostics`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Logging.NLog`
     - 其他依赖项目 *Other Dependent*
       - `ProductiveLibrary.Logging.NLog.Shared`：**Shared Project for NLog Configuration**
   - **运行时主机环境抽象 Runtime Hosting Environment Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Hosting`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.HostingEnvironment.Abstractions`
   - **运行时主机环境 Runtime Hosting Environment** (*Microsoft.Extensions.Hosting*)
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Hosting`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.HostingEnvironment`
     - 注意事项 **Tips**
       - ✅.NET Standard 2.0 +
   - **运行时主机环境 Runtime Hosting Environment**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Hosting`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.HostingEnvironment.Classic`
       - ✅.NET Framework **Only**
   - **运行时序列化抽象 Runtime Serialization Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.Abstractions`
   - **运行时序列化 XML**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.Xml`
   - **运行时序列化 Binary**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.BinaryFormatter`
     - 注意事项 **Tips**
       - ✅.NET Framework (**Only**)
   - **运行时 JSON 序列化抽象 JSON Serialization Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.Json.Abstractions`
   - **运行时序列化 Json** (*Newtonsoft.Json*)
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.NewtonsoftJson`
   - **运行时序列化 JSON** (*System.Text.Json*)
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.SystemTextJson`
     - 注意事项 **Tips**
       - ✅.NET Standard 2.0 +
   - **运行时序列化 Yaml**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Serialization`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Serialization.Yaml`
   - **文件变更抽象 File Watcher Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.FileWatcher`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.FileWatcher.Abstractions`
   - **文件变更实现 File Watcher Basic Implements**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.FileWatcher`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.FileWatcher`
   - **配置服务抽象 Configuration Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Configuration`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Configuration.Abstractions`
   - **配置服务 ConfigurationManager Classic**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Configuration`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Configuration.ConfigurationManager`
     - 注意事项 **Tips**
       - ✅.NET Framework
   - **配置服务 Microsoft.Extensions.Configuration**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Configuration`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Configuration`
   - **数据加密服务抽象 Cryptography Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Security.Cryptography`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Security.Cryptography.Abstractions`
   - **.NET 内置的数据加密服务 Default Cryptography**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Security.Cryptography`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Security.Cryptography`
   - **密钥生成器 Password Generator**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Security`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Security.PasswordGenerator`
   - **Integer 哈希扩展 HashIds Extensions**
     - 命名空间 *Namespace*: `System.Security`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Security.Extensions.Integer`
   - **文件存储抽象 IO Storage Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.Storage`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.Storage.Abstractions`
   - **本地文件存储 Local Storage**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.Storage`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.Storage.Local`
   - **FTP 文件存储 FTP Storage**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.Storage`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.Storage.Ftp`
   - **对象存储抽象 Object Storage Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.Storage`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.Storage.ObjectStorage`
   - **阿里云 OSS 对象存储 Aliyun OSS**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.Storage`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.Storage.AliyunOSS`
   - **MinIO 对象存储**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.Storage`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.Storage.MinIO`
   - **AWS S3 对象存储 Amazon S3** 
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.IO.Storage`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.IO.Storage.AWSS3`
   - **运行时缓存抽象 Runtime Caching Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Caching`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Caching.Abstractions`
   - **运行时缓存 Runtime Caching**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Caching`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Caching`
   - **Redis 分布缓存 StackExchange.Redis**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Runtime.Caching`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Caching.StackExchangeRedis`
   - **ADO.NET 数据库访问配置选项 ADO.NET Configuration**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data.Configuration`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.Configuration`
   - **ADO.NET 数据库访问抽象 ADO.NET Abstractions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.Abstractions`
   - **ADO.NET 数据库访问 Dapper 扩展 ADO.NET Dapper Extensions**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.Extensions.Dapper`
   - **SQL Server ADO.NET 数据库访问 ADO.NET for SQL Server**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data.SqlClient`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.SqlClient`
   - **SQLite ADO.NET 数据库访问 ADO.NET for SQLite**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data.SQLite`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.SQLite`
   - **PostgreSQL ADO.NET 数据库访问 ADO.NET for PostgreSQL**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data.PostgreSQL`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.PostgreSql`
   - **MySQL ADO.NET 数据库访问 ADO.NET for MySQL (Official)**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data.MySql`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.MySql`
   - **MySQL ADO.NET 数据库访问 ADO.NET for MySQL （MySqlConnector）**
     - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Data.MySql`
     - 程序集名称 *Assembly Name*: `ProductiveLibrary.Data.MySqlConnector`
   
- Windows Form 扩展模块 **WindowsForm Application Block**

   > 命名空间 (*Root Namespace*) - `Niacomsoft.ProductiveLibrary.Extensions.Forms.*`
   >
   > 程序集名称 (*Assembly Name*) - `ProductiveLibrary.Extensions.Forms.*`
   >
   > NuGet 包名称 (Package Name) - `{AssemblyName}`

   - **启动特权抽象 Startup Privileges Abstractions**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Forms.Security.Privileges`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.Forms.Security.Privileges.Abstractions`
   - **Windows 管理员启动特权 Administrator Privileges**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Forms.Security.Privileges`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.Forms.Security.Privileges.Administrator`
   - **Linux SU 用户启动特权 SU Privileges**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Forms.Security.Privileges`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.Forms.Security.Privileges.Sudo`

- MQTT 通信客户端模块 **MQTT Communication Application Block**

   > 命名空间 (*Root Namespace*) - `Niacomsoft.ProductiveLibrary.Extensions.Messaging.MQTT.*`
   >
   > 程序集名称 (*Assembly Name*) - `ProductiveLibrary.Extensions.Messaging.MQTT.*`
   >
   > NuGet 包名称 (Package Name) - `{AssemblyName}`

   - **MQTT 客户端抽象 MQTT Communication Client Abstractions**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Messaging.MQTT`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.Messaging.MQTT.Abstractions`
   - **MQTT 客户端 MQTT Communication Client with MQTTnet**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Messaging.MQTT`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.Messaging.MQTT`
      - 注意事项 **Tips**
        - ✅.NET Standard 2.0 + (4.x)
        - ✅.NET 8 + (5+)
   - **MQTT 客户端 MQTT Communication Client with M2Mqtt**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Messaging.MQTT`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.Messaging.MQTT.M2`
      - 注意事项 **Tips**
        - ✅.NET Framework (**Only**)

- **adb.exe** 命令行工具交互 **adb.exe CommandLine Interop Application Block**

   > 命名空间 (*Root Namespace*) - `Niacomsoft.ProductiveLibrary.Extensions.Runtime.InteropServices.*`
   >
   > 程序集名称 (*Assembly Name*) - `ProductiveLibrary.Extensions.InteropServices.Adb.*`
   >
   > NuGet 包名称 (Package Name) - `{AssemblyName}`

   - **adb.exe 命令行交互抽象 Interop Abstractions**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Runtime.InteropServices`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.InteropServices.Adb.Abstractions`
   - **adb.exe 命令行交互 Interop**
      - 命名空间 *Namespace*: `Niacomsoft.ProductiveLibrary.Extensions.Runtime.InteropServices`
      - 程序集名称 *Assembly Name*: `ProductiveLibrary.Extensions.InteropServices.Adb`
