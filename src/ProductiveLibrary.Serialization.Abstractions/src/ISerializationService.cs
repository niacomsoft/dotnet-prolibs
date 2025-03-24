/* ********************************************************************************************************************** *\
 * LICENSED UNDER THE MIT LICENSE. SEE LICENSE FILE IN THE PROJECT ROOT FOR FULL LICENSE INFORMATION.                     *
 * © 2025 WANG YUCAI.                                                                                                     *
\* ********************************************************************************************************************** */

using System;
using System.IO;

namespace Niacomsoft.ProductiveLibrary.Runtime.Serialization
{
  #region Interfaces

  /// <summary> 提供了数据序列化服务的接口。 </summary>
  public interface ISerializationService
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
    object Deserialize(Type type, Stream deserializationStream);

    /// <summary>
    ///   从字节数组 <paramref name="input" /> 反序列化得到 <paramref name="type" /> 类型的对象实例。
    /// </summary>
    /// <param name="type"> 目标类型。 </param>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="offset"> 字节数组偏移量。 </param>
    /// <param name="length"> 字节数组长度。 </param>
    /// <returns> <paramref name="type" /> 类型的对象实例。 </returns>
    /// <seealso cref="Type" />
    object Deserialize(Type type, byte[] input, int? offset = null, int? length = null);

    /// <summary>
    ///   从流 <paramref name="deserializationStream" /> 中反序列化得到 <typeparamref name="T" /> 类型的对象实例。
    /// </summary>
    /// <typeparam name="T"> 一个引用类型。 </typeparam>
    /// <param name="deserializationStream">
    ///   反序列化流。
    ///   <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
    /// </param>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    /// <seealso cref="Stream" />
    T Deserialize<T>(Stream deserializationStream) where T : class, new();

    /// <summary>
    ///   从字节数组 <paramref name="input" /> 反序列化得到 <typeparamref name="T" /> 类型的对象实例。
    /// </summary>
    /// <typeparam name="T"> 一个引用类型。 </typeparam>
    /// <param name="input"> 字节数组。 </param>
    /// <param name="offset"> 字节数组偏移量。 </param>
    /// <param name="length"> 字节数组长度。 </param>
    /// <returns> <typeparamref name="T" /> 类型的对象实例。 </returns>
    T Deserialize<T>(byte[] input, int? offset = null, int? length = null) where T : class, new();

    /// <summary> 序列化 <paramref name="source" /> 并返回字节数组。 </summary>
    /// <param name="source"> 需要序列化的对象实例。 </param>
    /// <returns> 字节数组。 </returns>
    byte[] Serialize(object source);

    /// <summary>
    ///   序列化 <paramref name="source" /> 到流 <paramref name="serializationStream" /> 中。
    /// </summary>
    /// <param name="source"> 需要序列化的对象实例。 </param>
    /// <param name="serializationStream">
    ///   目标流。
    ///   <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
    /// </param>
    /// <seealso cref="Stream" />
    void Serialize(object source, Stream serializationStream);

    /// <summary> 序列化 <paramref name="source" /> 并返回字节数组。 </summary>
    /// <typeparam name="T"> 一个引用类型。 </typeparam>
    /// <param name="source"> <typeparamref name="T" /> 类型的对象实例。 </param>
    /// <returns> 字节数组。 </returns>
    byte[] Serialize<T>(T source) where T : class, new();

    /// <summary>
    ///   序列化 <paramref name="source" /> 到流 <paramref name="serializationStream" /> 中。
    /// </summary>
    /// <typeparam name="T"> 一个引用类型。 </typeparam>
    /// <param name="source"> <typeparamref name="T" /> 类型的对象实例。 </param>
    /// <param name="serializationStream">
    ///   目标流。
    ///   <para> 派生自 <see cref="Stream" /> 类型的对象实例。 </para>
    /// </param>
    /// <seealso cref="Stream" />
    void Serialize<T>(T source, Stream serializationStream) where T : class, new();

    #endregion Methods
  }

  #endregion Interfaces
}