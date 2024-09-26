// ========= auto đổi slide=============

// var myIndex = 0;
// carousel();

// function carousel() {
//   var i;
//   var x = document.querySelectorAll('.slider_item');
//   for (i = 0; i < x.length; i++) {
//     x[i].style.display = 'none';  
//   }
//   myIndex++;
//   if (myIndex > x.length) {myIndex = 1}    
//   x[myIndex-1].style.display = 'block';  
//   setTimeout(carousel, 4000);    
// }



$(document).ready(function() {
  var owl = $('.owl-carousel');
  owl.owlCarousel({
    items: 3,
    center: true,
    loop: true,
    margin: 10,
    responsive:{
        600:{
            items:2
        }
    },
    autoplay: true,
    autoplayTimeout: 3000,
    autoplayHoverPause: true
  });
})
// ===========SẢN PHẨM=============

