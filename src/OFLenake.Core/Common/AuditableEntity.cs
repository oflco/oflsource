// Copyright (c) 2023 Onkgopotse Lenake. Web: https://www.onkgopotselenake.me/.
// Licensed under the MIT license. See LICENSE file for license information.

namespace OFLenake.Core.Common
{
    /// <summary>
    /// Auditable entity base type.
    /// </summary>
    /// <remarks>
    /// <para>
    /// The base <see cref="AuditableEntity"/> class
    /// is inherited by the derived class entities.
    /// </para>
    /// </remarks>
    public class AuditableEntity
    {
        /// <summary>
        /// The <see cref="CreatedBy"/> public <see cref="string"/> property.
        /// </summary>
        public string? CreatedBy { get; set; }

        /// <summary>
        /// The <see cref="CreatedDate"/> date details.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// The <see cref="UpdatedBy"/> title details.
        /// </summary>
        public string? UpdatedBy { get; set; }

        /// <summary>
        /// The <see cref="UpdatedDate"/> date details.
        /// </summary>
        public DateTime? UpdatedDate { get; set; }
    }
}
