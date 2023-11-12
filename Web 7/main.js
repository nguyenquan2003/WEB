const slider = document.querySelector('.slider');
const slides = Array.from(document.querySelectorAll('.slide'));

const slideWidth = slides[0].getBoundingClientRect().width;

function setPosition() {
    slides.forEach((slide, index) => {
        slide.style.left = `${index * slideWidth}px`;
    });
}

function slide() {
    const currentSlide = slider.querySelector('.current');
    const nextSlide = currentSlide.nextElementSibling;
    const amountToMove = nextSlide.style.left;

    slider.style.transform = `translateX(-${amountToMove})`;

    currentSlide.classList.remove('current');
    nextSlide.classList.add('current');
}

setPosition();

setInterval(() => {
    slide();
}, 3000);