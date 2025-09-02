/*
 Elizabeth House
 COMP1235 Lab 5a
*/

// Arrays
console.log("Hello, World!")
const my_array = ['Elizabeth', 'House', 'Luffy', 'Zoro']
console.log(my_array[2])

// Objects
const my_obj =
    {
    first_name: "Elizabeth",
    last_name: "House",
    other_name: "Luffy"
    }

console.log(my_obj.last_name) // Method 1

let my_key = "last_name"
console.log(my_obj[my_key]) // Method 2

console.log(my_obj["last_name"]) // Method 3

// Destructuring
let {first_name, last_name, other_name: my_name} = my_obj
console.log(my_name)

// Spread operator (...)
console.log(my_array[0], my_array[1], my_array[2], my_array[3])
console.log(...my_array)

const second_array = ['Nami', 'Sanji', 'Robin', 'Usopp', 'Chopper']
const total_array = [...my_array, ...second_array]
console.log(total_array)

// Objects
console.log(my_obj)
console.log(my_obj.last_name, my_obj.last_name, my_obj.other_name)
// console.log(...myobj) // :(
console.log({...my_obj}) // :)

const second_obj =
    {
        food: 'Pizza',
        day: 'Friday',
        month: 'February',
        ...my_obj
    }

console.log(second_obj)
