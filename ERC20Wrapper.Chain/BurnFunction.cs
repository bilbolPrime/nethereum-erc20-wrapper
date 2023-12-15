using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

namespace BilbolStack.ERC20Wrapper.Chain
{
    [Function("burn")]
    public class BurnFunction : FunctionMessage
    {
        [Parameter("uint256", "amount")]
        public BigInteger Amount { get; set; }
    }
}
