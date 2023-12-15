using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace BilbolStack.ERC20Wrapper.Chain
{
    [Function("balanceOf", "uint256")]
    public class BalanceOfFunction : FunctionMessage
    {
        [Parameter("address", "account")]
        public string Account { get; set; }
    }
}
