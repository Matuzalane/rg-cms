/**
 * Initialize Swiper Functions for slider
 */
function initSwiper() {

    console.log('Entered initSwiper!');
    console.log('swiper text:' + document.querySelector('.swiper').textContent);
    console.log(document.querySelector('.swiper'));

    const swiper = new Swiper('.swiper', {
        // Optional parameters
        direction: 'horizontal',
        loop: true,

        // If we need pagination
        pagination: {
            el: '.swiper-pagination',
        },

        // Navigation arrows
        navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
        },

        // And if we need scrollbar
        scrollbar: {
            el: '.swiper-scrollbar',
        },
    });
}