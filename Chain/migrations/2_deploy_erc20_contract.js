var ERC20Contract = artifacts.require('ERC20Contract');

module.exports = function (deployer) {
    deployer.deploy(ERC20Contract);
}