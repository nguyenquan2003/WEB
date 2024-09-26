
function ScrollTop() {
        if (window.jQuery) {
            jQuery('html,body').animate({
                scrollTop: 0
            }, 100);
        } else {
            document.getElementsByClassName('top-nav')[0].scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
            document.body.scrollTop = 0; // For Safari
            document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera
        }
        
}



// ===========HOTLINE============

const languageSelect = document.getElementById('language-select');
const formEnglish = document.querySelector('.form-english')
const formVietnamese = document.querySelector('.form-vietnamese')
const appContainer = document.querySelector('.h-survey')
const img = document.querySelector('.osc-button')
const close = document.querySelector('.esc-btn')
let abc = false
console.log(close, appContainer)

languageSelect.addEventListener('change', () => {
        const selectedLanguage = languageSelect.value;
        // Hide all language-specific elements
        const languageElements = document.querySelectorAll('[id^="welcome-message-"]');
        languageElements.forEach((element) => {
                element.style.display = 'none';
                
        });

        // Show the selected language element
        const selectedLanguageElement = document.getElementById(`welcome-message-${selectedLanguage}`);
        selectedLanguageElement.style.display = 'block';
});
img.onclick = () => {
        appContainer.style.display = 'block'
}
close.onclick = () => {
        
   appContainer.style.display = 'none' 
        
}
