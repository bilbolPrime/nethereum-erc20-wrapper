using System.ComponentModel.DataAnnotations;

namespace BilbolStack.ERC20Wrapper.API
{
    public class MintRequest
    {
        [Required]
        public string Account { get; set; }

        [Required]
        public long? Amount { get; set; }
    }
}
