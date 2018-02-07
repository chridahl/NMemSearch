using System;

namespace NMemDataStructures.Interfaces
{
    public interface INMemDataValue<T>
    {
        void Insert(T dataValue);
        void Append(T dataValue);
        void ClearValues();
        T GetValue();
        DateTime GetPreviousChangeTime();
    }
}

