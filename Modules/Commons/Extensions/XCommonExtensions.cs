using xTestAutoMapper.Modules.Commons.Attributes;

namespace xTestAutoMapper.Modules.Commons.Extensions
{
    /// <summary>
    /// Commonly Used Extensions ...
    /// </summary>
    public static class XCommonExtensions
    {
        /// <summary>
        /// Check an Object is null or not ...
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNull(this object? source)
        {
            return source == null;
        }

        /// <summary>
        /// Check string value is null or empty ...
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string source)
        {
            return string.IsNullOrWhiteSpace(source);
        }

        /// <summary>
        /// Get First Assigned Description Attribute Value of Specified Enum ...
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetDescriptionAttribute(this Enum source)
        {
            //
            var result = source
                .GetDescriptionAttributes()
                .FirstOrDefault();

            //
            return result!;
        }
        
        /// <summary>
        /// Get All Assigned Description Attribute Values of Specified Enum ...
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetDescriptionAttributes(this Enum source)
        {
            //
            var result = new List<string>();

            //
            // Validate source not null ...
            if (source.IsNull())
            {
                return result;
            }

            //
            // Get Type ...
            var type = source.GetType();

            //
            // Access Name ...
            var name = Enum.GetName(type, source);

            //
            // Retrieve Field Info of Enum Member ...
            var fieldInfo = type.GetField(name!);
            if (fieldInfo.IsNull())
            {
                return result;
            }

            //
            var attribute = (XDescriptionAttribute[])fieldInfo!.GetCustomAttributes(typeof(XDescriptionAttribute), false);
            result = attribute!.Select(attribute => attribute.Value!).ToList();

            //
            return result;
        }
    }
}