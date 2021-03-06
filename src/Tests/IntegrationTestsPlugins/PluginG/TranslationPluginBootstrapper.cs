﻿using Dictionary.Domain;
using Microsoft.Extensions.DependencyInjection;
using Prise.Plugin;

namespace PluginG
{
    [PluginBootstrapper(PluginType = typeof(TranslationPlugin))]
    public class TranslationPluginBootstrapper : IPluginBootstrapper
    {
        public IServiceCollection Bootstrap(IServiceCollection services)
        {
            services.AddScoped<IDictionaryService, DictionaryService>();
            return services;
        }
    }
}
