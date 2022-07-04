# General Rules

* Begin each separate word in a name with a capital letter: **WriteExample**
* When you name an element in your Visual Basic application, the first character of that name must be an alphabetic character or an underscore. 
* An element name must only contain alphabetic characters, decimal digits, and underscores.  
* An element name must only contain alphabetic characters, decimal digits, and underscores.
* An element name must contain at least one alphabetic character or decimal digit if it begins with an underscore.
* An element name must not be more than 1023 characters long.
* If an event has a concept of "before" or "after," use a suffix in present or past tense: **ControlAdd** or **ControlAdded**
* For long or frequently used terms, use abbreviations to keep name lengths reasonable.
* Variable names greater than 32 characters are difficult to read on a monitor set to a low resolution.
* Make sure your abbreviations are consistent throughout the entire application.
* Avoid using names in an inner scope that are the same as names in an outer scope. If a conflict occurs between a variable and the keyword of the same name, you must identify the keyword by preceding it with the appropriate type library. For example, if you have a variable called *Date*, you can use the intrinsic *Date* function only by calling *DateTime.Date*.
* Do not use "My" or "my" as part of a variable name

# Class

UpperCamelCase (PascalCase) style.  
Begin with a noun.

**ClassName**

In names of event argument classes, include the "EventArgs" suffix.

**CustomMouseEventArgs**

# Constant
LowerCamelCase style.

**constName**

# Comment
* Put comments on a separate line instead of at the end of a line of code.  
* Start comment text with an uppercase letter, and end comment text with a period.  
* Insert one space between the comment delimiter (') and the comment text.  

**' Here is a comment.**

# Event handler

UpperCamelCase (PascalCase) style.
Begin names with a noun describing the type of event followed by the "Handler" suffix.

**MouseEventHandler**
   
# Function/Method

UpperCamelCase (PascalCase) style.  
Begin function and method names with a verb

**RunFunction**
 
# Interface

UpperCamelCase (PascalCase) style.  
Begin interface names with the prefix "I", followed by a noun or a noun phrase,  or with an adjective describing the interface's behavior.  
Do not use the underscore, and use abbreviations sparingly, because abbreviations can cause confusion.  

**IComponent**  
**IPersistable**  
     
# Module

UpperCamelCase (PascalCase) style.   
Begin with a noun.

**ModuleName**
     
# Structure

UpperCamelCase (PascalCase) style.    
Begin with a noun.

**StructureName**

# Variable
lowerCamelCase style.  

**variableName**

# Sources
* [Microsoft docs: Visual Basic Naming conventions](https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/program-structure/naming-conventions)
* [Microsoft docs: Visual Basic Coding conventions](https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/program-structure/coding-conventions)
* [Declaring constants](https://docs.microsoft.com/en-us/office/vba/language/concepts/getting-started/declaring-constants)
* [Declaring variables](https://docs.microsoft.com/en-us/office/vba/language/concepts/getting-started/declaring-variables)
