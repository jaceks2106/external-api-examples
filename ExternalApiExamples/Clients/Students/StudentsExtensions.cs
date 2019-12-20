// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for StudentsExternal.
    /// </summary>
    public static partial class StudentsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='institutionNumber'>
            /// Institution number where student belongs to.
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            /// <param name='pageSize'>
            /// </param>
            /// <param name='inlineCount'>
            /// </param>
            /// <param name='studyStartDateFrom'>
            /// </param>
            /// <param name='studyStartDateTo'>
            /// </param>
            public static PagedResponse1 Get(this IStudents operations, string institutionNumber, int pageNumber, int pageSize, bool inlineCount, System.DateTime studyStartDateFrom, System.DateTime studyStartDateTo)
            {
                return operations.GetAsync(institutionNumber, pageNumber, pageSize, inlineCount, studyStartDateFrom, studyStartDateTo).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='institutionNumber'>
            /// Institution number where student belongs to.
            /// </param>
            /// <param name='pageNumber'>
            /// </param>
            /// <param name='pageSize'>
            /// </param>
            /// <param name='inlineCount'>
            /// </param>
            /// <param name='studyStartDateFrom'>
            /// </param>
            /// <param name='studyStartDateTo'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PagedResponse1> GetAsync(this IStudents operations, string institutionNumber, int pageNumber, int pageSize, bool inlineCount, System.DateTime studyStartDateFrom, System.DateTime studyStartDateTo, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(institutionNumber, pageNumber, pageSize, inlineCount, studyStartDateFrom, studyStartDateTo, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}