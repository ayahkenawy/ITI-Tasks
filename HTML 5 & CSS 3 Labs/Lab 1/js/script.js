
var img = document.getElementById("img")
var playbtn = document.getElementById("play")
var pausebtn = document.getElementById("pause")
var stopbtn = document.getElementById("stop")
var mutebtn = document.getElementById("mute")
var vol = document.getElementById("vol")
var track = document.getElementById("track")
var songName = document.getElementById("songName")

function toggleItem(elem) {

    for (var i = 0; i < elem.length; i++) {
        elem[i].addEventListener("click", function (e) {
            var current = this;
            for (var i = 0; i < elem.length; i++) {
                if (current != elem[i]) {
                    elem[i].classList.remove('active');
                } else if (current.classList.contains('active') === true) {
                    current.classList.remove('active');
                } else {
                    current.classList.add('active')
                    songName.style.fontSize = "20px";
                    songName.innerHTML = current.firstChild.data
                    var audio = document.getElementsByTagName("audio")[0]
                  
                    if (i == 0) {
                        img.src = 'Imgs/Super.jpg'
                        audio.src='Media/Super Mario Bros (NES) Music - Overworld Theme.mp3'
                    }
                    else if (i == 1) {
                        img.src = 'Imgs/Adele.jpg'
                        audio.src='Media/adele easy on my.mp3'
                    } else {
                        img.src = 'Imgs/Sia.jpg'
                        audio.src='Media/Sia-Beautiful-Things-Can-Happen-(TrendyBeatz.com).mp3'

                    }
                    vol.addEventListener("change", function () {
                        audio.volume= vol.valueAsNumber 
                    })
                    track.addEventListener("change", function () {
                         track.max = audio.duration
                        track.min = 0
                        audio.currentTime= track.value
                        
                    })
                    mutebtn.addEventListener("click", function () {
                        audio.muted = !audio.muted;
                    })
                    playbtn.addEventListener("click", function () {
                        audio.play();
                    })
                    pausebtn.addEventListener("click", function () {
                        audio.pause();
                    })
                    stopbtn.addEventListener("click", function () {
                        audio.load();
                        audio.pause();
                    })
                    audio.addEventListener("timeupdate",function(){
                        track.value = audio.currentTime
                    })

                }
            }
            e.preventDefault();
        });
    };
}

toggleItem(document.querySelectorAll('.list-group-item'));
