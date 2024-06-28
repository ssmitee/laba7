using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductStackApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductStack productStack = new ProductStack();

        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик для добавления товара в стек
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            var productName = ProductNameTextBox.Text;
            var productPrice = decimal.Parse(ProductPriceTextBox.Text);
            var product = new Product(productName, productPrice);

            productStack.Push(product);
            MessageBox.Show("Товар добавлен в стек");
        }

        // Обработчик для отображения товаров и вычисления средней цены
        private void DisplayProductsButton_Click(object sender, RoutedEventArgs e)
        {
            productStack.DisplayAll();
            var averagePrice = productStack.CalculateAveragePrice();
            MessageBox.Show($"Средняя цена товаров: {averagePrice}");
        }
    }
}