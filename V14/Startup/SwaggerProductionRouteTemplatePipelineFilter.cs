using Umbraco.Cms.Api.Common.OpenApi;

namespace Umbraco14.Startup;

public class SwaggerProductionRouteTemplatePipelineFilter() : SwaggerRouteTemplatePipelineFilter("umbraco")
{
    protected override bool SwaggerIsEnabled(IApplicationBuilder applicationBuilder) => true;
}
