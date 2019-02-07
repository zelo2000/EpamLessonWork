# EpamLessonWork
Homework for courses in EPAM

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
### Task1
Class **_Figure_** with the abstract method Draw. Also Square and **_Rectangle_** classes which are derived from the **_Figure_** where created. Draw displays the name of the class in which this method is implemented.
### Task2
Using the previous task, added the X and Y property to the class **_Figure_**, and also added a parameterized constructor that sets values in these properties.
### Task3
Using the previous task changed the abstract class Draw to the virtual one and implemented it as in classes **_Square_** and **_Rectangle_**.
### Task4
Using the previous task, moved the method Draw to the interface **_IDrawable_**. Created a DrawAll method in which the objects of the created classes are transmitted and in the loop call the Draw method for each of them.