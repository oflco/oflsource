// Copyright (c) 2023 Onkgopotse Lenake. Web: https://www.onkgopotselenake.me/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace OFLenake
{
    /// <summary>
    /// OFLenake console runner application.
    /// </summary>
    public class OFLConsole
    {
        private static readonly string AppTitle = $"OFLenake.OFLConsole";
        private static Profile? OFLProfile = null;

        /// <summary>
        /// OFLenake console runner application main method.
        /// </summary>
        /// <param name="args">
        /// <see cref="string"/>[] objects to parse to the
        /// <see cref="Main"/> method.
        /// </param>
        /// <remarks>
        /// <para>
        /// The <see cref="Main"/> method is the main entry point
        /// to the <see cref="OFLConsole"/> runner application.
        /// </para>
        /// </remarks>
        static void Main(string[] args)
        {
            Console.WriteLine($"{AppTitle} started...\n");

            OFLProfile = new Profile();
            Console.WriteLine($"{OFLProfile}");

            Console.WriteLine($"{AppTitle} finished...");
        }
    }
}
