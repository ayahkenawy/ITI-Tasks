var form = document.getElementById('form')
var Timeout = setTimeout(function () {
    form.style.display = 'none'
    var h1 = document.getElementsByTagName("h1")[0]
    h1.style.display = 'block'
}, 30000);
form.addEventListener('submit', function (e) {
    e.preventDefault();
    var name = document.getElementsByTagName("input")[0]
    var age = document.getElementsByTagName("input")[1]
    clearTimeout(Timeout);
    alert(`Name : ${name.value} , Age : ${age.value}`)
})



