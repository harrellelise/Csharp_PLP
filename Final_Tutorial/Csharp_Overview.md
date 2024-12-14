Hello World!

Welcome to my C# tutorial! 

The C# language was developed within Microsoft primarily by Anders Hejlsberg, Scott Wiltamuth and Peter Golde. Microsoft released the first widely distributed implementation of C# in July 2000 as part of its . NET framework initiative. It was created to compete with Java after Sun sued Microsoft. 

C# is very multi purpose, while initially created for Microsoft applications, it has become widely used to create video games. In addition it is used for cloud services and web application development.

Let’s get started! Take a look at the Hello World code to get familiar with the syntax and move on to data types.

Here are the sources I used to create my tutorial, I highly recommend checking them out for more information. 

Sources:
https://www.geeksforgeeks.org/c-sharp-object-class/  https://www.w3schools.com/cs/cs_inheritance.php  https://www.w3schools.com/cs/cs_classes.php   https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history 
https://www.geeksforgeeks.org/c-sharp-data-types/?ref=shm 
https://www.geeksforgeeks.org/c-sharp-methods/?ref=shm 
https://www.w3schools.com/cs/cs_conditions.php

Data Types and Naming Conventions
(referencing DataTypes.cs)

C# has lots of keywords, 77 in total.
https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/ 
Full list available here ^

Let's talk about naming requirements for variables!
For naming in C#, the requirements are as follows 
- Have to be unique 
- Can only contain letters, digits and underscores
- Must start with a letter 
- Cannot contain reserved keywords (linked above)
It should be noted that C# is case sensitive and these naming rules are enforced by the compiler.
It should also be noted that it is technically ok to start a variable with an uppercase letter, but looked down upon in the coding community.

Statistically or Dynamically Typed
C# is a statistically typed language, which means the type of variable is known during compilation.

Strongly or Weakly Typed
C# is strongly typed language which means that it enforces strict rules on data types and values, you can’t put a float where it expects an integer. 

Explicitly or Implicitly Typed
C# is unique in that is has the option to do either, developers can either choose to create an implicit variable or declare the data type before hand

Mutable or Immutable
In C#, strings, record types and built in types are immutable, other types are mutable.
The only exception to this rule is StringBuilder, which can make strings mutable.


The operators available in C# are…
Arithmetic
Relational
Logical
Bitwise
Assignment
Conditional

Mixed Type Operations
Mixed type operations are allowed in C#, you can multiply and add floats and integers, and the integer will be converted to a float for the operation, and the answer will result in a float. However mixed operations between strings and ints are not allowed, strings and arrays can only hold one value type.

Variables, class names and functions are bound at compile time.
Operators are bound to their operations from creation, as it is a generally permanent part of the language, however C# does allow users to overload an operator for a user defined type.

Limitations in C#
C# does allow division between floats and ints, without errors, and does allow you to create variables without defining values. It however doesn't have a simple print function for lists, you have to run through all the elements and print each one individually.


Functions
(referencing Functions.cs)

How do you declare a function in C#?

- static void FunctionName(parameters)

Functions must be placed in a class, or a struct
See the functions code example for more examples

C#  supports recursive functions, as well as accepting multiple parameters of different data types. 
 
C# also allows you to return values from the function. You can return values by using
- return(val1, val2, val3)
And putting in the values you want to return, separated by a comma.

Here is some interesting rules about how C# runs that can be important
- Arguments, parameters and local variables are all stored in the stack memory during execution.
- Local variables are stored on the stack 
- Early return: a method overloading feature where the return type is not part of the method’s signature
- C# is passed by value, which means that a copy of the variable is passed to the method, so if the variable is changed inside the method, it will not change outside the method
- There are occasional side effects in C# when trying to change a variable that exists outside a function, so best to not try :)

Scoping Rules of C#
- Variables declare outside any method, can be accessed anywhere in the class
- Variables declared within a method are only accessible within that method
- Variables declared inside a loop body are not accessible from higher scopes
- The scope of a local variable ends when the method execution completes


Selection, Loops and Conditionals
(referencing Loops.cs)

 𝅘𝅥𝅮♫♪ Lets take about selects baby, let's talk about loops and C(onditionals)  -Salt-N-Pepa

When writing loops and conditionals, you need to first know the Boolean values! And for some unknown reason…. Every language does it a little differently

C# uses true and false, !note that both start with a lowercase letter!

In C# you have the option of using a few different types of conditional statements
- And - if statement
- If - else statement
- Else - if statement
- Switch statement (for those unfamiliar a switch is code that can specify multiple alternate blocks of code to be executed based on the condition, and can also have a default block of code to run)
- *shorthand if - else statement* ( it is worth noting that C# has a shorthand for if - else called a ternary operator which has different formatting, there is an example of this on line 24-26 of the Loop Code

!You can see examples of all of these in the loop code!

!Notice! C# delimits the code blocks under each condition with { }

Short Circuit Evaluation
C# does have short circuit evaluation, which is when a conditional statement or logical operation is being evaluated, if the end result is known before everything is evaluated, the evaluation will cease.
EX: if x=0 and y=5, and the condition is if x>0 and y>2, the program will stop evaluating the condition after x>0, because it's false and both statements need to be true for the code block underneath to run.
(an example of this in loop code starting line 68)

Dangling Else’s:
The best way to work with the dangling else is to put {} brackets around all code after the corresponding if else statement. But there are no specific measures in C# to handle it.

Breaking the statement
C# supports switch statements, in which case you must have a break or return somewhere in the program to break out of the switch.
Continues
You can use continues (which evaluates all of the conditions) in loops

Types of Loops
- While: loop where if a condition is met, the loops will run the code block until the condition is not met
- do/while : code comes first, will be run at least once, and then run multiple times while a condition is met. 
- For : when you know how many times you want a loop to run beforehand 
- For-each : used for one specific function, to loop through elements in an array or data set

Reminder (variables)! - Loop code block variables are the same as code-blocks, both have the same scope. Those variables declared inside the loop or code block can't be accessed outside of it.

Classes and Inheritance
(referencing ObjectsCode/PerChiProgram.cs, Person.cs, Student.cs)

C# is an object oriented language! So it supports objects and classes.

When creating object class names, it is considered good practice to write names using PascalCase in C#, which means the first letters of each word are capitalized, and no spaces or underscores between words. Using only [A-z][0-9].

* See examples of objects and classes in the Person code and Student code.

C# has some standard methods for some functions that can be used across all objects.
- ToString() 
returns a string that represents the object instance in C#
- ReferenceEquals(Object,Object) 
determines whether the specified Object instances are the same instance
- MemberwiseClone() 
creates a shallow copy of the current object
- GetType() 
Gets the Type of the current instance
- GetHashCode() 
Serves as the default hash function
- Equals(Object,..) 
Determines whethere the object is equal to the current object, or another imputed object.

!Note! Derived classes can override Equals, Finalize, GetHashCode, and ToString methods of Object class.

Inheritance
There is inheritance in C# and here are some facts you should know!

- C# has Polymorphism! Which is when we have many classes that are related to each other by inheritance. 
- C# does not support Multiple inheritance of classes, however it does support multiple inheritance using interfaces. 
- Method overloading in C# is resolved at compile time, and the compiler determines which method to call based on what arguments are passed to the method and selects the most appropriate one.
- In C# you can have two methods with the same name but different signatures or arguments and the compiler chooses the method based on the parameters that get passed in. If you don't want other classes to inherit from a class you can use the 'sealed' keyword

