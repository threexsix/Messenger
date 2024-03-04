using System;
using Itmo.ObjectOrientedProgramming.Lab3.Exceptions;

namespace Itmo.ObjectOrientedProgramming.Lab3.Models;

public class PriorityLevel
{
    private const int MinValue = 0;
    public PriorityLevel(int value)
    {
        if (value < MinValue)
            throw new PriorityValueException("PriorityLevel should be above zero");
        Value = value;
    }

    public int Value { get; }

    public static bool operator >(PriorityLevel? left, PriorityLevel? right)
    {
        if ((left != null) && (right != null)) return left.Value > right.Value;
        return false;
    }

    public static bool operator <(PriorityLevel? left, PriorityLevel? right)
    {
        if ((left != null) && (right != null)) return left.Value < right.Value;
        return false;
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (obj is PriorityLevel otherPriorityLevel)
            return Value.CompareTo(otherPriorityLevel.Value);
        else
            throw new ArgumentException("Object is not a PriorityLevel");
    }

    public bool Equals(PriorityLevel? other)
    {
        return other != null && Value.Equals(other.Value);
    }

    public override bool Equals(object? obj)
    {
        return obj is not null &&
               (ReferenceEquals(this, obj) || (obj is PriorityLevel otherPriorityLevel && Equals(otherPriorityLevel)));
    }

    public override int GetHashCode()
    {
        return Value.GetHashCode();
    }
}