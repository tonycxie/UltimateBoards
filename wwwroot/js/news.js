$(document).ready(function() {
    $.ajax({
        method: "GET",
        url: 'https://www.reddit.com/r/smashbros/.json?sort=hot&limit=10',
        success: function(response) {
            console.log(response);
            let posts = response["data"]["children"];
            for (let i = 2; i < posts.length; i++) {
                $("#news-container").append(`
                    <h2>${posts[i]['data']['title']}</h2>
                    <img src='${posts[i]['data']['preview']['images'][0]['source']['url']}'>
                `);
            }
        }
    });
});