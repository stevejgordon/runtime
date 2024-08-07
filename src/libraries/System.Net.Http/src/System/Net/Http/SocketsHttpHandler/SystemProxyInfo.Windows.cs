// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.Net.Http
{
    internal static partial class SystemProxyInfo
    {
        // On Windows we get default proxy configuration from either environment variables or the Windows system proxy.
        public static IWebProxy ConstructSystemProxy()
        {
            if (!HttpEnvironmentProxy.TryCreate(out IWebProxy? proxy))
            {
                // We create instance even if there is currently no proxy as that can change during application run.
                proxy = new HttpWindowsProxy();
            }

            return proxy;
        }
    }
}
