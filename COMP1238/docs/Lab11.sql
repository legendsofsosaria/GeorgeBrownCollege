SELECT * FROM courses;

SELECT * FROM assignments
LIMIT 10; 

SELECT count(*) FROM courses;

SELECT min(due_date) FROM assignments;

SELECT *
FROM  courses
WHERE course_name LIKE 'Intro%';

SELECT *
FROM  assignments
WHERE status != 'Completed'
ORDER BY due_date;

-- Use this query as a reference for the next step
SELECT course_id, title, status, due_date
FROM assignments
WHERE status != 'Completed'	
  AND course_id LIKE 'COMM%'
  AND due_date < '2024-12-31'
ORDER BY due_date;

-- Queries added by me for lab assignment 11 

-- Exercise Question #1 Assignments for a Specific Course
-- Write a query to display the title and due_date of assignments for the course COMP1234
SELECT title, due_date
FROM assignments
WHERE course_id = 'COMP1234';

-- Exercise Question #2
-- Earliest Assignment Due Date
-- Write a query to find the earliest assignment due date in the assignments table. Hint: use SELECT min()
SELECT min(due_date) FROM assignments;

-- Exercise Question #3
-- Latest Assignment Due Date
-- Write a query to find the latest assignment due date in the assignments table
SELECT max(due_date) FROM assignments;

-- Exercise Question #4
-- Assignments Due on a Specific Date
-- Write a query to find the title and course_id of assignments due on 2024-10-08
SELECT course_id, title
FROM assignments 
WHERE due_date = '2024-10-08';

-- Exercise Question #5
-- Find All Assignments Due in October
-- Write a query to display the title and due_date of assignments due in October 2024. Hint: use LIKE '2024-10%'
SELECT title, due_date
FROM assignments 
WHERE due_date LIKE '2024-10%';

-- Exercise Question #6
-- Find the Most Recently Completed Assignment
-- Write a query to find the most recent due_date of assignments with a status of "Completed"
SELECT course_id, title, status, min(due_date)
FROM assignments
WHERE status = 'Completed';

-- Optional Exercises
-- Count of "Not Started" Assignments
-- Write a query to find the total number of assignments with a status of "Not Started". Remember to use single quotes for strings in SQL.
SELECT *
FROM assignments
WHERE status = 'Not Started';

-- Find Courses with Labs on Tuesday
-- Write a query to find the course_id and course_name of courses that have lab sessions on Tuesday. Hint: use LIKE 'Tue%
SELECT course_id, course_name
FROM courses
WHERE lab_time LIKE 'Tue%';

-- Write a query that joins the two tables
SELECT *
FROM courses
JOIN assignments
ON courses.course_id = assignments.course_id;