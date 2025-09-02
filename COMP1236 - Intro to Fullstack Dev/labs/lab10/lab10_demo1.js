// Ternary Operator
let score = 50;
/*if (score >= 50)
{
    msg = "You passed"
}
else
{
    msg = "You failed"
}*/

// Shortest way
console.log((score >= 50) ? "You passed" : "You failed")

// Shortish way
//let msg = (score >= 50) ? "You passed" : "You failed"
//console.log(msg)

// More complex (if - else if - else)
let hair_colour = "black"
let recommendation = (hair_colour == "brown") ? "Get highlights!" :
    ((hair_colour == "black") ? "Maybe get highlights" : "Don't get highlights")
console.log(recommendation)

// -------------

// Array methods
let my_array = ["Michael", "John", "Jane", "Sarah"]

let out = ""
my_array.forEach(e => out += e + "! ")

/*let out = my_array.join("!, ")
let out = ""
for (let i = 0; i < my_array.length; i++)
{
    out += my_array[i] + "! "
}*/

console.log(out)

/* Checks each element in the array, check if true or false and then stores true
values in a new array. e represents specific element we are looking at */
let new_array = my_array.filter(e => e.length === 4)
console.log(new_array)

/* Reduce ---> Reduces array down to 1 value e represents specific element we are looking at
p represents the number we are reducing to (the result) p and e are arbitrary variables, however
one is the element you are looping through, and the other is the result.
IE, before and after values. Don't have to start from 0, can start from another number (such as 10)
 */
let my_nums = [1, 2, 3, 4, 5, 6]
let s = my_nums.reduce((p, e) => p + e)
console.log(s)

// Sometimes needs an initial value
let new_out = my_array.reduce((p, e) => p + e + "! ", "")
console.log(new_out)

// -----------

// Prototypes
function Student(name, id, grades, pc_name, pc_id, pc_email)
{
    this.name = name
    this.id = id
    this.grades = grades

    this.program_coordinator =
        {
            name: pc_name,
            id: pc_id,
            email: pc_email,
            business_card: function ()
            {
                // This refers to program_coordinator
                return this.name + " / " + this.email
            }
        }


    // this.highest_grade = function ()
    // {
    //     let hg = 0;
    //     // This refers to student
    //     for (let i = 0; i < this.grades.length; i++)
    //     {
    //         if (this.grades[i] > hg)
    //         {
    //             hg = this.grades[i]
    //         }
    //     }
    //     return hg
    // }
}

Student.prototype.highest_grade = function ()
{
    let hg = 0;
    // This refers to student
    for (let i = 0; i < this.grades.length; i++)
    {
        if (this.grades[i] > hg)
        {
            hg = this.grades[i]
        }
    }
    return hg
}

Student.prototype.college = "George Brown College"

const s1 = new Student("Michael", "100000001", [50, 60, 70, 50], "Maziar", "001", "mmasoudi@georgebrown.ca")
console.log(s1.name)
console.log(s1.id)
console.log(s1.grades)
console.log(s1.highest_grade())
console.log(s1.program_coordinator.business_card())

const s2 = new Student("Mary", "10000000002", [90, 80, 70, 40], "Bob", "002", "bob@georgebrown.ca")
console.log(s2.name)
console.log(s2.id)
console.log(s2.grades)
console.log(s2.highest_grade())
console.log(s2.program_coordinator.business_card())

console.log(s1.college)
console.log(s2)

String.prototype.isGreeting = () =>
{
    console.log(this)

    if (this == "Hello")
    {
        console.log("Is Greeting")
    }
    else
    {
        console.log("Not a greeting")
    }
}

let str1 = "Hello"
let str2 = "Goodbye"
str1.isGreeting()
str2.isGreeting()

