using BilbolStack.ERC20Wrapper.Chain;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace ERC20Wrapper.Controllers
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

        [HttpPost("mint")]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        public async Task Mint([FromBody] MintRequest mintRequest)
        {
            await _erc20Contract.Mint(mintRequest.Account, mintRequest.Amount.Value);
        }
    }
}
