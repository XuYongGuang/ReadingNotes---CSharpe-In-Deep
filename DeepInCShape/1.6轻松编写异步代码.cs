using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 深入理解CShape
{
    public class 轻松编写异步代码
    {
        class directory
        {
            public static async Task<Product> LookupProductAsync(string id)
            {
                return new Product();
            }
        }

        class warehouse
        {
            public static async Task<int> LookupStockLevelAsync(string id)
            {
                return 0;
            } 
        }

        private async void CheckProduct(object sender, EventArgs e)
        {
            try
            {
                string id = "";
                Task<Product> productLookup = directory.LookupProductAsync(id);
                Task<int> stockLookup = warehouse.LookupStockLevelAsync(id);
                Product product = await productLookup;//等待获取产品信息
                if(product == null)
                    return;

                int stock = await stockLookup;  //等待获取库存信息
            }
            catch (Exception)
            {
                
                throw;
            }
        }

       
    }
}
