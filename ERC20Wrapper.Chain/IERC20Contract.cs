namespace BilbolStack.ERC20Wrapper.Chain
{
    public interface IERC20Contract : IBaseContract
    {
        Task<long> BalanceOf(string account);
        Task<ChainTXData> Mint(string account, long amount);
        Task<ChainTXData> Transfer(string account, long amount);
        Task<ChainTXData> Burn(long amount);
    }
}
