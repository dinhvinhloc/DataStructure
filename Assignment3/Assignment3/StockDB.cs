using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    public class StockDB
    {
        public Dictionary<string, StockItem> stockList = null;
        public StockDB()
        {
            stockList = new Dictionary<string, StockItem>();
        }

        public bool AddStockItem(StockItem stockItem)
        {
            if (stockList.ContainsKey(stockItem.Code))
                return false;
            stockList.Add(stockItem.Code, stockItem);
            return true;
        }

        public bool UpdateStockItem(StockItem stockItem)
        {
            if (stockList.ContainsKey(stockItem.Code))
            {
                StockItem tempStockItem = new StockItem();
                stockList.TryGetValue(stockItem.Code, out tempStockItem);
                stockList.Remove(stockItem.Code);
                if(stockItem.Name == "")
                {
                    stockItem.Name = tempStockItem.Name;
                }
                stockList.Add(stockItem.Code, stockItem);
                return true;
            }
            else
                return false;
        }

        public StockItem findByName(String name)
        {
            StockItem[] tempArray = stockList.Values.ToArray<StockItem>();
            StockItem tempStockItem = new StockItem();
            foreach (StockItem stockItem in tempArray)
            {
                if (stockItem.Name == name)
                {
                    stockList.TryGetValue(stockItem.Code, out tempStockItem);
                    return tempStockItem;
                }
            }
            return null;
        }

        public StockItem findByCode(String code)
        {
            StockItem tempStockItem = new StockItem();
            if (stockList.ContainsKey(code))
            {
                stockList.TryGetValue(code, out tempStockItem);
                return tempStockItem;
            }
            else return null;
        }

        public StockItem[] GetStockItems()
        {
            return stockList.Values.ToArray<StockItem>();
        }
    }


}
