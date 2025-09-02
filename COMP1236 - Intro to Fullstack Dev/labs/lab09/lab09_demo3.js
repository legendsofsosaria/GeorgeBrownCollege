// Event handlers
function say_hello()
{
    console.log("Hello, World!")
}

say_hello()

const b = document.querySelector("#btn1")
console.log(b)

b.addEventListener("click", say_hello)

document.querySelector("#p1").addEventListener("mouseover",
    () => { console.log("Goodbye!") })

