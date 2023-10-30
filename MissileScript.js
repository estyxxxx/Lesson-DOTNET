fetch("https://localhost:7177/Missile_EstyElaluf")
    .then(Response => Response.json()).then((json) => {
    console.log(json);

    //for (let i = 0; i < Object.keys(json).length; i++) {
    //    let div = document.createElement("div")
    //    div.setAttribute("class", "div")
    //    let p1 = document.createElement("p")
    //    let p2 = document.createElement("p")
    //    let p3 = document.createElement("p")
    //    let p4 = document.createElement("p")
    //    let p5 = document.createElement("p")
    //    let p6 = document.createElement("p")

    //    p1.textContent = "patriotmissile: " + json[i].patriotmissile
    //    p2.textContent = "city: " + json[i].location.city
    //    p3.textContent = "date: " + json[i].location.date
    //    p4.textContent = "end date: " + json[i].location.endDate
    //    p5.textContent = "location: " + json[i].location.location
    //    p6.textContent = "misleStart: " + json[i].location.misleStart


    //    div.appendChild(p1)
    //    div.appendChild(p2)
    //    div.appendChild(p3)
    //    div.appendChild(p4)
    //    div.appendChild(p5)
    //    div.appendChild(p6)
    //    document.getElementById("s").appendChild(div)
    //}
})
