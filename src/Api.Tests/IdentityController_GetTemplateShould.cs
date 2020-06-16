using System;
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
            var result = _identityController.GetTemplate();
            Assert.NotNull(result);
        }
    }
}
