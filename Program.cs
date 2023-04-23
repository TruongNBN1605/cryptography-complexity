using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainApp {
    class Program {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            Blockchain blockchain = new Blockchain();
            blockchain.AddBlock(new Block(DateTime.Now, "Block 1", ""));
            blockchain.AddBlock(new Block(DateTime.Now, "Block 2", ""));
            blockchain.AddBlock(new Block(DateTime.Now, "Block 3", ""));

            Console.WriteLine($"Is blockchain valid? {blockchain.IsChainValid()}");
            Console.WriteLine($"Latest block: {blockchain.GetLatestBlock().Data}");
        }
    }
}
