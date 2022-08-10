var canvas = document.getElementById("canvas")
var btn = document.getElementById("btn")
var color = document.getElementById("color")
 var contx = canvas.getContext("2d")
 canvas.width = window.outerWidth
 canvas.height = window.outerHeight
btn.addEventListener("click", function () {
    contx.clearRect(0,0, canvas.width,canvas.height)
for (let index = 0; index < 50; index++) {
    contx.beginPath();
    contx.arc(Math.floor((Math.random() * 1000) + 1), Math.floor((Math.random() * 1000) + 1), 50, 0, 2 * Math.PI,false);
    contx.strokeStyle = color.value
    contx.stroke();   
}  
})