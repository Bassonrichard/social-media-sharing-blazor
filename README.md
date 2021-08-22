# Social Media Sharing Blazor
Blazor class library that enables you to access the native web social media sharing functionality using C#

### Quick Installation Guide

Install Package
``` 
dotnet add package SocialMediaSharingBlazor
```

Add the following to the top of component you want to use it on:
```razor
@using SocialMediaSharing

@Inject SocialMediaSharing
```

### Usage
``` html

<button class="btn btn-primary" @onclick="Share">Click me</button>

@code {
    private void Share()
    {
        socialMediaSharing.ShareOnSocialMedia(title: "", 
                                              text: "Check out this blazor library that helps you share on social media using c#", 
                                              url: "https://www.nuget.org/packages/SocialMediaSharing/");
    }
}

```