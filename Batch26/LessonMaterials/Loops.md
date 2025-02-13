Learning Objectives

1. By the end of this lesson, students will be able to:

2. Understand the purpose of loops in programming.

3. Use for, while, do-while, and foreach loops in C#.

4. Recognize scenarios where loops improve code efficiency.

5. Avoid common pitfalls like infinite loops.


Lesson Outline

1. Introduction to Loops (10 minutes)
What are loops?

Explain repetition in code (e.g., printing numbers 1–100).

Use analogies like "repeating a task until a condition is met."

Why use loops?

Reduce code redundancy.

Simplify complex tasks.

2. Types of Loops in C#

A. for Loop 
Syntax
for (initialization; condition; iteration) { ... }

Key Concepts:

Initialization, condition, and iteration components.

Use cases: Counting, fixed iterations.

B. while Loop 

Syntax:
while (condition) { ... }  

Key Concepts:

Loop runs while a condition is true.

Risk of infinite loops (e.g., forgetting to update counter).

C. do-while Loop 

Syntax:
do { ... } while (condition); 

Key Concepts:

Executes code at least once before checking the condition.

Contrast with while loops

foreach Loop 

Syntax:
foreach (DataType item in collection) { ... } 

Key Concepts:

Iterates over collections (arrays, lists).

No manual index management.

Hands-On Practice 
Exercise 1: Print a multiplication table using nested for loops.

Exercise 2: Use a while loop to reverse a string (e.g., "hello" → "olleh").

Exercise 3: Use foreach to find the maximum value in a list of integers.

Assessment
Evaluate completed exercises for correctness and efficiency.

Use a short quiz with scenarios.

Additional Resources

Microsoft Docs: C# Loops

Codecademy: C# Loops Practice

Simple Loop project
https://github.com/Iammurphyleo/SimpleLoopProject
