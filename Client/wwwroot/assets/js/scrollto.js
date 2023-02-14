window.blazorHelpers = {
    scrollToFragment: (elementId) => {
        var element = document.getElementById(elementId);

        if (element) {
            element.scrollIntoView({
                behavior: 'smooth'
            });
        }
    }
};

const scrollTopBtn = document.createElement("button");
scrollTopBtn.id = 'float_but';
scrollTopBtn.innerHTML = "<i class='fas fa-arrow-up'></i>";
scrollTopBtn.addEventListener('click', () => {
  window.scrollTo({top: 0, behavior: 'smooth'});
});


// scrollTopBtn.setAttribute("style", "display: hidden !important;");
// scrollTopBtn.className.add("hide");
window.onscroll = function() {scrollFunction()};
// alert(document.body.scrollTop);
function scrollFunction() {
  if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {

    // scrollTopBtn.setAttribute("style", "display: block;");
    // alert('adding scroll top button')
    // alert(document.body.scrollTop);
    if(scrollTopBtn) {
      document.body.appendChild(scrollTopBtn); 
    }

  } else {
    // alert('button should be hidden')
    if(scrollTopBtn) {
      document.body.removeChild(scrollTopBtn); 
    }
  }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
  document.body.scrollTop = 0;
  document.documentElement.scrollTop = 0;
}

window.addEventListener('scroll', () => {

});