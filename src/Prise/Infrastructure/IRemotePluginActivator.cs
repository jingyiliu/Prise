using Prise.Plugin;
using System;
using System.Reflection;

namespace Prise.Infrastructure
{
    public interface IRemotePluginActivator : IDisposable
    {
        object CreateRemoteBootstrapper(Type bootstrapperType, Assembly assembly);
        object CreateRemoteInstance(PluginActivationContext pluginActivationContext, IPluginBootstrapper bootstrapper = null);
    }
}