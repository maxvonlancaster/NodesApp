﻿//Data types

//1. Name all data types in JavaScript.
function dataTypes() {
    // JS has 8 datatypes:
    let str = "str"; // string: 
    let nmbr = 5.55; // number:
    let bool = true; // boolean:

    // bigint - avaScript BigInt is a new datatype (2020) that can be used to store
    // integer values that are too big to be represented by a normal JavaScript Number.
    let x = BigInt("123456789012345678901234567890");

    // Symbol - unique identifier; 
    let id = Symbol("id");

    // In JavaScript, a variable without a value, has the value undefined
    let car;    // Value is undefined, type is undefined

    // The object data type can contain - an object, array, date
    const person = { firstName: "John", lastName: "Doe" };
    const cars = ["Saab", "Volvo", "BMW"];
    const date = new Date("2022-03-25");
}

//2. Compare the reference types and primitive types.
function referencePrimitiveComparison() {
    // Numbers, boolean values, and the null and undefined types are primitive. Objects, arrays,
    // and functions are reference types.A primitive type has a fixed size in memory.

    var a = 3.14;  // Declare and initialize a variable
    var b = a;     // Copy the variable's value to a new variable
    a = 4;         // Modify the value of the original variable
    alert(b)       // Displays 3.14; the copy has not changed

    var a = [1, 2, 3];  // Initialize a variable to refer to an array
    var b = a;        // Copy that reference into a new variable
    a[0] = 99;        // Modify the array using the original reference
    alert(b);         // Display the changed array [99,2,3] using the new reference
}

//3. Describe the ways of checking data types.What are the possible difficulties of determining the data type ?
function checkingDataTypes() {
    // typeof: checks if value is one of the primitive datatypes: undefined/string/number/boolean/object etc;
    // returns string ("undefined"/"string"/"number"/"boolean"/"object")
    var a;
    if (typeof a == "undefined")
        console.log("undefined");

    // instanceof : This checks the "kind" of an object. For example, Javascript arrays are basically
    // objects.Using this we can check whether a given value represents an array.
    // instanceof will return a boolean true / false depending on whether the value is an instance
    // of a given object or not.
    var b = [1, 2, 3];
    if (b instanceof Array)
        console.log("is array");
}

//4. Describe the difference between Abstract Equality Comparison and Strict Equality Comparison.
function comparisonsDifferences() {

}

//5. Describe the process of the type coercion and rules of comparing the same and different data types.
function typeCoersion() {

}

//6. Name the built -in and native types.Describe wrappers / boxing.
function builtInNativeTypes() {

}

//7. Name the data types that can and cannot contain values / types of objects.Name the ways to detect them.

//8. What is the practical use of the Symbol data type ?
function symbolUsage() {
    // only two primitive types can be used as object property keys - strings and symbols;
    // a symbol is a unique identifier;

}



//    Grammar

//9. Describe the statements and expressions.What are the side effects of expressions ?
function expressionStatements() {

}

//10. Define Operator Precedence.Specify the usage of logical and binary operators.
function operatorPrecedence() {
    // Operator precedence determines how operators are parsed concerning each other. Operators with higher 
    // precedence become the operands of operators with lower precedence.
}

//11. Explain what Objects and Arrays destructuring is.
function objectDestructuring() {
    // The destructuring assignment syntax is a JavaScript expression that makes it possible
    // to unpack values from arrays, or properties from objects, into distinct variables.
    let a, b, rest;
    [a, b] = [10, 20];

    console.log(b);
    // Expected output: 20

    [a, b, ...rest] = [10, 20, 30, 40, 50];

    console.log(a);
    // Expected output: 10

    console.log(rest);
    // Expected output: Array [30, 40, 50]
}

//12. Specify loops, conditions, and the execution context.

//13. Describe the error handling process in JavaScript.
function errorHandling() {
    // Just about any object can be thrown in JavaScript. Nevertheless, not all thrown objects
    // are created equal.While it is common to throw numbers or strings as errors, it is frequently
    // more effective to use one of the exception types specifically created for this purpose:

    // Use the throw statement to throw an exception.A throw statement specifies the value to be thrown:

    throw "Error2"; // String type
    throw 42; // Number type
    throw true; // Boolean type
    throw {
        toString() {
            return "I'm an object!";
        },
    };

    // The try...catch statement marks a block of statements to try, and specifies one or more 
    // responses should an exception be thrown.
}

//14. How / when to use the Use strict directive ? How does it affect the JavaScript execution ?


//        Scope and closure

//15. Describe all variable declaration types and the difference between them.
//16. Is there any way to determine whether the variable is declared in a specific scope ?
//17. What is scope ? What scope types exist in JavaScript ? What is the difference between the function and block scopes ?
//18. What are a hoisting and temporal dead zone ?
//19. Scope chain, lexical environment, and variable name resolution.
//20. What is closure ?
//21. Describe the Memory Lifecycle in the context of the closure.


//        Functions

//22. Name all the approaches to declare and invoke functions in JavaScript and describe how they affect their execution.
//23. What does it mean: the functions in JavaScript are first - class objects?
//24. What is the difference between the execution context, scope, and static properties ?
//25. What does this keyword refer to in JavaScript ?
//26. Provide a description of the partial application of functions vs.currying.
//27. Describe the practice of the borrowing method.


//OOP and FP in JavaScript

//28. Describe the OOP principles and their implementation in JavaScript.
//29. What is the difference between the classical and prototypal inheritance ?
//30. Name all the possible ways to create an object and object`s property in JavaScript.
//31. Describe the attributes of the object and the object`s property.
//32. Do access modifiers exist in JavaScript ? Is it possible to simulate them, and how ?
//33. What are the pros and cons of functional programming vs.object - oriented programming ?
//34. What is functional programming ?
//35. What is a high - order function?
//36. What is a pure function?
//37. What is currying ?
//38. What does favor object composition over class inheritance mean ?
//39. Compare the imperative programming and declarative programming.
//40. Describe SOLID and JavaScript.Provide an example of dependency injection and inversion of control in JavaScript.Are they related ?


//    Architectural concepts

//41. What are two - way data binding and one - way data flow ? How do they differ ?
//42. What are the pros and cons of monolithic and microservice architectures ?


//        Async JavaScript

//43. What are the ways to handle the async code ?
//44. What is a callback hell, and how can you avoid it ?
//45. Describe how async / await works.
//46. Describe the generators and iterators and their possible usage in async JavaScript.
//47. Provide yield - delegation examples and generators concurrency.
//48. Describe Web Workers, Shared Workers.
//49. Describe the micro and macro tasks in the context of the event loop ?


//    Data structures

//50. Name the most commonly used Array methods.
//51. Describe how the reduce method works.What is the difference between slice and splice ?
//52. Describe Map, Set, WeakMap, and WeakSet.
//53. What traditional data structures do you know ? How do they correspond with data structures available in JavaScript ?


//    Node JS

//54. What is the NodeJS event loop ?
//55. What are the pros and cons of NodeJS ? In what cases should NodeJS be used and when should it not ?
//56. What are streams in Node.js ?
//57. Explain different types of streams in NodeJS.
//58. Describe multithreading in NodeJS.
//59. How to utilize multiple cores in a single NodeJS application ?
//60. Explain the difference between programming in JS for NodeJS and browsers.
//61. Suggest an application structure / architecture for NodeJS based REST API server.


//    Testing

//62. Name the most common test types and explain the difference between them.
//63. Describe TDD / BDD.
//64. What are the best practices of code testing in JavaScript ?
