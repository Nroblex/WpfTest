using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfTest.Model;

namespace WpfTest.ViewModel
{
    public class Presenter : ObservableObject
    {
        private readonly TextConverter mTextConverter = new TextConverter(s => s.ToUpper());
        private string mSomeText;

        private readonly ObservableCollection<string> mHistory =
            new ObservableCollection<string>();

        public string SomeText
        {
            get { return mSomeText; }
            set
            {
                mSomeText = value;
                RaisePropertyChangedEvent("SomeText");
            }
        }

        public IEnumerable<string> History
        {
            get { return mHistory; }
        }

        public ICommand ConvertTextCommand
        {
            get { return new DelegateCommand(ConvertText); }
        }

        private void ConvertText()
        {
            if (string.IsNullOrWhiteSpace(SomeText)) return;
            AddToHistory(mTextConverter.TextConvert(SomeText));
            SomeText = string.Empty;
        }

        private void AddToHistory(string item)
        {
            if (!mHistory.Contains(item))
                mHistory.Add(item);
        }


    }
}
