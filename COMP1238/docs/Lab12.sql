-- Add an assignment with NULL due_date
INSERT INTO assignments (course_id, title, status) 
VALUES ('COMP1238', 'Assignment with no date', 'Not Started');

SELECT * FROM assignments
LIMIT 10; 

SELECT count(*) FROM courses;

SELECT min(due_date) FROM assignments;

SELECT *
FROM  courses
WHERE course_name LIKE 'Intro%';

SELECT sqlite_version();

SELECT upper('ABCxyz');

SELECT length('abcde');

SELECT 7*5;

SELECT concat('ABC', '-', 'xyz');

SELECT date();

SELECT strftime('%Y', due_date) AS Year, * 
FROM assignments;

-- SUBSTRING(string, start, length)
SELECT DISTINCT SUBSTRING(course_id, 1, 4) 
FROM courses;

-- Count how many courses there are with each prefix like 'MATH' and 'COMP'
SELECT SUBSTRING(course_id, 1, 4) AS prefix, count(*)
FROM courses
GROUP BY prefix;

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

-- Queries added by me for lab assignment 12

-- Exercise Question #1 Concatenate Course Name and Semester:
-- Write a query to list all courses, concatenating the course_name and semester fields with a hyphen between them. Like this:
-- "IT Essentials - 2024-3"
SELECT concat(course_name, ' - ', semester)
FROM courses;

-- Exercise Question #2 Find Courses with Labs on Fridays:
-- Write a query to find all courses that have a lab session scheduled on Friday. 
-- Include only the course_id, course_name, and lab_time in the result.
SELECT course_id, course_name, lab_time
FROM courses
WHERE lab_time LIKE 'Fri%';

-- Exercise Question #3 Upcoming Assignments:
-- Write a query to list all assignments with a due date after the current date
SELECT * 
FROM assignments
WHERE due_date > CURRENT_DATE;

-- Exercise Question #4 Count assignments by status:
-- Write a query to count the # of assignments for each status (e.g., "Not Started")
SELECT status, COUNT(*) AS assignment_count
FROM assignments
GROUP BY status;

-- Exercise Question #5 Longest Course Name:
-- Write a query to find the course with the longest course_name. Use the length() 
-- function to compare lengths. 
SELECT * 
From courses
ORDER BY length(course_name)
DESC limit 1; 

-- Exercise Question #6 Uppercase Course Names:
-- Write a query to return a list of all course names in uppercase
SELECT upper(course_name)
From courses;

-- Exercise Question #7 Assignments Due in September:
-- Write a query to list the titles of all assignments that are due in September,
-- regardless of year. Use the LIKE operator to filter due_date
SELECT title, due_date
From assignments
WHERE due_date LIKE '%-09-%';

-- Exercise Question #8 Assignments with Missing Due Dates:
-- Write a query to find all assignments where the due_date is missing. 
SELECT *
From assignments
WHERE due_date IS NULL;
