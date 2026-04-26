using System.ComponentModel.DataAnnotations.Schema;
using xTestAutoMapper.Modules.Models;

namespace xTestAutoMapper.Modules.DataService.Models.Dtos
{
    /// <summary>
    /// Base Entity Dto ...
    /// </summary>
    /// <typeparam name="TKey">Type of Entity Id ...</typeparam>
    public abstract class XBaseEntityDto<TKey> : XBaseDto
    {
        /// <summary>
        /// Id of Entity ...
        /// </summary>
        public required TKey Id { set; get; }

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

        /// <summary>
        /// Meta Data is a Common Way to Attach Requirements 
        /// to an Entity ...
        /// </summary>
        #region MetaData ...
        public string? MetaData { get; private set; }

        [NotMapped]
        public IDictionary<string, object> ParsedMetaData
        {
            //
            // Custom Getter ...
            get
            {
                //
                var result = new Dictionary<string, object>();

                //
                // TODO: Parse from MetaData ...

                //
                return result;
            }

            //
            // Custom Setter ...
            set
            {
                //
                // TODO: Converts to Json ...
                MetaData = "";
            }
        }
        #endregion        
    }
}