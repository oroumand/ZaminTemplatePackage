using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;
using ZaminTemplate.Endpoints.API.Extentions.DependencyInjection.Swaggers.Extentions;
using ZaminTemplate.Endpoints.API.Extentions.DependencyInjection.Swaggers.Filters;
using ZaminTemplate.Endpoints.API.Extentions.DependencyInjection.Swaggers.Options;

namespace ZaminTemplate.Endpoints.API.Extentions.DependencyInjection.Swaggers.Extentions;

public static class SwaggerExtentions
{
    public static IServiceCollection AddSwagger(this IServiceCollection services, IConfiguration configuration, string sectionName)
    {
        var swaggerOption = configuration.GetSection(sectionName).Get<SwaggerOption>();

        if (swaggerOption != null && swaggerOption.SwaggerDoc != null && swaggerOption.Enabled == true)
        {
            services.AddSwaggerGen(o =>
            {
                o.SwaggerDoc(swaggerOption.SwaggerDoc.Name, new OpenApiInfo
                {
                    Title = swaggerOption.SwaggerDoc.Title,
                    Version = swaggerOption.SwaggerDoc.Version
                });

                var oAuthOption = configuration.GetSection("OAuth").Get<SwaggerOAuthOption>();
                if (oAuthOption != null && oAuthOption.Enabled)
                {
                    o.AddSecurityDefinition("Oauth2", new OpenApiSecurityScheme
                    {
                        Name = "Authorization",
                        Description = "Oauth2",
                        BearerFormat = "Bearer <token>",
                        In = ParameterLocation.Header,
                        Type = SecuritySchemeType.OAuth2,
                        Flows = new OpenApiOAuthFlows
                        {
                            AuthorizationCode = new OpenApiOAuthFlow
                            {
                                AuthorizationUrl = new Uri(oAuthOption.AuthorizationUrl),
                                TokenUrl = new Uri(oAuthOption.TokenUrl),
                                Scopes = oAuthOption.Scopes
                            }
                        },
                    }); ;

                    o.OperationFilter<AddParamsToHeader>();
                }
            });
        }

        return services;
    }

    public static void UseSwaggerUI(this WebApplication app, string sectionName)
    {
        var swaggerOption = app.Configuration.GetSection(sectionName).Get<SwaggerOption>();

        if (swaggerOption != null && swaggerOption.SwaggerDoc != null && swaggerOption.Enabled == true)
        {
            app.UseSwagger();
            app.UseSwaggerUI(delegate (SwaggerUIOptions c)
            {
                c.SwaggerEndpoint(swaggerOption.SwaggerDoc.URL, swaggerOption.SwaggerDoc.Title);
                c.RoutePrefix = string.Empty;
                c.OAuthUsePkce();
            });
        }
    }
}
