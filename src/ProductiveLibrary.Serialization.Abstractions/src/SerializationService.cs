/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using Niacomsoft.ProductiveLibrary.IO;
using Niacomsoft.ProductiveLibrary.Resources;
using Niacomsoft.ProductiveLibrary.Resources.Internal;
using Niacomsoft.ProductiveLibrary.Utilities;

using System;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace Niacomsoft.ProductiveLibrary.Runtime.Serialization
{
  /// <summary> 提供了运行时数据序列化相关的抽象 <see langword="abstract" /> 方法。 </summary>
  /// <seealso cref="ISerializationService" />
  public abstract class SerializationService : ISerializationService
  {
    #region Methods

    /// <summary>
    ///   从流 <paramref name="deserializationStream" /> 中反序列化得到 <paramref name="type" /> 类型的对象实例。
    /// </summary>
    /// <param name="type"> 目标类型。 </param>
    /// <param name="deserializationStream">
    ///   反序列化流。
    ///   <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <paramref name="type" /> 类型的对象实例。 </returns>
    /// <seealso cref="Stream" />
    /// <seealso cref="Type" />
    protected abstract object DeserializeImpl(Type type, Stream deserializationStream);

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
    [SuppressMessage("Design", "Ex0100:Member may throw undocumented exception", Justification = "<挂起>")]
    public virtual T Deserialize<T>(byte[] input, int? offset = null, int? length = null) where T : class, new()
    {
      return Deserialize(typeof(T), input, offset, length) as T;
    }

    /// <inheritdoc />
    public virtual T Deserialize<T>(Stream deserializationStream) where T : class, new()
    {
      return (T)Deserialize(typeof(T), deserializationStream);
    }

    /// <inheritdoc />
    /// <exception cref="OverflowException">
    ///   当调用
    ///   <see cref="Bytes.FromBytes(System.Collections.Generic.IEnumerable{byte}, int?, int?)" />
    ///   方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="NotSupportedException">
    ///   当调用 <see cref="Stream.WriteAsync(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    /// <exception cref="IOException">
    ///   当调用 <see cref="Stream.WriteAsync(byte[], int, int)" /> 方法时，可能引发此类型的异常。
    /// </exception>
    public virtual object Deserialize(Type type, byte[] input, int? offset = null, int? length = null)
    {
      using (var deserializationStream = new MemoryStream())
      {
        var bytes = Bytes.FromBytes(input, offset, length);
        deserializationStream.Write(bytes.Data, bytes.Offset, bytes.Length);
        deserializationStream.Seek(0, SeekOrigin.Begin);
        return Deserialize(type, deserializationStream);
      }
    }

    /// <inheritdoc />
    /// <exception cref="ArgumentNullException">
    ///   当 <paramref name="type" /> 或 <paramref name="deserializationStream" /> 等于
    ///   <see langword="null" /> 时，将引发此类型的异常。
    /// </exception>
    public virtual object Deserialize(Type type, Stream deserializationStream)
    {
      if (AssertUtilities.IsNull(type))
      {
        throw new ArgumentNullException(nameof(type), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(type)));
      }

      if (AssertUtilities.IsNull(deserializationStream))
      {
        throw new ArgumentNullException(nameof(deserializationStream), SR.Format(nameof(Strings.ArgumentNullException_with_argument_name), nameof(deserializationStream)));
      }

      return DeserializeImpl(type, deserializationStream);
    }

    /// <inheritdoc />
    public virtual byte[] Serialize(object source)
    {
      using (var serializationStream = new MemoryStream())
      {
        Serialize(source, serializationStream);
        return serializationStream.ToArray();
      }
    }

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
    public virtual byte[] Serialize<T>(T source) where T : class, new()
    {
      return Serialize(source);
    }

    /// <inheritdoc />
    public virtual void Serialize<T>(T source, Stream serializationStream) where T : class, new()
    {
      Serialize(source, serializationStream);
    }

    #endregion Methods
  }
}