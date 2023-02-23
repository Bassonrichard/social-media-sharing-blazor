// This is a JavaScript module that is loaded on demand. It can export any number of
// functions, and may import other JavaScript modules if required.

export function shareOnSocialMedia(title, text, url) {
    navigator.share({
        title: title,
        text: text,
        url: url,
    })
    .then(() => console.log('Successful share'))
    .catch((error) => console.log('Error sharing', error));
}

export function canShareOnSocialMedia() {
    return navigator.canShare;
}
