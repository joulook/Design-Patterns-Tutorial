# Design-Patterns-Tutorial

## Desing Matters Part-two: Adapter Party

| <img src="out.jpg" alt="Pair Game" /> | 
|:--:|
|*The Cover of Article is Adapted From “Design Patterns Explained Simply By Alexander Shvets” Cover Page*|

## A Tales of Disease
Max is a programmer who works at NOTHING WORKS HERE Company. The company has a website that allows users to make payments and purchases online and it was integrated into a 3rd party payment gateway. 3rd party payment gateway means a payment gateway created by another vendor and we are using it to perform financial transactions. Therefore, users can pay their bills through their website with their credit cards. Everything was going well until Max's manager called him for changes in the project, and Max knew that what was about to happen was not pleasant at all.
The manager told him that they are planning to change the vendor of the payment gateway; thus, he needs to plan for possible changes in the code. The problem arose from the fact that the Site was attached to the __Xpay__ payment portal, which received an Xpay object. The name of the new vendor was __PayD__, which only allowed Processing on objects of the PayD type.
