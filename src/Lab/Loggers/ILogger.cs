﻿using Itmo.ObjectOrientedProgramming.Lab3.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers;

public interface ILogger
{
    public void Log(IMessage message);
}