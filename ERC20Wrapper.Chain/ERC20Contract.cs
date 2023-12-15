
using Microsoft.Extensions.Options;
using System.Numerics;

namespace BilbolStack.ERC20Wrapper.Chain
{
    public class ERC20Contract : BaseChainContract, IERC20Contract
    {
        public ERC20Contract(IOptions<ChainSettings> chainSettings) : base(chainSettings)
        {
            _contractAddress = chainSettings.Value.ERC20ContractAddress;
        }

        public async Task<long> BalanceOf(string account)
        {
            var function = new BalanceOfFunction() { Account = account };
            return await QueryFromChain<BalanceOfFunction, long>(function);
        }

        public async Task<ChainTXData> Burn(long amount)
        {
            var call = new BurnFunction() { Amount = amount };
            return await CallChain(call);
        }

        public async Task<ChainTXData> Mint(string account, long amount)
        {
            var call = new MintFunction() { To = account, Amount = amount };
            return await CallChain(call);
        }

        public async Task<ChainTXData> Transfer(string account, long amount)
        {
            var call = new TransferFunction() { Receipient = account, Amount = amount };
            return await CallChain(call);
        }
    }
}
