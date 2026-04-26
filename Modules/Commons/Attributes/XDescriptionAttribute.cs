namespace xTestAutoMapper.Modules.Commons.Attributes
{
    /// <summary>
    /// an Attribute to Used for Attach Values to objects ...
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class XDescriptionAttribute : Attribute
    {
        /// <summary>
        /// the Stored Value in Attribute ...
        /// </summary>
        public string? Value { get; set; }

        public XDescriptionAttribute(string value)
        {
            Value = value;
        }
    }
}