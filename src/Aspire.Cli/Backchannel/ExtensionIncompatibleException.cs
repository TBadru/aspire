// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Aspire.Cli.Backchannel;

internal class ExtensionIncompatibleException(string message, string requiredCapability) : Exception(message)
{
    public string RequiredCapability { get; } = requiredCapability;
}
