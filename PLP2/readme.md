1. Does your language have keywords or reserved words? How many? 
  - Yes, C# has keywords, 77 in total.

2. What are the naming requirements for variables in your language? 
What about naming conventions? Are those enforced by the compiler/interpreter, or just 
standards in the community?
  - The naming requirements are that they must be unique,
    can only contain letters, digits and the underscore,
    they must start with a letter and cannot contain reserved keywords,
    as well as being case sensitive. (These rules are enforced by the compiler)
  - Variables can technically start with an Uppercase letter, but is looked down upon in coding community.

3. Is your language statically or dynamically typed?
  - C# is a statically typed language, because the type of variable is known during compilation

4. Strongly typed or weakly typed?
  - C# is mainly a strongly typed language, because it enforces strict rules on data types and values

5. Explicitly typed or implicitly typed?
  - C# is unique in that is has the option to do either,
    developers can either choose to create an implicit variable
    or declare the data type before hand

6. Are some variables mutable while others are immutable?
  - strings, record types, and built in types are immutable
  - StringBuilder however can make strings mutable, 

7. What are the operators available for each data type? 
  - Arithmetic
  - Relational
  - Logical
  - Bitwise
  - Assignment
  - Conditional

8. Are mixed type operations allowed? If so, how are they accommodated? 
  - Yes mixed type operations are allowed, you can multiply and add floats and integers, and the integer will be converted to a float for the operation, and the answer will result in a float. However mixed operations between strings and ints are not allowed, strings and arrays can only hold one value type.

9. At what point are identifier names and operator symbols bound in your language? For example 
if you declare a (variable, class name, function name), when is it bound to the type, address? 
When are operators (+,*, etc.) bound to their operations?
  - Variables, class names and functions are bound at compile time.
  - Operators are bound to their operations from creation, as it is a generally permanent part of the language, however C# does allow users to overload an operator for a user defined type.

10. Describe the limitations (or lack thereof) of your programming language as they relate to the coding example portion of the assignment (adding ints and floats, storing different types in lists, converting between data types). Are there other restrictions or pitfalls that the documentation 
mentions that you need to be aware of?
  - 

11. Are there built-in complex data types that are commonly used in your language? (hint: they’d probably appear fairly early in the documentation if so)
  - 
