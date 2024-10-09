1. What is the syntax for declaring a function in your language?
  - static void FunctionName(parameters)
2. Are there any rules about where the function has to be placed in your code file so that it can run?
  - functions need to be placed in a class, record of struct.
3. Does your language support recursive functions?
  - Yes C# does support recursive functions
4. Can functions in your language accept multiple parameters?  Can they be of different data types?
  - In C# functions can accept multiple parameters, 
5. Can functions in your language return multiple values at the same time?  How is that implemented?  If not, are there ways around that problem?  What are they?
  - Functions in C# can return multiple values at the same time, you just put it inside the return () and separate them by a comma.
6. Is your language pass-by reference or value?  Check your code against outside sources in case there is anything tricky going on (like in Perl).
  - C# is passed by value, which means that a copy of the variable is passed to the method.
7. Where are the arguments, parameters and local variables stored (value-on-stack, ref-to-heap-on stack) during execution?
  - They are stored in the stack memory during execution
8. What are the scoping rules in your language (visibility and lifetime of variables before, during and after code blocks)?
  - variables declared outside any method can be accessed anywhere in the class
  - variables declared within a method are only accessible within that method
  - variables declared inside a loop body are not accessible from higher scopes
  - the scope of a local variable ends when the method execution completes
9. Are side-effects possible? Are there guard rails against side-effects?
  - There are some side effects like changing a variable that exists outside the function.
  - There are no guard rails that I am familiar with
10. Where are local variable values stored? (on the stack? On the heap?)
  - Local variable values are stored on the stack in C#
11. Are there any other aspects of functions in your language that aren't specifically asked about here, but that are important to know in order to write one?  What are they? (e.g. dynamic vs static scope)
  - there is something called early return: a method overloading feature where the return type is not part of the method's signature
