var index = 1;
var myIndex = 0;
imgSlide(index);

function nextPrevSlide(n) {
  imgSlide(index += n);
}

function imgSlide(n) {
  var i;
  var slides = document.getElementsByClassName("img-slide");
  if (n > slides.length) {index = 1}    
  if (n < 1) {index = slides.length}
  for (i = 0; i < slides.length; i++) {
      slides[i].style.display = "none";
  }
  slides[index-1].style.display = "block";
}
var res;
function carousel() {
  res =setInterval(function(){
    var i;
    var x = document.getElementsByClassName("img-slide");
    for (i = 0; i < x.length; i++) {
      x[i].style.display = "none";  
    }
    myIndex++;
    if (myIndex > x.length) {myIndex = 1}    
    x[myIndex-1].style.display = "block";
  }, 2000); // Change image every 2 seconds
}

function stop() {
  clearInterval(res)
}