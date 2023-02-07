//Data types

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
//3. Describe the ways of checking data types.What are the possible difficulties of determining the data type ?
//4. Describe the difference between Abstract Equality Comparison and Strict Equality Comparison.
//5. Describe the process of the type coercion and rules of comparing the same and different data types.
//6. Name the built -in and native types.Describe wrappers / boxing.
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
//11. Explain what Objects and Arrays destructuring is.
//12. Specify loops, conditions, and the execution context.
//13. Describe the error handling process in JavaScript.
//14. How / when to use the Use strict directive ? How does it affect the JavaScript execution ?

//        Scope and closure

//Describe all variable declaration types and the difference between them.
//Is there any way to determine whether the variable is declared in a specific scope ?
//    What is scope ? What scope types exist in JavaScript ? What is the difference between the function and block scopes ?
//        What are a hoisting and temporal dead zone ?
//            Scope chain, lexical environment, and variable name resolution.
//What is closure ?
//    Describe the Memory Lifecycle in the context of the closure.

//        Functions

//Name all the approaches to declare and invoke functions in JavaScript and describe how they affect their execution.
//What does it mean: the functions in JavaScript are first - class objects?
//    What is the difference between the execution context, scope, and static properties ?
//        What does this keyword refer to in JavaScript ?
//            Provide a description of the partial application of functions vs.currying.
//Describe the practice of the borrowing method.

//OOP and FP in JavaScript

//Describe the OOP principles and their implementation in JavaScript.
//What is the difference between the classical and prototypal inheritance ?
//    Name all the possible ways to create an object and object`s property in JavaScript.
//Describe the attributes of the object and the object`s property.
//Do access modifiers exist in JavaScript ? Is it possible to simulate them, and how ?
//    What are the pros and cons of functional programming vs.object - oriented programming ?
//        What is functional programming ?
//            What is a high - order function?
//What is a pure function?
//What is currying ?
//    What does favor object composition over class inheritance mean ?
//        Compare the imperative programming and declarative programming.
//Describe SOLID and JavaScript.Provide an example of dependency injection and inversion of control in JavaScript.Are they related ?

//    Architectural concepts

//What are two - way data binding and one - way data flow ? How do they differ ?
//    What are the pros and cons of monolithic and microservice architectures ?

//        Async JavaScript

//What are the ways to handle the async code ?
//    What is a callback hell, and how can you avoid it ?
//        Describe how async / await works.
//Describe the generators and iterators and their possible usage in async JavaScript.
//Provide yield - delegation examples and generators concurrency.
//Describe Web Workers, Shared Workers.
//Describe the micro and macro tasks in the context of the event loop ?

//    Data structures

//Name the most commonly used Array methods.
//Describe how the reduce method works.What is the difference between slice and splice ?
//    Describe Map, Set, WeakMap, and WeakSet.
//What traditional data structures do you know ? How do they correspond with data structures available in JavaScript ?

//    Node JS

//What is the NodeJS event loop ?
//    What are the pros and cons of NodeJS ? In what cases should NodeJS be used and when should it not ?
//        What are streams in Node.js ?
//            Explain different types of streams in NodeJS.
//Describe multithreading in NodeJS.
//How to utilize multiple cores in a single NodeJS application ?
//    Explain the difference between programming in JS for NodeJS and browsers.
//Suggest an application structure / architecture for NodeJS based REST API server.

//    Testing

//Name the most common test types and explain the difference between them.
//Describe TDD / BDD.
//What are the best practices of code testing in JavaScript ?