using xTestAutoMapper.Modules.Commons.Extensions;
using xTestAutoMapper.Modules.DataService.Constants;

namespace xTestAutoMapper.Modules.DataService.Configurations
{
    /// <summary>
    /// Described Info about Specified DbContext ...
    /// </summary>
    public class XDbContextConfiguration
    {
        /// <summary>
        /// DataBase Title ...
        /// </summary>
        public required string Title { get; set; }

        /// <summary>
        /// DataBase Description ...
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        /// DataBase Connection String ... 
        /// </summary>
        public required string Connection { get; set; }

        /// <summary>
        /// Specified DataBase Provider ...
        /// </summary>
        public XDbProviderEnum Provider { get; set; }

        /// <summary>
        /// Check Model is Valid or not ...
        /// </summary>
        /// <returns></returns>
        public bool IsValid()
        {
            //
            var result =
                !Title.IsNullOrEmpty() &&
                !Connection.IsNullOrEmpty() &&
                Provider != XDbProviderEnum.None;

            //
            return result;
        }
    }
}