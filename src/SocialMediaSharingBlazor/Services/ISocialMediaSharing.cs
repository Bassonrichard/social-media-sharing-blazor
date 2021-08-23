using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SocialMediaSharingBlazor
{
    public interface ISocialMediaSharing
    {
        ValueTask<string> ShareOnSocialMedia(string title, string text, string url);

        ValueTask<string> ShareFileOnSocialMedia(string title, string text, List<IBrowserFile> files);
    }
}
