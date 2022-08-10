// Task 1
function fun() {
    if (arguments.length < 2) {
        throw ("arguments is less than 2")
    }
    else if (arguments.length > 2) {
        throw ("arguments is more than 2")
    }
}
fun(1, 2, 3)
// Task 2
function reverse() {
    // console.log(arguments)
    arr = []
    for (let index = 0; index < arguments.length; index++) {
        arr.push(arguments[index])
    }
    arr.reverse()
}
reverse(1, 2, 3)
// Task 3
function numerical() {
    var sum = 0
    for (let index = 0; index < arguments.length; index++) {
        if (typeof (arguments[index]) != "number") {
            throw ("You entered non numerical value")
        }
        sum += arguments[index]
    }
    console.log(sum)
}
numerical(1, 2, 3, 4)
// Task 4
function dateDay(day) {
    var dayDate = day.split('/');
    var d = new Date(dayDate[1] + "/" + dayDate[0] + "/" + dayDate[2]);
    var days = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
    var dayName = days[d.getDay()];
    console.log(dayName)
}
dateDay("14/04/2022")
// Task 5
function checkDate(date) {
    if (date.length != 10 || date.charAt(2) != "-" || date.charAt(5) != "-") {
        alert("Wong Date Format")
    }
    else {
        var dayDate = date.split('-');
        var d = new Date(dayDate[1] + "/" + dayDate[0] + "/" + dayDate[2]);
        alert(d)
    }
}
checkDate(prompt('enter the date in the following format (DD – MM – YYYY) ex. 22–01–1999'))
// Task 6
function checkDate(date) {
    if (date.length != 10 || date.charAt(2) != "-" || date.charAt(5) != "-") {
        throw ("Wong Date Format")
    }
    var dayDate = date.split('-');
    var d = new Date(dayDate[1] + "/" + dayDate[0] + "/" + dayDate[2]);
    alert(d)

}
try 
{
    checkDate(prompt('enter the date in the following format (DD – MM – YYYY) ex. 22–01–1999'))
} 
catch (error) 
{

}
