using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BlockchainApp {
    class Program {
        public static void introduceGroup () {
            Console.WriteLine("Môn học \t: Cryptography & Complexity");
            Console.WriteLine("Đề tài \t: Tìm hiểu về BlockChain");
            Console.WriteLine("Giảng viên \t: Nguyễn ĐÌnh Hân");
            Console.WriteLine("Nhóm \t: Nhóm 9");
            Console.WriteLine("Thành viên \t:");
            Console.WriteLine("\t 20185418 - Nguyễn Bùi Nam Trường");
            Console.WriteLine("\t 20185400 - Nguyễn Trường Sơn");
            Console.WriteLine("\t 20185420 - Nguyễn Minh Tuấn");
            Console.WriteLine("\t ######## - Nguyễn Tiến Vỹ");
            Console.WriteLine("\t 20185390 - Nguyễn Phú Nhật");
            Console.WriteLine("_______________________________________");
        }

        static void Main(string[] args) {
            // Config app
            Console.OutputEncoding = Encoding.UTF8;

            // introduce group
            introduceGroup();

            // Action: Demo Blockchain App
            Blockchain blockchain = new Blockchain();
            blockchain.AddBlock(new Block(DateTime.Now, "Block 1", ""));
            blockchain.AddBlock(new Block(DateTime.Now, "Block 2", ""));
            blockchain.AddBlock(new Block(DateTime.Now, "Block 3", ""));

            Console.WriteLine($"Is blockchain valid? {blockchain.IsChainValid()}");
            Console.WriteLine($"Latest block: {blockchain.GetLatestBlock().Data}");
        }
    }
}
