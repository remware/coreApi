using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Api.Tests
{
    public class IdentityController_GetTemplateShould
    {
        private readonly IdentityController _identityController;

        public IdentityController_GetTemplateShould() 
        {
            _identityController = new IdentityController();
        }
        [Fact]
        public void GetTemplateShould_ReturnOkResult()
        {
            IActionResult result = _identityController.GetTemplate();
            var fileResult = Assert.IsType<PhysicalFileResult>(result);
            Assert.Equal("text/csv", fileResult.ContentType);
        }
    }
}
