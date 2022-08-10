var fruits = ["apple", "strawberry", "banana", "orange",
    "mango"]
var isString = fruits.every((item) => {
    return typeof (item) == "string"
})
console.log(isString)
var StartWithA = fruits.some((item) => {
    return item.startsWith("a")
})
console.log(StartWithA)
var StartWithBOrS = fruits.filter((item) => {
    return item.startsWith("b")||item.startsWith("s")
})
console.log(StartWithBOrS)
var newFruits = fruits.map((item)=>{
return `I Love ${item}`
     })
console.log(newFruits)
newFruits.forEach((item)=>{
    console.log(item) 
         })
