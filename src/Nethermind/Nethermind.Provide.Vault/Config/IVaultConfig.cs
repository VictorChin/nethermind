//  Copyright (c) 2020 Demerzel Solutions Limited
//  This file is part of the Nethermind library.
// 
//  The Nethermind library is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  The Nethermind library is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU Lesser General Public License for more details.
// 
//  You should have received a copy of the GNU Lesser General Public License
//  along with the Nethermind. If not, see <http://www.gnu.org/licenses/>.
using Nethermind.Config;

namespace Nethermind.Vault.Config
{
    [ConfigCategory(Description = "Configuration of the Vault integration with Nethermind")]
    public interface IVaultConfig : IConfig
    {
        [ConfigItem(Description = "If 'true' then the Vault is enabled", DefaultValue = "false")]
        bool Enabled { get; set; }

        [ConfigItem(Description = "Address of the Vault service endpoint", DefaultValue = "vault.provide.services")]
        string Host { get; set; }

        [ConfigItem(Description = "Authorization token required to access Provide Services Vault", DefaultValue = "null")]
        string Token { get; set; }

        [ConfigItem(Description = "The Vault's URI scheme", DefaultValue = "https")]
        string Scheme { get; set; }

        [ConfigItem(Description = "Path to the Vault's api", DefaultValue = "api/v1")]
        string Path { get; set; }

        [ConfigItem(Description = "VaultId of the Vault that will be used for key/secrets storage", DefaultValue = "null")]
        string VaultId { get; set; }

        [ConfigItem(Description = "The file with Vault's passphrase for sealing and unsealing", DefaultValue = "null")]
        string VaultKeyFile { get; set; }

        string VaultSealUnsealKey { get; set; }

        [ConfigItem(Description = "Address of the Nchain service endpoint", DefaultValue = "vault.provide.services")]
        string NChainHost { get; set; }

        [ConfigItem(Description = "Authorization token required to access Provide Services Nchain", DefaultValue = "null")]
        string NChainToken { get; set; }

        [ConfigItem(Description = "The Nchain'd URI scheme", DefaultValue = "https")]
        string NChainScheme { get; set; }

        [ConfigItem(Description = "Path to the Nchain'd api", DefaultValue = "api/v1")]
        string NChainPath { get; set; }

        string NChainNetworkId { get; set; }

        string NChainAccountId { get; set; }
    }
}
