# Design-Patterns-Tutorial

## Desing Matters Part-three: Forever Single

| <img src="out.jpg" alt="Pair Game" /> | 
|:--:|
|*The Cover of Article is Adapted From “Design Patterns Explained Simply By Alexander Shvets” Cover Page*|

## Single Life Better Life

It is impossible that you have not encountered the issue of instantiation in the Object-Oriented world. From the very beginning of learning this science, you have created classes and made any number and size of objects from them, and in technical terms, you have created different instances of your desired classes. But has it ever occurred to you that there might be a situation where we only have to create one object from a class and we have to prevent creating objects from a class in more than one instance? Do you think there will ever be a situation where we reach this limit? And can Object-Oriented provide this possibility for us? And we really have to ask ourselves how much we have been able to understand Object-Oriented.

## Real-world Examples

If we want to give some examples from the real world in which we must have exactly one Object of the corresponding class, we can point to the following: We may have several Printer devices in a system, but we only have one Printer Spooler. Either we have only one File System in an Operating System or only one Window Manager or when we want to have only one access point to a Database Engine. To solve all these problems, the GOF book introduces a Design Pattern called __Singleton__, which is classified as a __Creational Design Pattern__.

## Get Familiar with Singleton Design Pattern

This design pattern ensures that a class has only one instance and provides a global point to access it.

| <img src="1.png" alt="Pair Game" /> | 
|:--:|

In the above figure, you can see the structure of this design pattern in the form of a class diagram.

## How Implement This Philosophy

Now, how can we use this Design Pattern to solve a problem whose Problem Domain corresponds to this Design Pattern and implement it? For this, there are different methods that we will examine some of these methods on an example.

## Lazy Initialization

Suppose we want to have only one admin for a particular network. To have only one object from the admin class, we first place a Private Variable inside the admin class, which makes an object accessible using a method. To optimize the work, we put the instantiation part of the object in the method so that the object can be instantiated when that method is called.
