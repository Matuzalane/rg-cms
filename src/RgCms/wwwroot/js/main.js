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

    var element = document.createElement("span");
    var bulletElements = document.querySelectorAll(".swiper-pagination-bullet");
    bulletElements.forEach(function (bulletElement) {
        bulletElement.appendChild(element.cloneNode(true));
    });
}
/**
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
function makeHeaderSticky() {
    window.addEventListener("scroll", function () {
        if (window.scrollY > 1) {
            document.querySelector("header").classList.add("sticky");
            document.querySelector("nav").classList.remove("navbar-dark");
            document.querySelector("nav").classList.add("navbar-light");
        } else {
            document.querySelector("header").classList.remove("sticky");
            document.querySelector("nav").classList.remove("navbar-light");
            document.querySelector("nav").classList.add("navbar-dark");
        }
    });
}
function qtyGuestAnimation() {
    var elements = document.querySelectorAll(".qtyButtons > div");

    function rotation() {
        document.getElementById("qtyTotalAnimation").classList.toggle("rotation-y");
    };

    for (var k = 0; k < elements.length; k++) {
        elements[k].addEventListener("click", rotation);
    }
}
function initializeDateRangePicker() {
    'use strict';

    $('#dateRangePicker').daterangepicker({
        "autoUpdateInput": false,
        "minDate": new Date(),
        "locale": {
            "format": "DD/MM/YYYY",
            "separator": " - ",
            "applyLabel": "Aplicar",
            "cancelLabel": "Limpar",
            "fromLabel": "De",
            "toLabel": "Para",
            "daysOfWeek": [
                "Dom",
                "Seg",
                "Ter",
                "Qua",
                "Qui",
                "Sex",
                "Sab"
            ],
            "monthNames": [
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            ],
            "firstDay": 1
        },
    });
    $('#dateRangePicker').on('apply.daterangepicker', function (ev, picker) {
        $(this).val(picker.startDate.format('DD/MM/YY') + ' - ' + picker.endDate.format('DD/MM/YY'));
    });
    $('#dateRangePicker').on('cancel.daterangepicker', function (ev, picker) {
        $(this).val('');
    });
}
