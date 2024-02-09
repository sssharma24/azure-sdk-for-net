// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> MariaDB server linked service. </summary>
    public partial class MariaDBLinkedService : DataFactoryLinkedServiceProperties
    {
        /// <summary> Initializes a new instance of <see cref="MariaDBLinkedService"/>. </summary>
        public MariaDBLinkedService()
        {
            LinkedServiceType = "MariaDB";
        }

        /// <summary> Initializes a new instance of <see cref="MariaDBLinkedService"/>. </summary>
        /// <param name="linkedServiceType"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="driverVersion"> The version of the MariaDB driver. Type: string. V1 or empty for legacy driver, V2 for new driver. V1 can support connection string and property bag, V2 can only support connection string. </param>
        /// <param name="connectionString"> An ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </param>
        /// <param name="server"> Server name for connection. Type: string. </param>
        /// <param name="port"> The port for the connection. Type: integer. </param>
        /// <param name="username"> Username for authentication. Type: string. </param>
        /// <param name="database"> Database name for connection. Type: string. </param>
        /// <param name="password"> The Azure key vault secret reference of password in connection string. </param>
        /// <param name="encryptedCredential"> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </param>
        internal MariaDBLinkedService(string linkedServiceType, IntegrationRuntimeReference connectVia, string description, IDictionary<string, EntityParameterSpecification> parameters, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties, DataFactoryElement<string> driverVersion, DataFactoryElement<string> connectionString, DataFactoryElement<string> server, DataFactoryElement<int> port, DataFactoryElement<string> username, DataFactoryElement<string> database, DataFactoryKeyVaultSecretReference password, string encryptedCredential) : base(linkedServiceType, connectVia, description, parameters, annotations, additionalProperties)
        {
            DriverVersion = driverVersion;
            ConnectionString = connectionString;
            Server = server;
            Port = port;
            Username = username;
            Database = database;
            Password = password;
            EncryptedCredential = encryptedCredential;
            LinkedServiceType = linkedServiceType ?? "MariaDB";
        }

        /// <summary> The version of the MariaDB driver. Type: string. V1 or empty for legacy driver, V2 for new driver. V1 can support connection string and property bag, V2 can only support connection string. </summary>
        public DataFactoryElement<string> DriverVersion { get; set; }
        /// <summary> An ODBC connection string. Type: string, SecureString or AzureKeyVaultSecretReference. </summary>
        public DataFactoryElement<string> ConnectionString { get; set; }
        /// <summary> Server name for connection. Type: string. </summary>
        public DataFactoryElement<string> Server { get; set; }
        /// <summary> The port for the connection. Type: integer. </summary>
        public DataFactoryElement<int> Port { get; set; }
        /// <summary> Username for authentication. Type: string. </summary>
        public DataFactoryElement<string> Username { get; set; }
        /// <summary> Database name for connection. Type: string. </summary>
        public DataFactoryElement<string> Database { get; set; }
        /// <summary> The Azure key vault secret reference of password in connection string. </summary>
        public DataFactoryKeyVaultSecretReference Password { get; set; }
        /// <summary> The encrypted credential used for authentication. Credentials are encrypted using the integration runtime credential manager. Type: string. </summary>
        public string EncryptedCredential { get; set; }
    }
}
