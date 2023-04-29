// Copyright (c) 2023 Onkgopotse Lenake. Web: https://www.onkgopotselenake.me/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace OFLenake
{
    public class Profile
    {
        private static readonly string FirstName = OFLInfo.FirstName;
        private static readonly string MiddleName = OFLInfo.MiddleName;
        private static readonly string LastName = OFLInfo.LastName;
        private static readonly string Initials = OFLInfo.Initials;
        private static readonly string Nickname = OFLInfo.Nickname;

        /// <summary>
        /// The <see cref="ToString"/> method returns a string
        /// representing an <see cref="Profile"/> object.
        /// </summary>
        /// <returns>
        /// A string representing an <see cref="Profile"/> object.
        /// </returns>
        public override string ToString()
        {
            return $"Profile Information:{Environment.NewLine}" +
                   $"First name: {FirstName}{Environment.NewLine}" +
                   $"Middle name: {MiddleName}{Environment.NewLine}" +
                   $"Last name: {LastName}{Environment.NewLine}" +
                   $"Initials: {Initials}{Environment.NewLine}" +
                   $"NickName: {Nickname}{Environment.NewLine}";
        }
    }
}
