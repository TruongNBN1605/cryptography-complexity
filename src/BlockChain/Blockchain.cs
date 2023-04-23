using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainBase {
    public class Blockchain {
        private List<Block> Chain;

        public Blockchain() {
            Chain = new List<Block>();
            Chain.Add(CreateGenesisBlock());
        }

        private Block CreateGenesisBlock() => new Block(DateTime.Now, "Genesis Block", "0");

        public Block GetLatestBlock() => Chain[Chain.Count - 1];

        public void AddBlock(Block block) {
            block.Index = Chain.Count;
            block.PreviousHash = GetLatestBlock().Hash;
            block.Hash = block.CalculateHash();
            Chain.Add(block);
        }

        public bool IsChainValid() {
            for (int i = 1; i < Chain.Count; i++) {
                Block curBlock = Chain[i];
                Block prevBlock = Chain[i - 1];
                if (curBlock.Hash != curBlock.CalculateHash()) return false;
                if (curBlock.PreviousHash != prevBlock.Hash) return false;
            }
            return true;
        }

        /** DEV: Prinf BlockChain Data */
        public void output() {
            for (int i = 1; i < Chain.Count; i++) {
                Block block = Chain[i];
                Console.WriteLine($"Index: {block.Index}");
                Console.WriteLine($"Data: {block.Data}");
                Console.WriteLine($"Hash: {block.Hash}");
                Console.WriteLine($"PreviousHash: {block.PreviousHash}");
                Console.WriteLine();
            }
        }
    }
}