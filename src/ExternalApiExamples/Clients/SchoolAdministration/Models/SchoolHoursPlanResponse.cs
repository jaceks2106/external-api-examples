// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kmd.Studica.SchoolAdministration.Client.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// SchoolHoursPlanResponse
    /// </summary>
    /// <remarks>
    /// Model of the entity which is return by
    /// SchoolAdministration.Host.ExternalApi.SchoolHours.Queries.SchoolHoursPlansExternalService.
    /// </remarks>
    public partial class SchoolHoursPlanResponse
    {
        /// <summary>
        /// Initializes a new instance of the SchoolHoursPlanResponse class.
        /// </summary>
        public SchoolHoursPlanResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SchoolHoursPlanResponse class.
        /// </summary>
        /// <param name="id">Id of the school hours plan this is part
        /// of.</param>
        /// <param name="name">Name of the school hour plan.</param>
        /// <param name="validFrom">Date these school hours are valid
        /// from.</param>
        /// <param name="associationType">Association between these school hour
        /// plan and education groups. Possible values include:
        /// 'WholeInstitution', 'EducationGroup', 'NoAssociation'</param>
        /// <param name="startTime">Start time for school day.</param>
        /// <param name="lectureDurationInMinutes">Duration of a lecture in
        /// minutes.</param>
        /// <param name="hasLecturesOnMondays">Whether Mondays are
        /// school-days.</param>
        /// <param name="hasLecturesOnTuesdays">Whether Tuesdays are
        /// school-days.</param>
        /// <param name="hasLecturesOnWednesdays">Whether Wednesdays are
        /// school-days.</param>
        /// <param name="hasLecturesOnThursdays">Whether Thursdays are
        /// school-days.</param>
        /// <param name="hasLecturesOnFridays">Whether Fridays are
        /// school-days.</param>
        /// <param name="hasLecturesOnSaturdays">Whether Saturdays are
        /// school-days.</param>
        /// <param name="hasLecturesOnSundays">Whether Sundays are
        /// school-days.</param>
        public SchoolHoursPlanResponse(System.Guid id, string name, System.DateTime validFrom, string associationType, string startTime, int lectureDurationInMinutes, bool hasLecturesOnMondays, bool hasLecturesOnTuesdays, bool hasLecturesOnWednesdays, bool hasLecturesOnThursdays, bool hasLecturesOnFridays, bool hasLecturesOnSaturdays, bool hasLecturesOnSundays)
        {
            Id = id;
            Name = name;
            ValidFrom = validFrom;
            AssociationType = associationType;
            StartTime = startTime;
            LectureDurationInMinutes = lectureDurationInMinutes;
            HasLecturesOnMondays = hasLecturesOnMondays;
            HasLecturesOnTuesdays = hasLecturesOnTuesdays;
            HasLecturesOnWednesdays = hasLecturesOnWednesdays;
            HasLecturesOnThursdays = hasLecturesOnThursdays;
            HasLecturesOnFridays = hasLecturesOnFridays;
            HasLecturesOnSaturdays = hasLecturesOnSaturdays;
            HasLecturesOnSundays = hasLecturesOnSundays;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the school hours plan this is part of.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets name of the school hour plan.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets date these school hours are valid from.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "validFrom")]
        public System.DateTime ValidFrom { get; set; }

        /// <summary>
        /// Gets or sets association between these school hour plan and
        /// education groups. Possible values include: 'WholeInstitution',
        /// 'EducationGroup', 'NoAssociation'
        /// </summary>
        [JsonProperty(PropertyName = "associationType")]
        public string AssociationType { get; set; }

        /// <summary>
        /// Gets or sets start time for school day.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Gets or sets duration of a lecture in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "lectureDurationInMinutes")]
        public int LectureDurationInMinutes { get; set; }

        /// <summary>
        /// Gets or sets whether Mondays are school-days.
        /// </summary>
        [JsonProperty(PropertyName = "hasLecturesOnMondays")]
        public bool HasLecturesOnMondays { get; set; }

        /// <summary>
        /// Gets or sets whether Tuesdays are school-days.
        /// </summary>
        [JsonProperty(PropertyName = "hasLecturesOnTuesdays")]
        public bool HasLecturesOnTuesdays { get; set; }

        /// <summary>
        /// Gets or sets whether Wednesdays are school-days.
        /// </summary>
        [JsonProperty(PropertyName = "hasLecturesOnWednesdays")]
        public bool HasLecturesOnWednesdays { get; set; }

        /// <summary>
        /// Gets or sets whether Thursdays are school-days.
        /// </summary>
        [JsonProperty(PropertyName = "hasLecturesOnThursdays")]
        public bool HasLecturesOnThursdays { get; set; }

        /// <summary>
        /// Gets or sets whether Fridays are school-days.
        /// </summary>
        [JsonProperty(PropertyName = "hasLecturesOnFridays")]
        public bool HasLecturesOnFridays { get; set; }

        /// <summary>
        /// Gets or sets whether Saturdays are school-days.
        /// </summary>
        [JsonProperty(PropertyName = "hasLecturesOnSaturdays")]
        public bool HasLecturesOnSaturdays { get; set; }

        /// <summary>
        /// Gets or sets whether Sundays are school-days.
        /// </summary>
        [JsonProperty(PropertyName = "hasLecturesOnSundays")]
        public bool HasLecturesOnSundays { get; set; }

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
            if (AssociationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AssociationType");
            }
            if (StartTime == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StartTime");
            }
            if (LectureDurationInMinutes > 1440)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "LectureDurationInMinutes", 1440);
            }
            if (LectureDurationInMinutes < 1)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "LectureDurationInMinutes", 1);
            }
        }
    }
}
