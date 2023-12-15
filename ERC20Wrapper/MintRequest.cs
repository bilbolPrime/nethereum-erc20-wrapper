using System.ComponentModel.DataAnnotations;

namespace ERC20Wrapper
{
    public class MintRequest
    {
        [Required]
        public string Account { get; set; }

        [Required]
        public long? Amount { get; set; }
    }
}
