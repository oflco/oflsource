// Copyright (c) Onkgopotse Lenake.
// Licensed under the MIT License.

namespace OFLenake.Core
{
    public class Information
    {

        private static readonly string FirstName = "Onkgopotse";
        private static readonly char[] Initials = {'O', 'F'};
        private static string? Surname = "Lenake";

        //public string? GetFirstName { get; }

        /// <summary>
        /// <see cref="ToString"/> method returns a string
        /// representing a <see cref="Information"/> object.
        /// </summary>
        /// <returns>
        /// A string representing a <see cref="Information"/> object.
        /// </returns>
        public override string ToString()
        {
            string result = $"Profile Information:{Environment.NewLine}" +
                            $"First name: {FirstName}{Environment.NewLine}" +
                            $"Initials: {Initials}{Environment.NewLine}" +
                            $"Surname: {Surname}{Environment.NewLine}";
            return $"{result}";
        }
    }
}
