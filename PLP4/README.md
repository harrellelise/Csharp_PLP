1. What are the boolean values in your language? (e.g., True and False, true and false, 1, and 0, etc.)
- The boolean values in C# are true and false, note that both start with a lowercase letter.
  
2. What types of conditional statements are available in your language? (if/else, if/then/else, if/elseif/else). Does your language allow for statements other than “if” (for example, Perl hasan “unless” statement, which does the opposite of “if”!)
- C# has multiple types of condition statements. They include: and if statement, if else statement, else if statement, and a switch. I should note that a switch can specify multiple alternative blocks of code to be executed based on the condition. A switch can also have a defualt block of code to run.
- It is also worth noting that C# has a shorthand for if-else called a ternary operator which has different formatting (there is an example of this in the code)

3. How does your language delimit code blocks under each condition in selection control statements?
- C# delimits the code blocks under each condition with { }
  
4. Does your language use short-circuit evaluation? Include an example of the short-circuit logic working or not working (or both, if your language is like Java and supports both!)
-C# does have short circuit evaluation, which is when a conditional statement or logical operation is being evaluated, if the end result is known before everything is evaluated, the evaluation with cease.
- An example is if x=0 and y=5, and the condition is if x>0 and y>2, the program will stop evaluating the condition after x>0, because it's false and both statements need to be true for the code block underneath to run.
  
6. How does your programming language deal with the “dangling else” problem?
- The best way to work with the dangling else is to put {} brackets around all code after the corresponding if else statement. But there is no specific measures put in place to handle it. 

7. If your language supports switch or case statements, do you have to use “break” to get out of them? Can you use “continue” to have all of the conditions evaluated?
-C# does support switch statements, and you need to have a break or return somewhere to allow the program to break out of the switch and continue.
- As far as I can tell C# has continue for loops not switches.

9. Does your language include multiple types of loops (while, do/while, for, foreach)? If so, what are they and how do they differ from each other?
- C# has while, do/while, for and foreach loops
- a while loop is a loop where if a certain condition is met, the loop will run the code block, until that condition is met. This is different from a do/while loop, because in a do/while loop, the code comes first and will be run at least once, and then will run multiple times while a condition is met. 
- a for loop is for when you know beforhand how many times you want a loop to run. A foreach Loop is used for one specific function, to loop through elements in an array or other data set.
  
10. Are loop code block variables treated differently than function code blocks?
- Loop code block variables are the same as code-blocks, both have the same scope. Those variables declared inside the loop or code block can't be accessed outside of it.

Resources: https://www.w3schools.com/cs/cs_conditions.php
