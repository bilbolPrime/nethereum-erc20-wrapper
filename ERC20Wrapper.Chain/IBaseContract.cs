namespace BilbolStack.ERC20Wrapper.Chain
{
    public interface IBaseContract
    {
        Task ValidateTransaction(string txHash);
    }
}
