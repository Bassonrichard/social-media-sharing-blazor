using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace SocialMediaSharingBlazor
{
    public class SocialMediaSharing : IAsyncDisposable, ISocialMediaSharing
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;

        public SocialMediaSharing(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
               "import", "./_content/SocialMediaSharingBlazor/socialMediaSharing.js").AsTask());
        }

        public async ValueTask<string> ShareOnSocialMedia(string title, string text, string url)
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<string>("shareOnSocialMedia", title, text, url);
        }

        public async ValueTask<bool> CanShareOnSocialMedia()
        {
            var module = await moduleTask.Value;
            return await module.InvokeAsync<bool>("canShareOnSocialMedia");
        }

        public async ValueTask DisposeAsync()
        {
            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
