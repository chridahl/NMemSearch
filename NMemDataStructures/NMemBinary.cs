using System;
using NMemDataStructures.Interfaces;

namespace NMemDataStructures
{
    public class NMemBinary : INMemDataValue<byte[]>
    {
        private byte[] _bytes;
        private DateTime _lastChanged;
        private byte[] bytes
        {
            get
            {
                _lastChanged = DateTime.Now;
                return _bytes;
            }
            set
            {
                _bytes = value;
            }
        }

        public NMemBinary()
        {
            bytes = new byte[] { };
        }

        public NMemBinary(byte[] dataValue)
        {
            bytes = dataValue;
        }

        public void Append(byte[] dataValue)
        {
            var currentSize = bytes.Length;
            var newArraySize = currentSize + dataValue.Length;

            Array.Resize<byte>(ref _bytes, newArraySize);

            for (long n = 0; n < dataValue.Length; n++)
            {
                bytes[currentSize + n] = dataValue[n];
            }

        }

        public void ClearValues()
        {
            bytes = new byte[]{};
        }

        public byte[] GetValue()
        {
            return bytes;
        }

        public void Insert(byte[] dataValue)
        {
            bytes = dataValue;
        }

        public DateTime GetPreviousChangeTime()
        {
            return _lastChanged;
        }
    }
}
