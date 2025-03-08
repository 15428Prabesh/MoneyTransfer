﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Transfer
    {
        public int Id { get; set; }
        public string ReceiverFirstName { get; set; }
        public string? ReceiverMiddleName { get; set; }
        public string ReceiverLastName { get; set; }
        public string ReceiverAddress { get; set; }
        public string ReceiverCountry { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public decimal TransferAmountMYR { get; set; }
        public decimal ExchangeRate { get; set; }
        public decimal PayoutAmountNPR { get; set; }
        public DateTime TransferDate { get; set; }
        public int UserId { get; set; }
    }
}
