# EpamLessonWork
Lessonwork from courses in EPAM

## Lesson1 
Tasks on the topic of classes.
### Task1
A **_Rectangle_** class with methods that allow you to count perimeter and square of rectangle. The corners of the left top and right bottom corners are passed to the class constructor.
### Task2
Realized Task1 using auto-implemented properties.
### Task3
A **_Circle_** class with methods that allow you to calculate the length and square of the circle. The radius is passed by the parameter to the appropriate method. Constants is static fields in the class.
### Task4
Realized Task1 and Task3 using static class.The coordinates of the points are passed by the parameters to the corresponding methods.
### Task5
A **_ComplexNumber_** class. Overloaded multiplication and division operations.

## Lesson2.Struct
Tasks on the topic of structs.
### Task1
Realized a structure **_Person_** in which the name, surname and age of a person are stored. The implemented method for a created structure that accepts the integer value of "n" (n> 0) and returns a formatted string:
- "{Name} {Surname} older than {n}" if the age of the person is greater than the specified "n"
- "{Name} {Surname} younger than {n}" if the age of the person is less than the specified "n"
### Task2
The **_Rectangle_** class implements the **_ISize_** interface (with Width, Height properties and the Perimeter method) and the **_ICoordinates_** interface (with properties X, Y).

## Lesson2.Enums
Tasks on the topic of enums.
### Task1
The value n (0 <= n <12) is read from the console. The console displays the month that corresponds to the value n. Monthes is stored in the enum.
### Task2
An extension method has been created that displays all values to the console in increase order from the created color enum.
### Task3
Created enum **_LongRange_** in which there is a minimum and maximum value of type long (Max = 9223372036854775807, Min = -9223372036854775808). Values are displayed on the console using the created enum.

## Lesson3
Tasks on the topic of inheritance.
### Task1
Class **_Figure_** with the abstract method Draw. Also Square and **_Rectangle_** classes which are derived from the **_Figure_** where created. Draw displays the name of the class in which this method is implemented.
### Task2
Using the previous task, added the X and Y property to the class **_Figure_**, and also added a parameterized constructor that sets values in these properties.
### Task3
Using the previous task changed the abstract class Draw to the virtual one and implemented it as in classes **_Square_** and **_Rectangle_**.
### Task4
Using the previous task, moved the method Draw to the interface **_IDrawable_**. Created a DrawAll method in which the objects of the created classes are transmitted and in the loop call the Draw method for each of them.

## Lesson4
Tasks on the topic of array.
### Task1
The program that raises each element of the array to the cube.
### Task2
A program that displays amount of prime number in the array.
### Task3
Checks whether the array is semimetric.
### Task4
Makes an array that is the maximal element in each line of two-dimensional array of integers (m x n, m > 1, n > 1).
### Task5
Do task 4 using a jagged array.

## Lesson5
Tasks on the topic of list.
### Task1
Outputted to the console **_Name_** and **_Age_** people which contains in list of type **_Person_**.
### Task2
Added to the list two more **_Person_**. Outputted to the console phone numbers people which contains in list.
### Task3
A list is created with randomly generated elements of type string (length of the words 4, all characters are capital letters). All elements that are repeated and begin with the symbol 'Z' are removed. List is also sorted in descending order (z-a).
Number of itemss in the list before and after the transformations  are desplayed. Created a DisplayPage method which when you call it display to the console the corresponding page of the updated list (the number of items on the page is constant: 5).
The page number you want to output was read from the console. If the entered string is not a number then the program will stop.

## Lesson6

### Task1
**_Rectangle_** class was generated. Rectangle can be drawn in console, moved and resized. Also intersection and union of rectangles can be created.
### Task2
**_Circle_** class was generated. Circle can be drawn in console, moved and resized. 

## Lesson7
Tasks on the topic of LINQ
### Task1
Outputted to the console **_Name_** and **_Age_** people which contains in list of type **_Person_**.
### Task2
Added to the list two more **_Person_**. Outputted to the console phone numbers people which contains in list.
### Task3
Using LINQ people whose age less than 20 has been selected
### Task4
A list is created with randomly generated elements of type string (length of the words 4, all characters are capital letters). All elements that are repeated and begin with the symbol 'Z' are removed. List is also sorted in descending order (z-a).
Number of itemss in the list before and after the transformations  are desplayed. Created a DisplayPage method which when you call it display to the console the corresponding page of the updated list (the number of items on the page is constant: 5).
The page number you want to output was read from the console. If the entered string is not a number then the program will stop.

## Lesson9
Tasks on the topic of Exception
### Task1-4
StackOverflowException and IndexOutOfRangeException have been generated. IndexOutOfRangeException has been  catched.
### Task5
Method DoSomeMath which generate 
- ArgumentException("Parameter should be greater than 0", "a"), if � < 0
- ArgumentException("Parameter should be less than 0", "b"), if b > 0 
have been created.

## Lesson10
Tasks on the topic of File
### Task1
The contents of the given directory are displayed in the form of a list of files, sub directories containing the contents of these directories.
### Task2
An application is created that allows you to find the .txt file with a part of its name.

## Lesson11
Tasks on the topic of Serialization
### Task1
XML serialize and deserialize a collection of instances **_Car_** class.
### Task2
JSON serialize and deserialize a collection of instances **_Car_** class.
### Task3
Binary serialize and deserialize a collection of instances **_Car_** class.

## Lesson12
Tasks on the topic of Culture
### Task1
Given names of two students. These two lines are compared using the regional settings. It is determined which of these two lines is longer. It is also determined whether it is true that the first and last characters of each of these lines are the same.
### Task2
Displays the current date in the properties format for a given culture (culture identifier is read from the console).