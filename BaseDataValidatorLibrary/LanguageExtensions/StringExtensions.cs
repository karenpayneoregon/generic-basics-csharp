using System.Text.RegularExpressions;

namespace BaseDataValidatorLibrary.LanguageExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Given a string with upper and lower cased letters separate them before each upper cased characters
        /// </summary>
        /// <param name="sender">String to work against</param>
        /// <returns>String with spaces between upper-case letters</returns>
        public static string SplitCamelCase(this string sender) =>
            string.Join(" ", Regex.Matches(sender, @"([A-Z][a-z]+)")
                .Select(m => m.Value));

        private static readonly Regex Reg = new("([a-z,0-9](?=[A-Z])|[A-Z](?=[A-Z][a-z]))", RegexOptions.Compiled);

        /// <summary>
        /// This splits up a string based on capital letters
        /// e.g. "MyAction" would become "My Action" and "My10Action" would become "My10 Action"
        /// </summary>
        /// <param name="sender"></param>
        /// <returns></returns>
        public static string SplitPascalCase(this string sender)
        {
            return Reg.Replace(sender, "$1 ");
        }
    }
}
