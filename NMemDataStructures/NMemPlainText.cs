using System;
using System.Text;
using NMemDataStructures.Interfaces;

namespace NMemDataStructures
{
    public class NMemPlainText : INMemDataValue<StringBuilder>
    {
        private StringBuilder _text;
        private DateTime _lastChanged;
        private StringBuilder text 
        {
            get {                
                _lastChanged = DateTime.Now;
                return _text;
            }
            set {
                _text = value;
            }
        }

        public NMemPlainText()
        {
            text = new StringBuilder();
        }

        public NMemPlainText(string textValue)
        {
            text = new StringBuilder(textValue);
        }

        public void Append(StringBuilder dataValue)
        {
            text.Append(dataValue.ToString());
        }

        public void ClearValues()
        {
            text.Clear();
        }

        public StringBuilder GetValue()
        {
            return text;
        }

        public void Insert(StringBuilder dataValue)
        {
            text = dataValue;
        }

        public DateTime GetPreviousChangeTime()
        {
            return _lastChanged;
        }
    }
}
