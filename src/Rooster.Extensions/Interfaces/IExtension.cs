using Microsoft.Framework.ConfigurationModel;
using System;
using System.Collections.Specialized;

using Rooster.Extensions.ExtensionConfig;

namespace Rooster.Extensions.Interfaces
{
    public interface IExtension
    {
        void Initialize(RepositoryExtensionFactory.ExtensionEvents events, IConfiguration config);
    }
}