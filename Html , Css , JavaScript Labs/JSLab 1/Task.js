//Task 1
var inputValue=0
do {
    var input = prompt("Enter a value")
    if (isFinite(input)) {
        input = Number(input)
        inputValue += input
    }
}
while ( input != 0 || input < 100)
alert(inputValue)

// Task 2
var input = prompt("Enter a Msg")
for (let index = 1; index < 7; index++) {
    document.write("<h" + index + ">" + input + "</h" + index + ">")
}
// Task 3
do { var firstName = prompt("Enter Your FirstName") }
while (isFinite(firstName))

do { var LastName = prompt("Enter Your LastName") }
while (isFinite(LastName))

do { var mobile = prompt("Enter Your Mobile") }
while (isNaN(mobile) || mobile.length != 11)

    alert("Hello " + firstName + " " + LastName)


// Task 4
do { var name = prompt("Enter Your Name") }
while (isFinite(name))
do { var year = prompt("Enter Your Year") }
while (isNaN(year)&&year <= 2010)
    var age = 2022 - year
    document.write("<b>Name :</b>" + name + "  ")
    document.write("<b>Year :</b>" + year + "  ")
    document.write("<b>Age :</b>" + age + "  ")


