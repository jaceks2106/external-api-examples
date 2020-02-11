// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.Students.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class PagedResponse1StudentExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PagedResponse1StudentExternalResponse class.
        /// </summary>
        public PagedResponse1StudentExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// PagedResponse1StudentExternalResponse class.
        /// </summary>
        /// <param name="items">Page of items</param>
        /// <param name="totalItems">Total number of items</param>
        public PagedResponse1StudentExternalResponse(IList<StudentExternalResponse> items = default(IList<StudentExternalResponse>), int? totalItems = default(int?))
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
        /// Gets page of items
        /// </summary>
        [JsonProperty(PropertyName = "items")]
        public IList<StudentExternalResponse> Items { get; private set; }

        /// <summary>
        /// Gets total number of items
        /// </summary>
        [JsonProperty(PropertyName = "totalItems")]
        public int? TotalItems { get; private set; }

    }
}
