// Copyright (c) 2023 Onkgopotse Lenake. Web: https://www.onkgopotselenake.me/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace OFLenake
{
    /// <summary>
    /// OFLenake information type.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The <see cref="OFLInfo"/> class provides OFLenake static information.
    /// </para>
    /// </remarks>
    public static class OFLInfo
    {
        #region Fields
        private static readonly string _firstName = "Onkgopotse";
        private static readonly string _middleName = "Frederick";
        private static readonly string _surname = "Lenake";
        private static readonly string _initials = "O.F";
        private static readonly string _nickname = "Kgupi";
        #endregion

        #region Properties
        public static string FirstName => _firstName;
        public static string MiddleName => _middleName;
        public static string LastName => _surname;
        public static string Initials => _initials;
        public static string Nickname => _nickname;
        #endregion
    }
}
