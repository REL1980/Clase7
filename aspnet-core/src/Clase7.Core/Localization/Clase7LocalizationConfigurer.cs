using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Clase7.Localization
{
    public static class Clase7LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Clase7Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Clase7LocalizationConfigurer).GetAssembly(),
                        "Clase7.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
