# Nethereum ERC20 Wrapper

A simple wrapper around nethereum to manage basic ERC20 minting, burning and transfer.

# Local Chain

1. Install [Ganache](https://www.trufflesuite.com/ganache)

## Local Chain Setup

1. `npm install` (inside ./Chain)
1. `truffle compile --all` (inside ./Chain)
1. `truffle deploy` (inside ./Chain)
1. Assign `MINTER_ROLE` and `BURNER_ROLE` to the address that will be used by the server.

# App Settings Setup

1. Update ChainInfo data to match local chain or remote chain
1. Assign a private key belonging to an account that has `MINTER_ROLE` and `BURNER_ROLE`

## API 

1. `~/balance` gets the balance of the `account` sent as query param in wei.


```
{
  "amount": 70
}
```

2. `~/mint` requests to mint an `amount` of the token in wei at the `account`.
The response is the transaction hash as well as the nonce used asuming the tx is successful. An exception is thrown otherwise.
```
{
  "account": "0x25b62DD8416D8bE58f6dE9DAf2a68FfBEfe0ba31",
  "amount": 60
}
```

```
{
  "tx": "0x68ebd1f6c8d08eb8db174a59a1a95077d2ddf356a0444e5b5a7aba93cd54fe62",
  "nonce": 8612
}
```

3. `~/burn` burns an `amount` of the token in wei that is in the balance of the server account.
The response is the transaction hash as well as the nonce used asuming the tx is successful. An exception is thrown otherwise.

```
{
  "amount": 20
}
```

```
{
  "tx": "0x153eeaeda03a171c487f7866f828578a07283768464f569b6494f6259755df0e",
  "nonce": 8615
}
```

4. `~/transfer` tranfers an `amount` of the token in wei from the server account to the `account`.

The response is the transaction hash as well as the nonce used asuming the tx is successful. An exception is thrown otherwise.

```
{
  "account": "0x4B4AABaf30921059e3baD5Ab10f8d19d88cccC60",
  "amount": 10
}
```

```
{
  "tx": "0x2500f0ec6097997169a5b15ecf1e39b44ebf4ed9d1051b0c140eedf48dff68d6",
  "nonce": 8616
}
```

# Version History

1. 2023-12-15: Initial release v1.0.0 

# Disclaimer

This implementation was made for educational / training purposes only.

# License

License is [MIT](https://en.wikipedia.org/wiki/MIT_License)

# MISC

Birbia is coming
