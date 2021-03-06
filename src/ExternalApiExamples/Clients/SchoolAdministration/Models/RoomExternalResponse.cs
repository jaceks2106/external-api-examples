// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// RoomExternalResponse
    /// </summary>
    /// <remarks>
    /// Model of the room.
    /// </remarks>
    public partial class RoomExternalResponse
    {
        /// <summary>
        /// Initializes a new instance of the RoomExternalResponse class.
        /// </summary>
        public RoomExternalResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoomExternalResponse class.
        /// </summary>
        /// <param name="id">Id of the room.</param>
        /// <param name="name">Name of the room.</param>
        /// <param name="designation">Acronym used for the room.</param>
        /// <param name="roomType">Type of room. Possible values include:
        /// 'ClassRoom', 'Lab', 'Workshop', 'Gym', 'Auditorium', 'MeetingRoom',
        /// 'Other'</param>
        /// <param name="description">Description of the room.</param>
        /// <param name="capacity">Capacity for meetings.</param>
        /// <param name="maximumPersonsAllowed">Maximum persons allowed in the
        /// room.</param>
        /// <param name="addressLine">Address of the building where the room is
        /// located.</param>
        /// <param name="city">City of the building where the room is
        /// located.</param>
        /// <param name="postalCode">Postal code of the building where the room
        /// is located.</param>
        /// <param name="buildingNumber">Building number at the address, where
        /// the room is located.</param>
        /// <param name="floor">Floor number in the building, where the room is
        /// located.</param>
        public RoomExternalResponse(System.Guid id, string name, string designation, string roomType, string description = default(string), int? capacity = default(int?), int? maximumPersonsAllowed = default(int?), string addressLine = default(string), string city = default(string), string postalCode = default(string), string buildingNumber = default(string), string floor = default(string))
        {
            Id = id;
            Name = name;
            Designation = designation;
            Description = description;
            RoomType = roomType;
            Capacity = capacity;
            MaximumPersonsAllowed = maximumPersonsAllowed;
            AddressLine = addressLine;
            City = city;
            PostalCode = postalCode;
            BuildingNumber = buildingNumber;
            Floor = floor;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the room.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets name of the room.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets acronym used for the room.
        /// </summary>
        [JsonProperty(PropertyName = "designation")]
        public string Designation { get; set; }

        /// <summary>
        /// Gets or sets description of the room.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets type of room. Possible values include: 'ClassRoom',
        /// 'Lab', 'Workshop', 'Gym', 'Auditorium', 'MeetingRoom', 'Other'
        /// </summary>
        [JsonProperty(PropertyName = "roomType")]
        public string RoomType { get; set; }

        /// <summary>
        /// Gets or sets capacity for meetings.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Gets or sets maximum persons allowed in the room.
        /// </summary>
        [JsonProperty(PropertyName = "maximumPersonsAllowed")]
        public int? MaximumPersonsAllowed { get; set; }

        /// <summary>
        /// Gets or sets address of the building where the room is located.
        /// </summary>
        [JsonProperty(PropertyName = "addressLine")]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or sets city of the building where the room is located.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets postal code of the building where the room is located.
        /// </summary>
        [JsonProperty(PropertyName = "postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets building number at the address, where the room is
        /// located.
        /// </summary>
        [JsonProperty(PropertyName = "buildingNumber")]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Gets or sets floor number in the building, where the room is
        /// located.
        /// </summary>
        [JsonProperty(PropertyName = "floor")]
        public string Floor { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (Designation == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Designation");
            }
            if (RoomType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RoomType");
            }
        }
    }
}
