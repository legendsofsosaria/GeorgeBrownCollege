/*document.addEventListener("DOMContentLoaded", function()
{
    console.log($("#el1"))
})*/

// jQuery
$(() =>
{
    // console.log($("#el1"))
    // console.log($("div > p"))
    console.log("Next sibling")
    console.log($("p + button"))
    console.log("Adjacent sibling")
    console.log($("p ~ button"))
})

$("#el2").on("click", () => { console.log("You clicked me!") })
// $("#el2").click(() => { console.log("You clicked me!") }) deprecated
// document.getElementById("el2").addEventListener("click", function()

function button1()
{
    e = document.getElementById("el1")
    console.log(e)

    e.innerText = "Some new text"

    //document.getElementById("el2").innerText = "Other new text"
    /*f = $("#el2")
    console.log(f)
    f.text("Other new text")*/

    $("#el2").text("More new text")
}

function button2()
{
    let t = $("p").text();
    console.log(t)

    // $("p").text("A different change")
}

function button3()
{
    // $(".red").text("This should be red!")
    let textboxes = $("input")
    console.log(textboxes.val()) // logs what is in the textbox (only works for first box)
    textboxes.val("") // empties both textboxes
}

console.log($("#el1"))

$()



