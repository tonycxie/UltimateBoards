$(document).ready(function() {
    $.ajax({
        method: "GET",
        url: 'https://www.reddit.com/r/smashbros/.json?sort=hot&limit=10',
        success: function(response) {
            console.log(response);
            let posts = response["data"]["children"];
            for (let i = 2; i < posts.length; i++) {
                let date = new Date(posts[i]['data']['created_utc'] * 1000);
                let dateOptions = { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' };
                $(".news-feed").append(`
                    <div class="section-content">
                        <div class="section-content__img-box">
                            <img src="${posts[i]['data']['preview']['images'][0]['source']['url']}" alt="" class="section-content__img">
                        </div>
                        <div class="section-content__text-box">
                            <h2 class="section-content__text-box__header"><a class="link" target="_blank" href="${posts[i]['data']['url']}">${posts[i]['data']['title']}</a></h2>
                            <p class="posted-date">${date.toLocaleDateString("en-US", dateOptions)} at ${date.toLocaleTimeString("en-US")}</p>
                            <p class="post-summary">
                                ${posts[i]['data']['title']}
                            </p>
                        </div>
                    </div>
                `);
            }
        }
    });
});