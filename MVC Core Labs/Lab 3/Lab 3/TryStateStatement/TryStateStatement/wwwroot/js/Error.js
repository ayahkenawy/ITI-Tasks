

//for text animation-----------

var string = "Something Went Wrong Please Try Again Later or This Page Doesn't Exist";
var str = string.split("");
var el = document.getElementById('str');
(function animate() {
    str.length > 0 ? el.innerHTML += str.shift() : clearTimeout(running);
    var running = setTimeout(animate, 90);
})();

//background moving
const container = document.querySelector('.containers');

window.onmousemove = function (e) {
    let x = e.clientX / 8;
    let y = e.clientY / 8;

    container.style.backgroundPositionX = x + 'px';
    container.style.backgroundPositionY = y + 'px';

}


