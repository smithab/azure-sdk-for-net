// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs.Models
{
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Check Name Availability for Namespace and
    /// NotificationHubs.
    /// </summary>
    public partial class CheckAvailabilityParameters : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CheckAvailabilityParameters
        /// class.
        /// </summary>
        public CheckAvailabilityParameters() { }

        /// <summary>
        /// Initializes a new instance of the CheckAvailabilityParameters
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="isAvailiable">True if the name is available and can
        /// be used to create new Namespace/NotificationHub. Otherwise
        /// false.</param>
        public CheckAvailabilityParameters(string location, string id = default(string), string name = default(string), string type = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), bool? isAvailiable = default(bool?))
            : base(location, id, name, type, tags)
        {
            IsAvailiable = isAvailiable;
        }

        /// <summary>
        /// Gets or sets true if the name is available and can be used to
        /// create new Namespace/NotificationHub. Otherwise false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "isAvailiable")]
        public bool? IsAvailiable { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
