using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public class BookAllocation : BaseEntity
    {
        /// <summary>
        /// Gets or sets the date and time the books was allocated
        /// </summary>
        public DateTime DateIssued { get; set; }

        /// <summary>
        /// Gets or sets the date the book should be returned
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the date the book was returned
        /// </summary>
        public DateTime? DateReturned { get; set; }

        /// <summary>
        /// Gets or sets the issuer id
        /// </summary>
        public int? IssuedByUserId { get; set; }

        /// <summary>
        /// Gets or sets the reservation id
        /// </summary>
        public int? ReservationId { get; set; }

        /// <summary>
        /// Gets or sets the customer full name (applicable if <seealso cref="ReservationId"/> is null)
        /// </summary>
        public string CustomerFullName { get; set; }

        /// <summary>
        /// Gets or sets the customer email address (applicable if <seealso cref="ReservationId"/> is null)
        /// </summary>
        [EmailAddress]
        public string CustomerEmail { get; set; }

        /// <summary>
        /// Gets or sets customer 
        /// </summary>
        public string CustomerAddress { get; set; }

        /// <summary>
        /// Gets or sets other customer details
        /// </summary>
        public string CustomerDetails { get; set; }

        /// <summary>
        /// Gets or sets the reservation id
        /// </summary>
        [ForeignKey(nameof(ReservationId))]
        public BookReservation Reservation { get; set; }

        /// <summary>
        /// Gets or sets the issuer 
        /// </summary>
        [ForeignKey(nameof(IssuedByUserId))]
        public LibraryUser IssuedBy { get; set; } 
        
        /// <summary>
        /// Gets or sets the specs
        /// </summary>
        public ICollection<BookAllocationSpec> Specs { get; set; }
    }
}
