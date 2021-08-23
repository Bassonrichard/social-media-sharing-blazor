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

export function shareFileOnSocialMedia(title, text, filesArray) {
    if (navigator.canShare && navigator.canShare({ files: filesArray })) {
        navigator.share({
            files: filesArray,
            title: title,
            text: text,
        })
            .then(() => console.log('Share was successful.'))
            .catch((error) => console.log('Sharing failed', error));
    } else {
        console.log(`Your system doesn't support sharing files.`);
    }
}