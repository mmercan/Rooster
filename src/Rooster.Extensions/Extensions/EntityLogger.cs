using System;
using Microsoft.Framework.ConfigurationModel;
using System.Diagnostics;

using Rooster.Extensions.Interfaces;
using Rooster.Extensions.ExtensionConfig;

namespace Rooster.Extensions
{
    public class EntityLogger : IExtension
    {
        public void Initialize(RepositoryExtensionFactory.ExtensionEvents events, IConfiguration config)
        {
            events.AddtoActionStarting((e) => {
                Debug.WriteLine("[Action Starting] [LOGGED] "+e.Entity.ToString() + " " + e.Action.ToString());
               
            });

            events.AddtoActionStared((e) => {
                Debug.WriteLine("[Action Completing] [LOGGED] " + e.Entity.ToString() + " " + e.Action.ToString());

            });


            //  events.CallEntityProcessed
        }
    }
}