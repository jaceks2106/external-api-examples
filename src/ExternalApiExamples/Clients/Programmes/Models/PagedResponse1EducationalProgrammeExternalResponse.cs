// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Programmes.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PagedResponse1EducationalProgrammeExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PagedResponse1EducationalProgrammeExternalResponse class.
        /// </summary>
        public PagedResponse1EducationalProgrammeExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PagedResponse1EducationalProgrammeExternalResponse class.
        /// </summary>
        public PagedResponse1EducationalProgrammeExternalResponse(IList<EducationalProgrammeExternalResponse> items = default(IList<EducationalProgrammeExternalResponse>), int? totalItems = default(int?))
        {
            Items = items;
            TotalItems = totalItems;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<EducationalProgrammeExternalResponse> Items { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "totalItems")]
        public int? TotalItems { get; private set; }

    }
}