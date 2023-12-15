using BilbolStack.ERC20Wrapper.Chain;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace BilbolStack.ERC20Wrapper.API
{
    [ApiController]
    [Route("/")]
    public class ERC20WrapperController : ControllerBase
    {
        private IERC20Contract _erc20Contract;
        public ERC20WrapperController(IERC20Contract erc20Contract)
        {
            _erc20Contract = erc20Contract;
        }

        [HttpGet("balance")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(BalanceResponse), StatusCodes.Status200OK)]
        public async Task<BalanceResponse> BalanceOf([FromQuery][Required] string account)
        {
            var balance = await _erc20Contract.BalanceOf(account);
            return new BalanceResponse() { Amount = balance };
        }

        [HttpPost("mint")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ChainTXData), StatusCodes.Status200OK)]
        public async Task<ChainTXData> Mint([FromBody] MintRequest mintRequest)
        {
            var tx = await _erc20Contract.Mint(mintRequest.Account, mintRequest.Amount.Value);
            await _erc20Contract.ValidateTransaction(tx.TX);
            return tx;
        }

        [HttpPost("burn")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ChainTXData), StatusCodes.Status200OK)]
        public async Task<ChainTXData> Burn([FromBody] BurnRequest mintRequest)
        {
            var tx = await _erc20Contract.Burn(mintRequest.Amount.Value);
            await _erc20Contract.ValidateTransaction(tx.TX);
            return tx;
        }

        [HttpPost("transfer")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(typeof(ChainTXData), StatusCodes.Status200OK)]
        public async Task<ChainTXData> Transfer([FromBody] TransferRequest transferRequest)
        {
            var tx =await _erc20Contract.Transfer(transferRequest.Account, transferRequest.Amount.Value);
            await _erc20Contract.ValidateTransaction(tx.TX);
            return tx;
        }
    }
}
