# S.O.L.I.D Design Principles
SOLID is an ancronym which stands for:-

S - Single Responsibility Principle <br />
O - Open/Closed Principle <br />
L - Liskov Substitution Principle <br />
I - Interface Segregation Principle <br />
D - Dependency Inversion Principle <br />

## Single Responsibility Principle
A class should have one and only **one reason** to change, meaning that a class should have only **one job**.

## Open/Closed Principle
A class should be open to **addition/extension** but closed for **modification**.

## Liskov Substitution Principle
If a class **B** that inherits from class **A**. Then anywhere in the application where class **A** is used should be able to substitute for class **B** and application should continue to work.

## Interface Segregation Principle
Many smaller client specific **interfaces** are better than larger ones.

## Dependency Inversion Principle
Thourgh out the application a class should only be **dependent on interface** and not on **concrete class**.
