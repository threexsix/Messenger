using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees;

public class AddresseeGroup : IAddressee
{
    private readonly List<IAddressee> _addressees;

    public AddresseeGroup(IEnumerable<IAddressee> addressees)
    {
        _addressees = new List<IAddressee>(addressees);
    }

    public void ReceiveMessage(IMessage message)
    {
        ArgumentNullException.ThrowIfNull(message);

        foreach (IAddressee addressee in _addressees)
            addressee.ReceiveMessage(message);
    }
}