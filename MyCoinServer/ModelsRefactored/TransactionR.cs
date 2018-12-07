using MyCoinData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCoinServer.ModelsRefactored
{
    using System.Collections.ObjectModel;
    using System.Windows;
    using System.Windows.Media;

    using Type = MyCoinData.Models.Type;

    public class TransactionR
    {
        public Transaction Transaction { get; set; }

        public Visibility DestinationVisibility { get; set; }

        public string IconType { get; set; }

        public Brushes BackgroundColor { get; set; }

        public TransactionR(Transaction transaction)
        {
            Transaction = transaction;
            VerifyType();
        }

        private void VerifyType()
        {
            var converter = new System.Windows.Media.BrushConverter();
            if (this.Transaction.Type == Type.Dépot)
            {
                IconType = "../Ressources/LeftTranfert.png";
                BackgroundColor =(Brushes)converter.ConvertFromString("#3a56d1");
                DestinationVisibility = Visibility.Hidden;
            }
            else if(this.Transaction.Type == Type.Transfert)
            {
                IconType = "../Ressources/Down.png";
                BackgroundColor = (Brushes)converter.ConvertFrom(Brushes.BlueViolet);
                DestinationVisibility = Visibility.Visible;
            }
        }

        public static ObservableCollection<TransactionR> GetListOfTransactionRs(List<Transaction> transactions)
        {
            ObservableCollection<TransactionR> finish= new ObservableCollection<TransactionR>();
            transactions.ForEach((t)=>{finish.Add(new TransactionR(t));});
            return finish;
        }
    }
}
