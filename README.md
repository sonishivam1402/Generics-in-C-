<h1>Generics in C#</h1>

<h4> Q. Design such a class, so that different objects of same  class  can keep different types of data. </h4>

<img src="https://github.com/user-attachments/assets/3730cbfa-e410-44dc-8f34-dd6df530c14c" width="250" />
<img src="https://github.com/user-attachments/assets/1e795328-f53e-4cd3-b269-532012a32ca9" width="300" />
<br>

Here, we can see it shows **error** because its **type dependent**.

<h2>Why Generics ?</h2>
Generics allows us to make classes and methods : 

<ul>
<li> Type independent</li>
<li> Type safe</li>
</ul>

<h2>What is Generics ? </h2>
Generics in C# are a feature that allows you to define classes, methods, interfaces, and other types with a placeholder for the data type. <br>
This means you can write code that works with any data type while maintaining type safety and without sacrificing performance.

<h2>Key Benefits of Generics:</h2>
<ul>
<li>Type Safety: Generics ensure that your code is type-safe at compile time, meaning errors related to type mismatches are caught early.</li>
<li>Code Reusability: You can write a generic class or method once and reuse it with different data types without rewriting the same logic.</li>
<li>Performance: Generics eliminate the need for boxing and unboxing (when dealing with value types) and avoid the overhead of type casting, which can improve performance.</li>
</ul>

<h2>How Generics Work:</h2>
Generics are implemented by defining a placeholder for a data type, which can then be specified when the generic type or method is used.

<h2>Constraints in Generics</h2>
There are several types of constraints to generic type parameters in order to restrict the types that can be used with your generic classes, methods, or interfaces. <br><br>

**1. where T : class (Reference Type Constraint)**
<br>This constraint ensures that the type parameter T must be a reference type (a class, interface, delegate, or array).
![Screenshot 2024-08-21 161231](https://github.com/user-attachments/assets/e1ee54dc-013b-4975-90d7-697f12711b29)


**2. where T : struct (Value Type Constraint)**
<br>This constraint ensures that the type parameter T must be a value type (like int, bool, enum, or a custom struct).
![Screenshot 2024-08-21 161316](https://github.com/user-attachments/assets/022e1537-1f2f-4807-ac59-c32727fc4554)


**3. where T : new() (Parameterless Constructor Constraint)**
<br>This constraint ensures that the type parameter T must have a parameterless constructor (public).
![Screenshot 2024-08-21 161409](https://github.com/user-attachments/assets/b4388d69-9bc6-4b17-a9c4-51491e1d6753)

**4. where T : <base class> (Base Class Constraint)**
<br>This constraint ensures that the type parameter T must be a specific class or a subclass of that class.
![Screenshot 2024-08-21 161708](https://github.com/user-attachments/assets/9500c53d-d865-4ad7-b1d3-b266f66c6643)

**5. where T : <interface> (Interface Constraint)**
<br>This constraint ensures that the type parameter T must implement a specific interface.
![Screenshot 2024-08-21 161735](https://github.com/user-attachments/assets/da102db4-1d6a-4c22-869e-0d914d73ca7b)

**6. where T : U (Type Parameter Constraint)**
<br>This constraint ensures that one type parameter is a subclass of or implements another type parameter.
![Screenshot 2024-08-21 161801](https://github.com/user-attachments/assets/ff407633-642c-4677-8307-d50a108bebca)

**7. Multiple Constraints**
<br>You can combine multiple constraints by separating them with commas.
![Screenshot 2024-08-21 161941](https://github.com/user-attachments/assets/44b57f8a-9fa5-4587-b92c-e6e168965796)
