function keydownFun(e) {
    // console.log(e)
    if (e.keyCode == 18) {
        alert(`Alt Key ASCII Is ${e.keyCode}`)
    }
    else if(e.keyCode == 17){
        alert(`Ctrl Key ASCII Is ${e.keyCode}`)
    }
    else if(e.keyCode == 16){
        alert(`Shift Key ASCII Is ${e.keyCode}`)
    }
    else{
        alert(`ASCII Is ${e.keyCode}`)
    }
}