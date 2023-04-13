using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Api.Example.With.Many.Features.Rest.ApplicationBuilders
{
    public static class SwaggerBuilder
    {
        public static IApplicationBuilder UseCustomSwagger(this IApplicationBuilder builder)
        {
            builder.UseSwagger();

            var apiVersionDescriptionProvider = builder.ApplicationServices.GetRequiredService<IApiVersionDescriptionProvider>();

            builder.UseSwaggerUI(options =>
            {
                foreach (var description in apiVersionDescriptionProvider.ApiVersionDescriptions)
                {
                    options.SwaggerEndpoint($"/swagger/{description.GroupName}/swagger.json",
                        description.GroupName.ToUpperInvariant());
                }
            });

            return builder;
        }
    }
}
