// Scope
// Global scope
let b = 1

function my_func()
{
    // Function scope
    let a = 0
    console.log(a)
    console.log(b)
}

// Accessing variables in function scope
my_func()

// Accessing variables in global scope
console.log(b)
// console.log(a) ---> Error! Not in global scope

let e
if (b == 1)
{
    // Block scope
    let c = "Hello"
    console.log("b is 1")
    console.log(c)

    // Not in block scope; not recommended
    var d = "Goodbye"
    console.log(d)

    // Changed in block scope, but still exists in global scope
    e = "How are you?"
    console.log(e)
}

// console.log(c) ---> Error! Not in global scope
console.log(d)
console.log(e)

// Closures
function my_func_with_closure()
{
    let func_var = 0
    console.log(func_var)
    console.log(b)

    // return func_var

    function inner_func()
    {
        console.log(func_var)
    }

    inner_func()

    return inner_func
}

// Accessing variables in function scope
let f_var = my_func_with_closure()
console.log(f_var)
console.dir(f_var)
f_var()

// inner_func() ---> only available in the function scope
//console.log(func_var)
