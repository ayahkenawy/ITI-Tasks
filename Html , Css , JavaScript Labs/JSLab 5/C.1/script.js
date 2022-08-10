var newWindow = window.open("", "Flying Window", "width=100,height=100")
var changePostion = setInterval(() => {
    newWindow.moveTo(Math.random() * window.innerWidth, Math.random() * window.innerHeight)
}, 1000);
function stop() {
    clearInterval(changePostion)
}