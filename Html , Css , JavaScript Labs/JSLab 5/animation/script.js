var img = document.querySelectorAll('img')
var i = 0
// var intervalMarble = setInterval(function () {
//     if (i == 4) {
//         img[i].src = "imgs/marble1.jpg"
//         i = 0
//         img[i].src = "imgs/marble3.jpg"
//     }
//     else {
//         img[i++].src = "imgs/marble1.jpg"
//         img[i].src = "imgs/marble3.jpg"
//     }

// }, 1000)
function animation() {
    intervalMarble = setInterval(function () {
        if (i == 4) {
            img[i].src = "imgs/marble1.jpg"
            i = 0
            img[i].src = "imgs/marble3.jpg"
        }
        else {
            img[i++].src = "imgs/marble1.jpg"
            img[i].src = "imgs/marble3.jpg"
        }

    }, 1000)
}
function stop() {
    clearInterval(intervalMarble)
}