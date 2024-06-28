using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProductStackApp
{
    public class ProductStack
    {
        private Stack<Product> stack = new Stack<Product>();

        public void Push(Product product)
        {
            stack.Push(product);
        }
        public void DisplayAll()
        {
            foreach (var product in stack)
            {
                MessageBox.Show($"Наименование: {product.Name}, Цена: {product.Price}");
            }
        }

        public decimal CalculateAveragePrice()
        {
            if (stack.Count == 0)
                return 0;

            return stack.Average(product => product.Price);
        }
    }

}
