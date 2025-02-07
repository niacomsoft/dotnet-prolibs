namespace Niacomsoft.ProductiveLibrary
{
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1>(T1 arg1, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, out TResult>(T1 arg1, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, in T3, out TResult>(T1 arg1, T2 arg2, T3 arg3, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2, in T3, in T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, in T3, in T4, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2, in T3, in T4, in T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ����� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ����� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, params object[] args);
            /// <summary> �޷���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="T9"> �������͡� </typeparam>
/// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ����� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ����� </param>
/// <param name="arg9"> <typeparamref name="T9" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, params object[] args);

        /// <summary> <typeparamref name="TResult" /> ���ͷ���ֵ�ķ���ί�С� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="T9"> �������͡� </typeparam>
/// <typeparam name="TResult"> ����ֵ������͡� </typeparam>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ����� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ����� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ����� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ����� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ����� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ����� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ����� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ����� </param>
/// <param name="arg9"> <typeparamref name="T9" /> ���͵Ĳ����� </param>
/// <param name="args"> ���Ӳ������顣 </param>
        /// <returns> <typeparamref name="TResult" /> ���ͷ���ֵ�� </returns>
        public delegate TResult Func<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, out TResult>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, params object[] args);
    }