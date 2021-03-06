// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public partial interface ISchoolAdministrationHost : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IEmployeesExternal.
        /// </summary>
        IEmployeesExternal EmployeesExternal { get; }

        /// <summary>
        /// Gets the IRoomsExternal.
        /// </summary>
        IRoomsExternal RoomsExternal { get; }

        /// <summary>
        /// Gets the ISchoolHourEntriesExternal.
        /// </summary>
        ISchoolHourEntriesExternal SchoolHourEntriesExternal { get; }

        /// <summary>
        /// Gets the ISchoolHoursPlansExternal.
        /// </summary>
        ISchoolHoursPlansExternal SchoolHoursPlansExternal { get; }

    }
}
