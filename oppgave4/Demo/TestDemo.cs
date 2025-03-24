using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class TestDemo
    {
        public async Task<ICollection<int>> GetNumbers()
        {
            var list = new List<int> { 1, 2, 3, 5, 6, 7 };
            return await Task.FromResult(list);
        }
    }
}
