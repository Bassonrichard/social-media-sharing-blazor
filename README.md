# Social Media Sharing Blazor
Blazor class library that enables you to access the native web social media sharing functionality using C#.
The library wraps the PWA web share functionality on which you can read more here: 
https://web.dev/web-share/

## Browser Support

Details on browser support can be found here:

https://developer.mozilla.org/en-US/docs/Web/API/Navigator/share#browser_compatibility

## Quick Installation Guide

* Install Package

    `dot net cli`

    ``` 
    dotnet add package SocialMediaSharingBlazor
    ```

    or 
   
   `Package Manager`

   ```
   Install-Package SocialMediaSharingBlazor
   ```

* Add the following to the relevant sections of `Program.cs`
  ```c#
  using SocialMediaSharingBlazor;
  ```
  ```c#
  builder.Services.AddSocialMediaSharing();
  ```

* Add the following to the top of component you want to use it on:
  ``` razor
  @using SocialMediaSharingBlazor;

  @inject ISocialMediaSharing socialMediaSharing;
  ```

## Usage
``` html

<button class="btn btn-primary" @onclick="Share">Click me</button>

@code {
    private void Share()
    {
        socialMediaSharing.ShareOnSocialMedia(
        title: "Social Media Sharing Blazor", 
        text: "Check out this blazor library that helps you share on social media using c#", 
        url: "https://www.nuget.org/packages/SocialMediaSharingBlazor/");
    }
}

```