using Microsoft.Extensions.DependencyInjection;

namespace SocialMediaSharingBlazor
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSocialMediaSharing(this IServiceCollection services)
        {
            return services.AddScoped<SocialMediaSharing>();
        }
    }
}
