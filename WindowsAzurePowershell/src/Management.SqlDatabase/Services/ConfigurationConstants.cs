﻿// ----------------------------------------------------------------------------------
//
// Copyright 2011 Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Management.SqlDB
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;

    public static class ConfigurationConstants
    {
        public const string SqlAzureManagementEndpoint = "https://management.database.windows.net:8443";

        public static Binding WebHttpBinding()
        {
            const int MAX = 5000000;

            var binding = new WebHttpBinding(WebHttpSecurityMode.Transport);
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Certificate;
            binding.ReaderQuotas.MaxStringContentLength = 67108864;
            binding.MaxBufferSize = MAX;
            binding.MaxReceivedMessageSize = MAX;
            binding.ReaderQuotas.MaxArrayLength = MAX;

            return binding;
        }
    }
}