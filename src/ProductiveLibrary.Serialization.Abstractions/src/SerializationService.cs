/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.IO;

namespace Niacomsoft.ProductiveLibrary.Runtime.Serialization
{
  /// <summary> 提供了运行时数据序列化相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <seealso cref="ISerializationService" />
  public abstract class SerializationService : ISerializationService
  {
    #region Methods

    /// <summary>
    ///   序列化 <paramref name="source" /> 到流 <paramref name="serializationStream" /> 中。
    /// </summary>
    /// <param name="source"> 需要序列化的对象实例。 </param>
    /// <param name="serializationStream">
    ///   目标流。
    ///   <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
    /// </param>
    /// <seealso cref="Stream" />
    protected abstract void SerializeImpl(object source, Stream serializationStream);

    /// <inheritdoc />
    public abstract T Deserialize<T>(byte[] input, int? offset = null, int? length = null) where T : class, new();

    /// <inheritdoc />
    public abstract T Deserialize<T>(Stream deserializationStream) where T : class, new();

    /// <inheritdoc />
    public abstract object Deserialize(Type type, byte[] input, int? offset = null, int? length = null);

    /// <inheritdoc />
    public abstract object Deserialize(Type type, Stream deserializationStream);

    /// <inheritdoc />
    public abstract byte[] Serialize(object source);

    /// <inheritdoc />
    /// <exception cref="ArgumentException">
    ///   当 <paramref name="source" /> 不是一个引用类型参数时，将引发此类型的异常。
    /// </exception>
    public virtual void Serialize(object source, Stream serializationStream)
    {
      if (AssertUtilities.IsNull(source)) return;

      if (!source.GetType().IsClass)
      {
        throw new ArgumentException(SR.Format(nameof(Strings.ArgumentException_invalid_typed_arguments), nameof(source)), nameof(source));
      }

      if (AssertUtilities.IsNull(serializationStream))
      {
        throw new ArgumentNullException(nameof(serializationStream), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(serializationStream)));
      }

      SerializeImpl(source, serializationStream);
    }

    /// <inheritdoc />
    public abstract byte[] Serialize<T>(T source) where T : class, new();

    /// <inheritdoc />
    public abstract void Serialize<T>(T source, Stream serializationStream) where T : class, new();

    #endregion Methods
  }
}