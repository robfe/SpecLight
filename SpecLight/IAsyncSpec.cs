using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SpecLight
{
    /// <summary>
    /// When you call any Async method on a Spec, you get back an IAsyncSpec instead of a Spec. The only difference is that the <see cref="Execute"/> method is marked as Obsolete in favour of <see cref="ExecuteAsync"/>
    /// </summary>
    public partial interface IAsyncSpec
    {
        string Description { get; }
        MethodBase CallingMethod { get; set; }
        string TestMethodNameOverride { get; set; }
        List<Step> Steps { get; }

        /// <summary>
        /// A bag to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataDictionary"/>. Any contents of type string will be printed to output.
        /// </summary>
        dynamic DataBag { get; }

        /// <summary>
        /// A dictionary to attach random stuff to a step. Most likely used by an <see cref="ISpecFixture"/>. Refers to the same datastore as the <see cref="DataBag"/>. Any contents of type string will be printed to output.
        /// </summary>
        IDictionary<string, object> DataDictionary { get; }

        Spec Tag(params string[] tags);
        Spec Finally(IDisposable disposable);
        Spec Finally(Action finalAction);
        Spec WithFixture<T>() where T : ISpecFixture, new();

        /// <summary>
        ///     Run the spec async, printing its results to the output windows, and re-throwing the first exception that it encountered
        ///     (such as an Assert failure)
        ///     Be sure to call Execute from your unit test method directly so that it can detect its calling method correctly
        /// </summary>
        Task ExecuteAsync([CallerMemberName] string testMethodNameOverride = null);

        /// <inheritdoc cref="Spec.Catch"/>
        Spec Catch(out Lazy<Exception> caughtExceptionReference);

        /// <summary>
        ///    Because you have used one of the async step methods, you should be awaiting/returning ExecuteAsync instead
        /// </summary>
        [Obsolete("Because you have used one of the Async step methods, you should be calling ExecuteAsync instead, and returning that task to your test runner")]
        void Execute([CallerMemberName] string testMethodNameOverride = null);
    }
}
