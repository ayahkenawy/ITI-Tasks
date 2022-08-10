// var input = document.getElementById("Answer")
// var firstValue 
// var secondValue
// var operatorValue 
// function EnterNumber(value) {
//     input.value += value
// }
// function EnterOperator(operator) {
//     firstValue = Number(input.value)
//     operatorValue = operator
//     input.value=""
//     // switch (operator) {
//     //     case "+":
//     //         // input.value += ' ' + operator + ' '
//     //         break;
//     //     case "-":
//     //         // input.value += ' ' + operator + ' '
//     //         break;
//     //     case "*":
//     //         // input.value += ' ' + operator + ' '
//     //         break;
//     //     case "/":
//     //         // input.value += ' ' + operator + ' '
//     //         break;
//     //     default:
//     // }
// }
// function EnterClear(){
//     input.value=""
// }
// function EnterEqual(){
//    secondValue = Number(input.value)
//        switch (operatorValue) {
//         case "+":
//             Cal = firstValue + secondValue
//             break;
//         case "-":
//             Cal = firstValue - secondValue
//             break;
//         case "*":
//             Cal = firstValue * secondValue
//             break;
//         case "/":
//             Cal = firstValue / secondValue
//             break;
//         default:
//     }
//     input.value=Cal
   
// }
/// another solution
var input = document.getElementById("Answer")
function EnterNumber(value) {
    input.value += value
}
function EnterOperator(operator) {
    input.value += operator
}
function EnterClear(){
    input.value=""
}
function EnterEqual(){
    input.value = eval(input.value)
}