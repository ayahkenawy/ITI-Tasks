// 1.String object
// 1.1
var word = prompt("Enter a word")
var bool = confirm("Do you want to consider case sensitive of the entered word ?")
if (bool) {
    wordArr = word.split("")
    wordArrRev = wordArr.reverse()
    wordRev = wordArrRev.join("")
    if (word == wordRev)
        alert("Word is palindrome")
    else {
        alert("Word is not palindrome")
    }
}
else {
    upperWord = word.toUpperCase()
    wordArr = upperWord.split("")
    wordArrRev = wordArr.reverse()
    wordRev = wordArrRev.join("")
    if (upperWord == wordRev)
        alert("Word is palindrome")
    else {
        alert("Word is not palindrome")
    }
}
// 1.2
var char = prompt("Enter a word")
var count =0;
for (let index = 0; index < char.length; index++) {
    if(char[index]=="e"){
count++
    }
}
alert(count)
// 1.3
do { var name = prompt("Enter Your Name") }
while (isFinite(name))

do { var phone = prompt("Enter Your Phone") }
while (isNaN(phone) || phone.length != 8)

do { var mobile = prompt("Enter Your Mobile") }
while (isNaN(mobile) || mobile.length != 11 || !(mobile.startsWith("010") || mobile.startsWith("011") || mobile.startsWith("012")))

do { var email = prompt("Enter Your Email") }
while (isFinite(email) || !email.match(/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/
  ))

document.write('<b style="color: red;">Name : </b>'+name+"</br>")
document.write('<b style="color: red;">Phone : </b>'+phone+"</br>")
document.write('<b style="color: red;">Mobile : </b>'+mobile+"</br>")
document.write('<b style="color: red;">Email : </b>'+email+"</br>")
// 2. Math Object
// 2.1
var circleRadius = prompt("Enter the value of a circle's radius")
var area =  Math.PI * Math.pow(circleRadius, 2);
alert(area)
// 2.2
var square = prompt("Enter another value to calculate its square root")
var root = Math.sqrt(square)
alert(root)
// 3. Array Object
// 3.1
var values =[]
var sum =0;
var multi =1;
for (let index = 0; index < 3; index++) {
   var value = Number(prompt("Enter A Value"))
   values.push(value)
}
for (let index = 0; index < values.length; index++) {
    sum += values[index]
    multi *= values[index]
 }
 div = values[0]/values[1]/values[2]
 document.write('<b style="color: red;">Sum of 3 Values : </b>'+sum+"</br>")
 document.write('<b style="color: red;">Multi of 3 Values : </b>'+multi+"</br>")
 document.write('<b style="color: red;">Div of 3 Values : </b>'+div+"</br>")
// 3.2
var values =[]
for (let index = 0; index < 5; index++) {
   var value = Number(prompt("Enter A Value"))
   values.push(value)
}
 document.write('<b style="color: red;">5 Values : </b>'+values+"</br>")
 document.write('<b style="color: red;">desc of 5 Values : </b>'+values.sort()+"</br>")
 document.write('<b style="color: red;">asdc of 5 Values : </b>'+values.reverse()+"</br>")
