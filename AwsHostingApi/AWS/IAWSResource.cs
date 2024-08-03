namespace AwsHostingApi.AWS
{
    public interface IAWSResource
    {
        bool ValidateResource(string resource);

        bool ValidateEndpoint(string endpoint);

        bool CreateResource(string resource);
    }
}