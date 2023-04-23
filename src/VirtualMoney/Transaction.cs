using System;

namespace VirtualMoney {
    class Transaction {
        public string FromId { get; set; }
        public string ToId { get; set; }
        public int Amount { get; set; }

        public Transaction(string fromId, string toId, int amount) {
            FromId = fromId;
            ToId = toId;
            Amount = amount;
        }

        public override string ToString() {
            return "From: " + FromId + "\n" + "To: " + ToId + "\n" + "Amount: " + Amount + "\n";
        }
    }
}