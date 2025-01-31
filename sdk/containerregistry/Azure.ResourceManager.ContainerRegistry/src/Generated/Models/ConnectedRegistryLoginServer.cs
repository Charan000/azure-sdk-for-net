// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The login server properties of the connected registry. </summary>
    public partial class ConnectedRegistryLoginServer
    {
        /// <summary> Initializes a new instance of ConnectedRegistryLoginServer. </summary>
        public ConnectedRegistryLoginServer()
        {
        }

        /// <summary> Initializes a new instance of ConnectedRegistryLoginServer. </summary>
        /// <param name="host"> The host of the connected registry. Can be FQDN or IP. </param>
        /// <param name="tls"> The TLS properties of the connected registry login server. </param>
        internal ConnectedRegistryLoginServer(string host, TlsProperties tls)
        {
            Host = host;
            Tls = tls;
        }

        /// <summary> The host of the connected registry. Can be FQDN or IP. </summary>
        public string Host { get; }
        /// <summary> The TLS properties of the connected registry login server. </summary>
        public TlsProperties Tls { get; }
    }
}
