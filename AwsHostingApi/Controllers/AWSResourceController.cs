using Amazon.CDK;
using AwsHostingApi.AWS;
using Microsoft.AspNetCore.Mvc;

namespace AwsHostingApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AWSResourceController : ControllerBase
    {


        [HttpPost]
        public IActionResult CreateResource(string resource)
        {
            var app = new App();
            new AWSResource(app, "CdkVpcSampleStack", new StackProps
            {
                // If you don't specify 'env', this stack will be environment-agnostic.
                // Account/Region-dependent features and context lookups will not work,
                // but a single synthesized template can be deployed anywhere.

                // Uncomment the next block to specialize this stack for the AWS Account
                // and Region that are implied by the current CLI configuration.
                /*
                Env = new Amazon.CDK.Environment
                {
                    Account = System.Environment.GetEnvironmentVariable("CDK_DEFAULT_ACCOUNT"),
                    Region = System.Environment.GetEnvironmentVariable("CDK_DEFAULT_REGION"),
                }
                */

                // Uncomment the next block if you know exactly what Account and Region you
                // want to deploy the stack to.

                Env = new Amazon.CDK.Environment
                {
                    Account = "", //fill in your account here
                    Region = "us-east-1", //fill in the region you plan to use
                }


                // For more information, see https://docs.aws.amazon.com/cdk/latest/guide/environments.html
            });

            app.Synth();

            return Ok("");
        }
    }
}
