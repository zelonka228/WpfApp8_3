using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp8_3
{

    public partial class Window1 : Window
    {
        public Window1(ListBox incomeList, ListBox expenseList)
        {
            InitializeComponent();

            double incomeTotal = 0;
            double expenseTotal = 0;

            foreach (Note note in incomeList.Items)
            {
                incomeTotal += note.Amount;
            }

            foreach (Note note in expenseList.Items)
            {
                expenseTotal += note.Amount;
            }

            double balance = incomeTotal - expenseTotal;

            incomeSum.Text = incomeTotal + " грн";
            expenseSum.Text = expenseTotal + " грн";
            balanceSum.Text = balance + " грн";
        }
    }
}
