﻿public class GenericClass<T>
{
    private readonly T _value;

    public GenericClass(T value)
    {
        _value = value;
    }

    public T GetValue()
    {
        return _value;
    }
}

