var userName = document.querySelector("input");
var age = document.querySelectorAll("input")[1];
var email = document.querySelectorAll("input")[2];
var spanName = document.querySelector("span");
var spanAge = document.querySelectorAll("span")[1];
var spanEmail = document.querySelectorAll("span")[2];
var form = document.getElementsByTagName('form')[0]
var submitButton = document.getElementsByTagName('input')[4]
function reset() {
    form.reset()
}
function validation(e) {
    // console.log(e)
    e.preventDefault()
    if (userName.value === "") {
        spanName.textContent = "this field is required";
        spanName.style.display = "inline";

    }
    else if (isFinite(userName.value)) {
        spanName.textContent = "you should enter charachters";
        spanName.style.display = "inline";

    }
    else {
        spanName.style.display = "none";
        Name = userName.value;
        userName.value = "";
    }

    if (age.value === "") {
        spanAge.textContent = "this field is required";
        spanAge.style.display = "inline";

    }
    else if (isNaN(age.value)) {
        spanAge.textContent = "you sholud enter number";
        spanAge.style.display = "inline";
    }
    else {
        spanAge.style.display = "none";
        userAge = age.value;
        age.value = "";
    }
    if (email.value === "") {
        spanEmail.textContent = "this field is required";
        spanEmail.style.display = "inline";

    }
    else if (!email.value.match(/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/)) {
        spanEmail.textContent = "Email Not Valid";
        spanEmail.style.display = "inline";

    }
    else {
        spanEmail.style.display = "none";
        userEmail = email.value;
        email.value = "";
    }
var tr = document.createElement("tr")
var tdName = document.createElement("td")
var tdAge = document.createElement("td")
var tdEmail = document.createElement("td")
tdName.innerText=Name
tdEmail.innerText=userEmail
tdAge.innerText=userAge
tr.appendChild(tdName)
tr.appendChild(tdAge)
tr.appendChild(tdEmail)
var tbody = document.getElementsByTagName('tbody')[0]
tbody.appendChild(tr)
var table = document.getElementsByTagName('table')[0]
table.style.display="table"
}
form.addEventListener('submit',validation)