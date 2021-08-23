using System.Threading.Tasks;

namespace SocialMediaSharingBlazor
{
    public interface ISocialMediaSharing
    {
        ValueTask<string> ShareOnSocialMedia(string title, string text, string url);
    }
}
