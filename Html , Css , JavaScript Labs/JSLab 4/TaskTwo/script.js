function clone() {
    var div = document.getElementsByTagName("div")[0]
    var divClone =div.cloneNode(false)
    divClone.style.backgroundColor=getRandomColor()
    divClone.style.width="25%"
    divClone.style.height="50%"
    document.body.appendChild(divClone)
    
}
function getRandomColor() {
    var letters = '0123456789ABCDEF';
    var color = '#';
    for (var i = 0; i < 6; i++) {
      color += letters[Math.floor(Math.random() * 16)];
    }
    return color;
  }