// var form = document.getElementsByTagName('form')[0]
// var userName = document.querySelector("input");
// var email = document.querySelectorAll("input")[2];
// var spanName = document.querySelector("span");
// var spanEmail = document.querySelectorAll("span")[2];
// var nameUser
// function validation() {
//     // console.log(e)
//     var result = true;
//     // e.preventDefault()
//     if (userName.value === "") {
//         spanName.textContent = "this field is required";
//         spanName.style.display = "inline";
//         result = false
//     }
//     else if (isFinite(userName.value)) {
//         spanName.textContent = "you should enter charachters";
//         spanName.style.display = "inline";
//         result = false
//     }
//     else {
//         spanName.style.display = "none";
//         nameUser = userName.value;
//         userName.value = "";
//     }
//     if (email.value === "") {
//         spanEmail.textContent = "this field is required";
//         spanEmail.style.display = "inline";
//         result = false
//     }
//     else if (!email.value.match(/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/)) {
//         spanEmail.textContent = "Email Not Valid";
//         spanEmail.style.display = "inline";
//         result = false
//     }
//     else {
//         spanEmail.style.display = "none";
//         userEmail = email.value;
//         email.value = "";
//     }
//     if (result) {
//         var newWindow = window.open();
//         newWindow.document.title = "Welcoming Page"
//         newWindow.document.write(`<h1>Hello ${nameUser}</h1>`)
//     }
//     return result
// }
// form.addEventListener('submit', validation)



