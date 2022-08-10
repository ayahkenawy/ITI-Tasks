do {
    var usersNum = prompt("Enter number of users")
    if (isFinite(usersNum)) {
        var table = document.createElement("table")
        var thead = document.createElement("thead")
        var tbody = document.createElement("tbody")
        var tr = document.createElement("tr")
        var thName = document.createElement("th")
        var thAge = document.createElement("th")
        table.style.border="2px solid"
        thName.style.border="2px solid"
        thAge.style.border="2px solid"
        thName.innerText="Name"
        thName.style.width="70%"
        tr.appendChild(thName)
        thAge.innerText="Age"
        tr.appendChild(thAge)
        thead.appendChild(tr)
        table.appendChild(thead)
        table.appendChild(tbody)
        for (let index = 1; index <= usersNum; index++) {
            do {
                var userName = prompt(`Enter user ${index} Name`)
                var userAge = prompt(`Enter user ${index} Age`)
            }
            while ((userName.length < 3 || userName.length > 11) || (userAge < 10 || userAge > 60))
            var tr = document.createElement("tr")
            var tdName = document.createElement("td")
            var tdAge = document.createElement("td")
            tdName.style.border="2px solid"
            tdAge.style.border="2px solid"
            tdName.innerText=userName
            tdAge.innerText=userAge
            tr.appendChild(tdName)
            tr.appendChild(tdAge)
            tbody.appendChild(tr)
        }
        document.body.append(table)
    }
}
while (isNaN(usersNum))