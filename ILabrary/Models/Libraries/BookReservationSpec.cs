namespace ILabrary.Models.Libraries
{
    public class BookReservationSpec :  BookAllocationSpecBase
    {
        /// <summary>
        /// Gets or sets the reservation
        /// </summary>
        public int ReservationId { get; set; }
        
        /// <summary>
        /// Gets or sets the reservation
        /// </summary>
        public BookReservation Reservation { get; set; }
    }
}
