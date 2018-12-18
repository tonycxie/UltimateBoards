$(document).ready(function() {
    $.ajax({
        method: "GET",
        url: 'https://api.twitch.tv/kraken/search/streams?query=smash bros ultimate&limit=10',
        headers: {
            "Client-ID": "i0gcva3x1ue9yfivg7rrwkv6s6i4c7", // don't forget to delete this
            "Accept": "application/vnd.twitchtv.v5+json"
        },
        success: function(response) {
            console.log(response);
            $("#main-stream").html(`
                <iframe
                    src='https://player.twitch.tv/?channel=${response.streams[0].channel.name}&autoplay=true'
                    height='720'
                    width='1280'
                    frameborder='0'
                    scrolling='no'
                    allowfullscreen='true'>
                </iframe>
            `);
            for (let i = 1; i < response.streams.length; i++) {
                $("#other-streams").append(`
                    <iframe
                        src='https://player.twitch.tv/?channel=${response.streams[i].channel.name}&autoplay=false'
                        height='300'
                        width='400'
                        frameborder='0'
                        scrolling='no'
                        allowfullscreen='true'>
                    </iframe>
                `);
            }
        },
        error: function(error) {
            console.log("There was an error:", error);
        }
    })
})