// Task 1
var a = 5;
var b = 10;
console.log(`The value of a : ${a}`);
console.log(`The value of b : ${b}`);

//using destructuring
[a, b] = [b, a];

console.log(`The value of a after : ${a}`);
console.log(`The value of b after : ${b}`);

// Task 2

function getMaxMinNum(a, b, c, d, ...arr) {
    var max = Math.max(a, b, c, d, ...arr)
    var min = Math.min(a, b, c, d, ...arr)
    return `${max} , ${min}`
}
let arr = [5, 10, 2, 4, 7, 12, 20, 6, 30]
console.log(getMaxMinNum(25, 40, 100, 1, ...arr))

// Task 3 Promises

let divbtns = document.getElementById("buttons");
let btn = document.createElement("button");

let data = document.getElementById("userData");

let req = fetch("https://jsonplaceholder.typicode.com/users");

let UsersArr = req.then((users) => { return users.json() })
    .then((Usersdata) => {

        Usersdata.forEach(item => {
            let btn = document.createElement("button");
            btn.innerHTML = item.name;
            btn.value = item.id;
            btn.classList.add("btn")
            btn.classList.add("btn-primary")
            btn.classList.add("m-3")
            btn.setAttribute(`onclick`, `getUser(${btn.value})`);
            divbtns.appendChild(btn);

        })
    })
    .catch((erorr) => {
        alert(erorr) 
    });

async function getUser(id) {
    try {
        data.innerHTML="";
        var reqUser = await fetch(`https://jsonplaceholder.typicode.com/posts?userId=${id}`);
        var user = await reqUser.json();
        user.forEach(item => {
            let posts = document.createElement("p");
            posts.innerHTML = item.title;
            data.appendChild(posts)
        })
    } catch (erorr) {
        alert(erorr)
    }

}
getUser(1);