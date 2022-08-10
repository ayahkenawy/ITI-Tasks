
// Another Solution
var userDetails = window.location.search
var userName = userDetails.split("&")[0].split("=")[1].replaceAll("+", " ");
var password = userDetails.split("&")[1].split("=")[1];
var email = userDetails.split("&")[2].split("=")[1];
email = email.replaceAll("%40", "@");
var jobTitle = userDetails.split("&")[3].split("=")[1];
var mobile = userDetails.split("&")[4].split("=")[1];
var address = userDetails.split("&")[5].split("=")[1].replaceAll("+", " ");
address = address.replaceAll("%2C", ",");
address = address.replaceAll("%26", "&");
var gender = userDetails.split("&")[6].split("=")[1];

var h1 = document.createElement('h1')
h1.innerHTML = 'Welcome <span style="color:red;">' + userName + '</span>'
document.body.appendChild(h1)