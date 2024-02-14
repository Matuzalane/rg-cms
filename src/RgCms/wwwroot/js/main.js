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
        autoplay: false,

        // If we need pagination
        pagination: {
            el: '.swiper-pagination',
            clickable: true,
            bulletElement: 'button',
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

/**
 * Add a Event Listener for mause-hover 
 * Style animation in the Top Line Links
 */
function topLinksHover() {
    var elements = document.querySelectorAll("#top_links > li");

    function handleHoverIn() {
        var siblings = this.parentNode.children;
        for (var i = 0; i < siblings.length; i++) {
            if (siblings[i] !== this) {
                siblings[i].style.opacity = 0.6;
            }
        }
        var parentSiblings = this.parentNode.parentNode.children;
        for (var j = 0; j < parentSiblings.length; j++) {
            if (parentSiblings[j] !== this.parentNode) {
                parentSiblings[j].style.opacity = 1;
            }
        }
    }

    function handleHoverOut() {
        var siblings = this.parentNode.children;
        for (var i = 0; i < siblings.length; i++) {
            siblings[i].style.opacity = 1;
        }
        var parentSiblings = this.parentNode.parentNode.children;
        for (var j = 0; j < parentSiblings.length; j++) {
            parentSiblings[j].style.opacity = 1;
        }
    }

    for (var k = 0; k < elements.length; k++) {
        elements[k].addEventListener("mouseenter", handleHoverIn);
        elements[k].addEventListener("mouseleave", handleHoverOut);
    }
}
