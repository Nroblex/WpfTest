using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTest.Model
{
    public class TextConverter
    {
        private readonly Func<string, string> mConvertion;
        public TextConverter(Func<string, string> convertion)
        {
            mConvertion = convertion;
        }

        public string TextConvert(string InputText)
        {
            return mConvertion(InputText);
        }

    }
}
