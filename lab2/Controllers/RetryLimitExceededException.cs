﻿using System;
using System.Runtime.Serialization;

[Serializable]
internal class RetryLimitExceededException : Exception
{
    public RetryLimitExceededException()
    {
    }

    public RetryLimitExceededException(string message) : base(message)
    {
    }

    public RetryLimitExceededException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected RetryLimitExceededException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}