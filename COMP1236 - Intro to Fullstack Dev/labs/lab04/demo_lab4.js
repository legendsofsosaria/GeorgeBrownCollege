// Regular Expressions
b = "heyo, World!";
re_test = /^He+l*.+, Wo?rld!?$/i

if (re_test.test(b))
{
    console.log("Hello to you too!")
}

// Objects
let student_arr = ["John Doe", 25, "Computer Science"]
console.log(student_arr);
console.log(student_arr[0]);

let student = { name: "John Doe", age: 25, major: "Computer Science" }
console.log(student);
console.log(student.name);

let course =
    {
        name: "Introduction to Full-Stack Development",
        num_students: 100,
        course_code: "COMP1235",
        assignments: ["assignment1", "assignment2", "assignment3"],
        exams:
            {
                exam1: "Mid-term Exam",
                exam2: "Final Exam"
            }
    }

console.log(course);

//let student_name = student.name;
//let student_major = student.major;
//console.log(student_major);

let { name: student_name, age: student_age, major: student_major } = student;
console.log(student_age);

/*----------------------------------------------------------*/
/*console.log("Hello, world!")

let a = 5;
console.log(a);

let b = "Hello, World"
console.log(b);

console.log(a + 6);

if (a == 5)
{
    console.log("a is 5");
}
else
{
    console.log("a is not 5");
}

for (let i = 0; i < 10; i++)
{
    console.log(i);
}

let j = 0;
let stop = 10;
while (j < stop)
{
    if (j % 3 == 0)
    {
        j++;
        continue;
    }


    console.log(j);
    j++;

    if (j == 8)
        break;
}

console.log("After the while loop")

b = "Hello, World!";*/


