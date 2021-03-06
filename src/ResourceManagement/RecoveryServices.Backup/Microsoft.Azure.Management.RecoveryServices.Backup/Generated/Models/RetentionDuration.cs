// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Linq;

    /// <summary>
    /// Retention duration.
    /// </summary>
    public partial class RetentionDuration
    {
        /// <summary>
        /// Initializes a new instance of the RetentionDuration class.
        /// </summary>
        public RetentionDuration() { }

        /// <summary>
        /// Initializes a new instance of the RetentionDuration class.
        /// </summary>
        /// <param name="count">Count of duration types. Retention duration is
        /// obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks,
        /// retention duration will be three weeks.</param>
        /// <param name="durationType">Retention duration type of retention
        /// policy. Possible values include: 'Invalid', 'Days', 'Weeks',
        /// 'Months', 'Years'</param>
        public RetentionDuration(int? count = default(int?), RetentionDurationType? durationType = default(RetentionDurationType?))
        {
            Count = count;
            DurationType = durationType;
        }

        /// <summary>
        /// Gets or sets count of duration types. Retention duration is
        /// obtained by the counting the duration type Count times.
        /// For example, when Count = 3 and DurationType = Weeks,
        /// retention duration will be three weeks.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets retention duration type of retention policy. Possible
        /// values include: 'Invalid', 'Days', 'Weeks', 'Months', 'Years'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "durationType")]
        public RetentionDurationType? DurationType { get; set; }

    }
}
