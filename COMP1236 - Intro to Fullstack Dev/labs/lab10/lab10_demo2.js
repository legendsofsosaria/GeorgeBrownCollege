// Prototypes

class Student
{
    constructor(name, id, grades, pc_name, pc_id, pc_email)
    {
        this.name = name
        this.id = id
        this.grades = grades
        this.college = "George Brown College"

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
    }


    highest_grade()
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
}

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