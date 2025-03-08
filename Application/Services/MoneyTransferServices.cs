using Application.DTO;
using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MoneyTransferServices
    {
        private readonly IMoneyTransferInterfaces _moneyTransfer;
        private readonly HttpClient _httpClient;
        public MoneyTransferServices(IMoneyTransferInterfaces moneyTransferRepositories, HttpClient httpClient)
        {
            _moneyTransfer = moneyTransferRepositories;
            _httpClient = httpClient;
        }
        public async Task<bool> TransferMoneyAsync(string BankName, string AccountNumber, string receiverFirstName, string receiverMiddleName, string receiverLastName, string receiverAddress, string receiverCountry, decimal transferAmountMYR, decimal exchangeRate, decimal payoutAmountNPR)
        {
            return true;
        }
        public async Task StoreTransactionDetails(MoneyTransferDto dto)
        {
            var transaction = new Transfer
            {
                ReceiverFirstName = dto.ReceiverFirstName,
                ReceiverMiddleName = dto.ReceiverMiddleName,
                ReceiverLastName = dto.ReceiverLastName,
                ReceiverAddress = dto.ReceiverAddress,
                ReceiverCountry = dto.ReceiverCountry,
                BankName = dto.BankName,
                AccountNumber = dto.AccountNumber,
                TransferAmountMYR = dto.TransferAmountMYR,
                ExchangeRate = dto.ExchangeRate,
                PayoutAmountNPR = dto.PayoutAmountNPR,
                TransferDate = DateTime.UtcNow,
                UserId = dto.UserId
            };

            await _moneyTransfer.AddAsync(transaction);
        }
    } 
}
