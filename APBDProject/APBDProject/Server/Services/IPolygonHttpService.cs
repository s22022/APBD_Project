﻿using APBDProject.Shared.Models;
using APBDProject.Shared.Models.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public interface IPolygonHttpService
    {
        public Task<IEnumerable<StockDTO>> GetSearchedStocks(string regex);
        public Task<StockInfo> GetStockInfo(string symbol);
        public Task<bool> PostStockInfo(StockInfoOHLC stock);
        public Task<IEnumerable<StockPriceDate>> GetStockPrices(string symbol);
       // public Task<StockPriceDate> GetStockPrices(string symbol);

    }
}