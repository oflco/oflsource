// Copyright (c) Onkgopotse Lenake.
// Licensed under the MIT License.

using OFLenake.Core;

namespace OFLenake
{
    /// <summary>
    /// OFLenake console runner application.
    /// </summary>
    public class OFLConsole
    {
        private static readonly string AppTitle = $"OFLenake.OFLConsole";
        private static Information? OFLInfo = null;

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

            OFLInfo = new Information();
            Console.WriteLine($"{OFLInfo}\n");

            Console.WriteLine($"{AppTitle} finished...\n");
        }
    }
}
