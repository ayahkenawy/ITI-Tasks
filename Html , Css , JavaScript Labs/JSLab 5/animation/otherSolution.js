var img = document.querySelectorAll('img')
function animation() {
    intervalMarble = setInterval(function () {
      for (let index = 1; index < img.length; index++) {
          
        img[index].src = "imgs/marble3.jpg"
        img[index-1].src = "imgs/marble1.jpg"
      }

    }, 1000)
}
function stop() {
    clearInterval(intervalMarble)
}