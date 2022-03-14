using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace PowerUp.MVC.Config
{
    public static class ApplicationBuilderExtensions
    {
        public static void DefinaIdioma(this IApplicationBuilder app)
        {
            var defaultDateCulture = "pt-BR";
            var ci = new CultureInfo(defaultDateCulture);
            ci.NumberFormat.NumberDecimalSeparator = ".";
            ci.NumberFormat.CurrencyDecimalSeparator = ".";
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(ci),
                SupportedCultures = new List<CultureInfo> { ci, },
                SupportedUICultures = new List<CultureInfo> { ci, }
            });
        }
    }
}
