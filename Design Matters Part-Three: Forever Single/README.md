# Design-Patterns-Tutorial

## Desing Matters Part-three: Forever Single

| <img src="out.jpg" alt="Pair Game" /> | 
|:--:|
|*The Cover of Article is Adapted From “Design Patterns Explained Simply By Alexander Shvets” Cover Page*|

## Single Life Better Life

It is impossible that you have not encountered the issue of instantiation in the Object-Oriented world. From the very beginning of learning this science, you have created classes and made any number and size of objects from them, and in technical terms, you have created different instances of your desired classes. But has it ever occurred to you that there might be a situation where we only have to create one object from a class and we have to prevent creating objects from a class in more than one instance? Do you think there will ever be a situation where we reach this limit? And can Object-Oriented provide this possibility for us? And we really have to ask ourselves how much we have been able to understand Object-Oriented.

## Real-world Examples

If we want to give some examples from the real world in which we must have exactly one Object of the corresponding class, we can point to the following: We may have several Printer devices in a system, but we only have one Printer Spooler. Either we have only one File System in an Operating System or only one Window Manager or when we want to have only one access point to a Database Engine. To solve all these problems, the GOF book introduces a Design Pattern called __Singleton__, which is classified as a __Creational Design Pattern__.
