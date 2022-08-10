var intervalSlide
var img = document.querySelectorAll('div')[1].children
var i = 0
img[i].style.display="block"
++i
function next() {
    for (let index = 0; index < img.length; index++) {
        img[index].style.display="none"
    }
    if(i > 5){
        i = 0
    }
    img[i++].style.display="block"
}
function show() {
   intervalSlide = setInterval(function(){
    for (let index = 0; index < img.length; index++) {
        img[index].style.display="none"
    }
    if(i > 5){
        i = 0
    }
    img[i++].style.display="block"
    },2000)
}
function stop() {
     clearInterval(intervalSlide)
}
function prev() {
    for (let index = 0; index < img.length; index++) {
        img[index].style.display="none"
    }
    if(i < 0){
        i = 5
    }
    img[i--].style.display="block"
}