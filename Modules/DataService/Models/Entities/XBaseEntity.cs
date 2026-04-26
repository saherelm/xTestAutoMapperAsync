using System.ComponentModel.DataAnnotations;
using xTestAutoMapper.Modules.Models;

namespace xTestAutoMapper.Modules.DataService.Models.Entities
{
    /// <summary>
    /// a Base Entity Class ...
    /// </summary>
    /// <typeparam name="TKey">Type of Entity Id ...</typeparam>
    public abstract class XBaseEntity<TKey> : XBaseClass
    {
        /// <summary>
        /// Id of Entity ...
        /// </summary>
        [Key]
        [Required]
        public required TKey Id { get; set; }

        /// <summary>
        /// Check Entity is Soft Deleted or not ...
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Contains Entity Creation Time ...
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Contains Entity Update Time ...
        /// </summary>
        public DateTime UpdatedOn { get; set; }
    }
}