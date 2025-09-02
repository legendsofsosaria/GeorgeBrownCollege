/*
 Elizabeth House
 COMP1235 Lab 5c
*/

let subtotal = 7
const sales_tax = 1.13
let total = subtotal * sales_tax
console.log(total)

subtotal = 8
total = subtotal * sales_tax
console.log(total)

function total_func(subtotal)
{
    return subtotal + 1
}

console.log(total_func(7))
console.log(total_func(8))
console.log(total_func(9))

console.log(total_func("Hello"))

function current_date()
{
    const my_date = new Date();
    console.log("Today's date is: ", my_date.toDateString())
}

current_date()

function c_to_f(temp)
{
    const f = (temp * 1.8) + 32
    return f
}

let f = c_to_f(-11)
console.log(f, "°F")
