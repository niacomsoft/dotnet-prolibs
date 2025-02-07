
class Guard
{
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1>(System.Action<T1> method, T1 arg1)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, TResult>(System.Func<T1, TResult> method, T1 arg1)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1>(Action<T1> method, T1 arg1, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, TResult>(Func<T1, TResult> method, T1 arg1, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2>(System.Action<T1, T2> method, T1 arg1, T2 arg2)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, TResult>(System.Func<T1, T2, TResult> method, T1 arg1, T2 arg2)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2>(Action<T1, T2> method, T1 arg1, T2 arg2, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, TResult>(Func<T1, T2, TResult> method, T1 arg1, T2 arg2, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3>(System.Action<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, TResult>(System.Func<T1, T2, T3, TResult> method, T1 arg1, T2 arg2, T3 arg3)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2, T3}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2, T3}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3>(Action<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> method, T1 arg1, T2 arg2, T3 arg3, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, TResult>(System.Func<T1, T2, T3, T4, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2, T3, T4}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2, T3, T4}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4>(Action<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, TResult>(System.Func<T1, T2, T3, T4, T5, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2, T3, T4, T5}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2, T3, T4, T5}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, TResult>(System.Func<T1, T2, T3, T4, T5, T6, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2, T3, T4, T5, T6}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2, T3, T4, T5, T6}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, T7, TResult>(System.Func<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6, arg7));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2, T3, T4, T5, T6, T7}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2, T3, T4, T5, T6, T7}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(System.Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2, T3, T4, T5, T6, T7, T8}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
            /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="T9"> �������͡� </typeparam>
/// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg9"> <typeparamref name="T9" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="T9"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg9"> <typeparamref name="T9" /> ���͵Ĳ���ֵ�� </param>
/// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(System.Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }

        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="T9"> �������͡� </typeparam>
/// <param name="method"> <see cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9}" /> ���͵ķ���ί�С� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg9"> <typeparamref name="T9" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Action{T1, T2, T3, T4, T5, T6, T7, T8, T9}" />
        /// <seealso cref="Result" />
        public static Result Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, args);
            }
            catch(System.Exception error)
            {
                return Result.WhenCatched(error);
            }
            return Result.Complete();
        }

        
        /// <summary> ִ�з��� <paramref name="method" />�� </summary>
        /// <typeparam name="T1"> �������͡� </typeparam>
/// <typeparam name="T2"> �������͡� </typeparam>
/// <typeparam name="T3"> �������͡� </typeparam>
/// <typeparam name="T4"> �������͡� </typeparam>
/// <typeparam name="T5"> �������͡� </typeparam>
/// <typeparam name="T6"> �������͡� </typeparam>
/// <typeparam name="T7"> �������͡� </typeparam>
/// <typeparam name="T8"> �������͡� </typeparam>
/// <typeparam name="T9"> �������͡� </typeparam>
/// <typeparam name="TResult"> ���ֵ���͡� </typeparam>
        /// <param name="method"> ָ���ķ����� </param>
        /// <param name="arg1"> <typeparamref name="T1" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg2"> <typeparamref name="T2" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg3"> <typeparamref name="T3" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg4"> <typeparamref name="T4" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg5"> <typeparamref name="T5" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg6"> <typeparamref name="T6" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg7"> <typeparamref name="T7" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg8"> <typeparamref name="T8" /> ���͵Ĳ���ֵ�� </param>
/// <param name="arg9"> <typeparamref name="T9" /> ���͵Ĳ���ֵ�� </param>
/// <param name="args"> �������顣 </param>
        /// <returns> <see cref="Result{TResult}" /> ���͵Ķ���ʵ���� </returns>
        /// <seealso cref="Result" />
        public static Result<TResult> Execute<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, params object[] args)
        {
            try
            {
                if (AssertUtilities.IsNull(method))
                {
                    return Result<TResult>.Fail(MethodFailedReason.UnexpectedParameter | MethodFailedReason.MissingRequiredParameter);
                }
                return Result<TResult>.Complete(method(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, args));
            }
            catch(System.Exception error)
            {
                return Result<TResult>.WhenCatched(error);
            }
        }
    }