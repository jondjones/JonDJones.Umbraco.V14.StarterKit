using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Api.Management.Controllers;
using Umbraco.Cms.Api.Management.Routing;

namespace Umbraco14.Controller;

[VersionedApiBackOfficeRoute("customAPI")]
[ApiExplorerSettings(GroupName = "Custom Group")]
public class MyItemApiController : ManagementApiControllerBase
{
    public MyItemApiController()
    {

        throw new NotImplementedException();
    }

    [HttpGet]
    public IActionResult MyEndPoint() => Ok();
}

