using System.ComponentModel.DataAnnotations;

namespace BilbolStack.ERC20Wrapper.API
{
    public class BurnRequest
    {
        [Required]
        public long? Amount { get; set; }
    }
}
