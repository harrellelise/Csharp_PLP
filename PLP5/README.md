1. Does your language support objects or something similar (e.g., structs or records)?
 - Yes! C# is a object oriented language! So it supports objects and classes.

2. Are there naming conventions for objects, instance variables, or functions that people writing in your language should be aware of?
 - It is good pratice to write object class names using PascalCase in C#, which means that the first letter of each word in the name is capitalized, with no spaces between words and no underscores, using [A-z][0-9].

3. Does your language have standard methods for functions that serve a similar purpose across all objects? For example, toString() in Java and __str__ in Python allow information about the objects to be printed. Are there similar functions in your language?
  - ToString() returns a string that represents the object instance in C#
  - ReferenceEquals(Object,Object) determines whether the specified Object instances are the same instance
  - MemberwiseClone() creates a shallow copy of the current object
  - GetType() Gets the Type of the current instance
  - GetHashCode() Serves as the default hash function
  - Equals(Object,..) Determines whethere the object is equal to the current object, or another imputed object.
  - Derived classes can and do override Equals, Finalize, GetHashCode, and ToString methods of Object class.

4. How does inheritance work (if it does)? Does your language support multiple inheritance?
 - There is inheritance in C#, and C# has Polymorphism which is when we have many classes that are related to each other by inheritance.
 - C# does not suppurt Multiple inheritance of classes, however its does support multiple inheritance using interfaces

5. If there is inheritance, how does your language deal with overloading method names and resolving those calls?
 - Method overloading in C# is resolved at compile time, and the compiler determines which method to call based on what arguments are passed to the method and selects the most appropriate one.

6. Is there anything else that’s important to know about objects and inheritance in your language?
I know this question is vague, but objects are were languages can vary a lot, so it’s hard to ask questions that will apply to everyone.
 -  In C# you can have two methods with the same name but different signatures or arguments and the compiler chooses the method based on the parameters that get passed in.
 -  If you don't want other classes to inherit from a class you can use the 'sealed' keyword



Resources:
https://www.geeksforgeeks.org/c-sharp-object-class/ 
https://www.w3schools.com/cs/cs_inheritance.php
https://www.w3schools.com/cs/cs_classes.php
https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md
