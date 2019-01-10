﻿using Phantasma.Explorer.Infrastructure.Interfaces;
using Phantasma.API;
using LunarLabs.Parser;

namespace Phantasma.Explorer.Controllers
{
    public class ApiController
    {
        private readonly NexusAPI _api;

        public ApiController(IRepository repo)
        {

        }

        public DataNode GetAccount(string addressText)
        {
            return APIUtils.FromAPIResult(_api.GetAccount(addressText));
        }

        public DataNode GetAddressTransactions(string addressText, int amount)
        {
            return APIUtils.FromAPIResult(_api.GetAddressTransactions(addressText, amount));
        }

        public DataNode GetApps()
        {
            return APIUtils.FromAPIResult(_api.GetApps());
        }

        public DataNode GetBlockByHash(string blockHash)
        {
            return APIUtils.FromAPIResult(_api.GetBlockByHash(blockHash));
        }

        public DataNode GetRawBlockByHash(string blockHash)
        {
            return APIUtils.FromAPIResult(_api.GetRawBlockByHash(blockHash));
        }

        public DataNode GetBlockByHeight(string chain, uint height)
        {
            return APIUtils.FromAPIResult(_api.GetBlockByHeight(chain, height));
        }

        public DataNode GetRawBlockByHeight(string chain, uint height)
        {
            return APIUtils.FromAPIResult(_api.GetRawBlockByHeight(chain, height));
        }

        public DataNode GetBlockHeight(string chain)
        {
            return APIUtils.FromAPIResult(_api.GetBlockHeightFromChain(chain));
        }

        public DataNode GetBlockTransactionCountByHash(string blockHash)
        {
            return APIUtils.FromAPIResult(_api.GetBlockTransactionCountByHash(blockHash));
        }

        public DataNode GetChains()
        {
            return APIUtils.FromAPIResult(_api.GetChains());
        }

        public DataNode GetConfirmations(string txHash)
        {
            return APIUtils.FromAPIResult(_api.GetConfirmations(txHash));
        }

        public DataNode GetTransactionByHash(string txHash)
        {
            return APIUtils.FromAPIResult(_api.GetTransaction(txHash));
        }

        public DataNode GetTransactionByBlockHashAndIndex(string blockHash, int index)
        {
            return APIUtils.FromAPIResult(_api.GetTransactionByBlockHashAndIndex(blockHash, index));
        }

        public DataNode GetTokens()
        {
            return APIUtils.FromAPIResult(_api.GetTokens());
        }

        public DataNode GetTokenBalance(string address, string tokenSymbol, string chain)
        {
            return APIUtils.FromAPIResult(_api.GetTokenBalance(address, tokenSymbol, chain));
        }

        public DataNode GetTokenTransfers(string tokenSymbol, int amount)
        {
            return APIUtils.FromAPIResult(_api.GetTokenTransfers(tokenSymbol, amount));
        }

        public DataNode GetTokenTransferCount(string tokenSymbol)
        {
            return APIUtils.FromAPIResult(_api.GetTokenTransferCount(tokenSymbol));
        }

        public DataNode SendRawTransaction(string signedTx)
        {
            return APIUtils.FromAPIResult(_api.SendRawTransaction(signedTx));
        }

    }
}
