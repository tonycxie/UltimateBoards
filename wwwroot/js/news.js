$(document).ready(function() {
    $.ajax({
        method: "GET",
        url: 'https://www.reddit.com/r/smashbros/.json?sort=hot&limit=10',
        success: function(response) {
            console.log(response);
            let posts = response["data"]["children"];
            for (let i = 2; i < posts.length; i++) {
                $(".news-feed").append(`
                    <div class="section-content">
                        <div class="section-content__img-box">
                            <img src="${posts[i]['data']['preview']['images'][0]['source']['url']}" alt="" class="section-content__img">
                        </div>
                        <div class="section-content__text-box">
                            <h2 class="section-content__text-box__header"><a class="link" target="_blank" href="${posts[i]['data']['url']}">${posts[i]['data']['title']}</a></h2>
                            <p class="posted-date">Saturday at 6:49pm</p>
                            <p class="post-summary">
                                Today, Patch 1.2.0 for Super Smash Bros. Ultimate was released, notably two days after the patch’s announcement on December 11th, 2018.
                            </p>
                        </div>
                    </div>
                `);
            }
        }
    });
});