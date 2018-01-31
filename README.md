# Inleiding

Deze repository bevat de code die gebruikt is bij de Blockchain Development sessie van .NET Oost op 29 januari 2018. Zie https://www.meetup.com/nl-NL/NET-Oost/events/245044122/

De voorbeelden werken met Nethereum, https://github.com/Nethereum, de .NET integration library voor Ethereum: https://github.com/Nethereum

# Test Contract
Het test contract ziet er als volgt uit:
```
pragma solidity ^0.4.4;
contract MultiplierContract {
  uint _multiplier;
  function MultiplierContract(uint multiplier) public {
        _multiplier = multiplier;
  }
  function multiply(uint a) public view returns(uint d) {
        return a * _multiplier;
  }
}
```

Je kunt deze code in Visual Studio Code bewerken, en bewaren onder de naam `multiplier.sol`. 
Tips:
1. Installeer de Solidity extensie voor Visual Studio Code: https://github.com/juanfranblanco/vscode-solidity 
2. Installeer truffle voor compilatie: http://truffleframework.com/
3. Start Ganache voor een lokale (development en test-)instantie van een Ethereum node: http://truffleframework.com/ganache/

Truffle is niet noodzakelijk als je ook de VSCode extensie geïnstalleerd hebt, omdat je via die extensie ook kunt compileren. 
De ABI en bytecode kan je dan gebruiken in het Visual Studio project __EthereumDemo.MultiplierApp.__

# OOST Token
Het contract voor de OOST vind je hier: https://etherscan.io/address/0x2ef06079656f2ab9034b6252978c44104b7b2cc1#code

Je kunt dit contract ook zelf uitrollen op een test netwerk, bijvoorbeeld deze: https://www.rinkeby.io/#stats

Om een saldo op te halen gebruik je het Visual Studio project __EthereumDemo.OostWallet__ plus:
1. Een verbinding met het mainnet, bijvoorbeeld https://mainnet.infura.io of een verbinding met het testnet, bijvoorbeeld https://rinkeby.infura.io. 
2. De public key van een wallet 

Voor het doen van transacties heb je ook een private key nodig. 

# Meer informatie
* http://nethereum.readthedocs.io/en/latest/
* https://ethereum.org/
* https://ethgasstation.info/ 