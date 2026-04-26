using System.ComponentModel;

namespace xTestAutoMapper.Modules.DataService.Constants
{
    /// <summary>
    /// Describe All Supported Db Providers ...
    /// </summary>
    public enum XDbProviderEnum
    {
        [Description("None")]
        None = 0,

        [Description("MySQL")]
        MySQL = 1,

        [Description("SQLite")]
        SQLite = 2,

        [Description("MongoDB")]
        MongoDB = 3,

        [Description("SQLServer")]
        SQLServer = 4,
    }
}