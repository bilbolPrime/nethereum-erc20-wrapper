using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace BilbolStack.ERC20Wrapper.Chain
{
    [Function("mint")]
    public class MintFunction : FunctionMessage
    {
        [Parameter("address", "to")]
        public string To { get; set; }
        [Parameter("uint256", "amount")]
        public BigInteger Amount { get; set; }
    }
}
