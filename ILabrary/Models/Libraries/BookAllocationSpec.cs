using System.ComponentModel.DataAnnotations.Schema;

namespace ILabrary.Models.Libraries
{
    public class BookAllocationSpec : BookAllocationSpecBase
    {
        /// <summary>
        /// Gets or sets the allocation
        /// </summary>
        public int AllocationId { get; set; }
        
        /// <summary>
        /// Gets or sets the allocation
        /// </summary>
        [ForeignKey(nameof(AllocationId))]
        public BookAllocation Allocation { get; set; }
    }
}
