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

namespace WpfApp8_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var selected = typeBox.SelectedItem as ComboBoxItem;
            string type = selected.Content.ToString();

            var note = new Note
            {
                Amount = Convert.ToDouble(amountInput.Text),
                Description = descriptionInput.Text,
                CreatedAt = DateTime.Now,
                Type = type
            };

            if (type == "Доход")
                incomeList.Items.Add(note);
            else
                expenseList.Items.Add(note);

            amountInput.Clear();
            descriptionInput.Clear();
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            var window = new Window1(incomeList, expenseList);
            window.ShowDialog();
        }
    }

}
