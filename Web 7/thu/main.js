// const texts = document.querySelectorAll('p');
// const nextBtn = document.getElementById('next-btn');
// let currentIndex = 0;

// function showText() {
//     if (currentIndex >= texts.length) {
//         return;
//     }

//     texts[currentIndex].style.display = 'block';
//     currentIndex++;

//     setTimeout(showText, 10000);
// }

// nextBtn.addEventListener('click', () => {
//     texts[currentIndex].style.display = 'none';
//     currentIndex++;

//     if (currentIndex >= texts.length) {
//         currentIndex = 0;
//     }

//     texts[currentIndex].style.display = 'block';
// });

// setTimeout(showText, 5000);

/* --------------------------------- */

// const carouselSlide = document.querySelector(".carousel-slide");
// const prevBtn = document.querySelector("#prevBtn");
// const nextBtn = document.querySelector("#nextBtn");
// const carouselImages = document.querySelectorAll(".carousel-slide img");

// let counter = 1;
// const size = carouselImages[0].clientWidth;

// carouselSlide.style.transform = `translateX(-${size * counter}px)`;

// nextBtn.addEventListener("click", () => {
//     if (counter >= carouselImages.length - 1) return;
//     carouselSlide.style.transition = "transform 0.4s ease-in-out";
//     counter++;
//     carouselSlide.style.transform = `translateX(-${size * counter}px)`;
// });

// prevBtn.addEventListener("click", () => {
//     if (counter <= 0) return;
//     carouselSlide.style.transition = "transform 0.4s ease-in-out";
//     counter--;
//     carouselSlide.style.transform = `translateX(-${size * counter}px)`;
// });

// carouselSlide.addEventListener("transitionend", () => {
//     if (carouselImages[counter].id === "lastClone") {
//         carouselSlide.style.transition = "none";
//         counter = carouselImages.length - 2;
//         carouselSlide.style.transform = `translateX(-${size * counter}px)`;
//     }
//     if (carouselImages[counter].id === "firstClone") {
//         carouselSlide.style.transition = "none";
//         counter = carouselImages.length - counter;
//         carouselSlide.style.transform = `translateX(-${size * counter}px)`;
//     }
// });

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