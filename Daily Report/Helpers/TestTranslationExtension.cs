using Plugin.Multilingual;
using System;
using System.Reflection;
using System.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Daily_Report.Helpers
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        const string ResourceId = "Daily_Report.Resources.AppResources";

        static readonly Lazy<ResourceManager> resmgr = new Lazy<ResourceManager>(() => new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));

        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Text == null)
                return "";

            return Translation.Translate(Text);
        }
    }

    public static class Translation
    {
        const string ResourceId = "Daily_Report.Resources.AppResources";
        static readonly Lazy<ResourceManager> resmgr = new Lazy<ResourceManager>(
            () => new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly));

        public static string Translate(string textToTranslate)
        {
            var ci = CrossMultilingual.Current.CurrentCultureInfo;

            var translation = resmgr.Value.GetString(textToTranslate, ci);
            if (translation == null)
            {
#if DEBUG
                throw new ArgumentException(
                    String.Format("Key '{0}' was not found in resources '{1}' for culture '{2}'.", textToTranslate, ResourceId, ci.Name),
                    "Text");
#else
                translation = textToTranslate; // returns the key, which GETS DISPLAYED TO THE USER
#endif
            }

            return translation;
        }
    }
}