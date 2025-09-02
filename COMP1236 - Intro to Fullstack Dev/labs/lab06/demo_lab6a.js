/* lizabeth House
Lab 6
02/14/2025
*/

// Function expressions
console.log("Hello, World!")
// Can run before the function is initialized
console.log(myFunc(5, 5))
// Cannot run before the function is initialized
//console.log(myFuncEx(5, 5))

function myFunc(param1, param2)
{
    return param1 + param2
}

console.log(myFunc(3, 5))

const myFuncEx = function(param1, param2)
{
    return param1 + param2
}

console.log(myFuncEx(4, 6))

// Arrow Function
const myArrowFunc = (param1, param2) =>
{
    return param1 + param2
}

console.log(myArrowFunc(5, 7))

// One parameter, no parentheses
const myShortFunc = param1 =>
{
    return param1 + 10
}

console.log(myShortFunc(5))

// Returning a simple value
const myReturnFunc = param1 => param1 + 10
console.log(myReturnFunc(6))

const myReturnFunc2 = (param1, param2) => param1 + param2
console.log(myReturnFunc2(8, 9))

// Default parameters
const myLoggingFunc = (param1 = 0, param2 = 0) => console.log(param1 + param2)
console.log("Two Parameters:")
myLoggingFunc(10, 12)
console.log("One Parameter:")
myLoggingFunc(10)
console.log("No parameters:")
myLoggingFunc()

// Rest parameters
//myLoggingFunc(1, 2, 3)

const myNonRestFunc = (greet, a1) =>
{
    console.log(greet)
    let a1_sum = 0;

    for (const a of a1)
    {
        a1_sum = a1_sum + a
    }

    console.log(a1_sum)
}

myNonRestFunc("Hello!", [1, 2, 3, 4])

// Cannot use 2 rest parameters
const myRestFunc = (greet, ...a1) =>
{
    console.log(greet)

    let a1_sum = 0;

    for (const a of a1)
    {
        a1_sum = a1_sum + a
    }

    console.log(a1_sum)
}

myRestFunc("Hello!", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)

//Callback Functions
console.log()
console.log("Callback functions")
const func1 = () => console.log("Hello")
const func3 = () => console.log("Goodbye")

const func2 = (a, b, c, d, f) =>
{
    console.log(a + b + c + d)
    f()
}

func2(1, 2, 3, 4, func1)
func2(1, 2, 3, 4, func3)

func2(1, 2, 3, 4, () => console.log("Hi"))
func2(1, 2, 3, 4, () => console.log("Bye"))

function calcGeneral() {
    print("X")

    function calcSpecific() {

        print("ii")
    }

    print("5")
    return calcSpecific

}

const mystery = calcGeneral()
mystery()