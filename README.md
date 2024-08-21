<h1>Generics in C#</h1>

<h4> Q. Design such a class, so that different objects of same  class  can keep different types of data. </h4>

<img src="https://github.com/user-attachments/assets/3730cbfa-e410-44dc-8f34-dd6df530c14c" width="200" />
<img src="https://github.com/user-attachments/assets/1e795328-f53e-4cd3-b269-532012a32ca9" width="200" />
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
