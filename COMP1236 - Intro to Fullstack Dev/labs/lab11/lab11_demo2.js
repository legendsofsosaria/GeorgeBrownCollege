fetch('https://catfact.ninja/fact')
    .then(response => response.json())
    .then(json =>
    {
       document.querySelector("#cat_fact").innerHTML = json['fact']
    })

console.log("Hello")
