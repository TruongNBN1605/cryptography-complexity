using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainApp {
    class Blockchain {
        private List<Block> _chain;

        public Blockchain() {
            _chain = new List<Block>();
            _chain.Add(CreateGenesisBlock());
        }

        private Block CreateGenesisBlock() {
            return new Block(DateTime.Now, "Genesis Block", "0");
        }

        public Block GetLatestBlock() {
            return _chain[_chain.Count - 1];
        }

        public void AddBlock(Block block) {
            block.Index = _chain.Count;
            block.PreviousHash = GetLatestBlock().Hash;
            block.Hash = block.CalculateHash();
            _chain.Add(block);
        }

        public bool IsChainValid() {
            for (int i = 1; i < _chain.Count; i++) {
                Block currentBlock = _chain[i];
                Block previousBlock = _chain[i - 1];
                if (currentBlock.Hash != currentBlock.CalculateHash()) {
                    return false;
                }
                if (currentBlock.PreviousHash != previousBlock.Hash) {
                    return false;
                }
            }
            return true;
        }
    }
}