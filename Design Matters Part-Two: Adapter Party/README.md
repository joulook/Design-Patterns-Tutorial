# Design-Patterns-Tutorial

## Desing Matters Part-two: Adapter Party

| <img src="out.jpg" alt="Pair Game" /> | 
|:--:|
|*The Cover of Article is Adapted From “Design Patterns Explained Simply By Alexander Shvets” Cover Page*|

## A Tales of Disease
Max is a programmer who works at NOTHING WORKS HERE Company. The company has a website that allows users to make payments and purchases online and it was integrated into a 3rd party payment gateway. 3rd party payment gateway means a payment gateway created by another vendor and we are using it to perform financial transactions. Therefore, users can pay their bills through their website with their credit cards. Everything was going well until Max's manager called him for changes in the project, and Max knew that what was about to happen was not pleasant at all.

The manager told him that they are planning to change the vendor of the payment gateway; thus, he needs to plan for possible changes in the code. The problem arose from the fact that the Site was attached to the __Xpay__ payment portal, which received an Xpay object. The name of the new vendor was __PayD__, which only allowed Processing on objects of the PayD type.

Max did not want to change all 100 classes that were referenced to an Xpay object. This would also increase the risk on the project that was running and the users were using it. Also, he cannot change the codes of the 3rd party payment portal. In other words, his problem can be described in the following two ways.

<p float="left">
  <img src="01.jpg" width="400" />
  <img src="02.jpg" width="422" /> 
</p>

## ‫‪Season‬‬‫‪Party‬‬ ‫‪Adapter‬‬
Well, as you can see, we have encountered a problem that is difficult to find a solution to it, not if we are not familiar with Pattern Designs. In this session, we want to introduce you to one of the most useful design patterns which are categorized by Structural purpose, The Adapter Pattern. In some books, it has been introduced as Wrapper Pattern. In General, an Adapter matches an interface(Adaptee) to another interface(Target); consequently, it results in an integrated abstraction from various interfaces.

An Adapter class does this by privately inheriting from an Adaptee class and causes multi-inheritance. We will cover this topic and the Object Adapter Pattern later.

You can have the same view on the Adapter as in the real world adapter In the real world, an adapter is used to connect two different electrical ports as connecting them can not be possible directly. The adapter relays between these two parts and gets the flow from one of them and transforms it to be usable for the other part. This work can not be done without an adapter because of the existence of Incompatible Interfaces.  

The Adapter pattern allows an object or a class to expose what it needs. It converts the interface of a class to its desired interface; in fact, it allows us to fix the interfaces between objects and classes without any need to change them directly.

## ‫‪Object Adapter Pattern and Believe Me... Its so easy to lean!

| <img src="3.png" alt="Pair Game" /> | 
|:--:|
