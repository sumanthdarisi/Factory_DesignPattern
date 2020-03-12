# Factory_DesignPattern

Factory Design Pattern is one type of creational design pattern used to limit the NEW objects from the main class. 

Scenario: A client needs to generate invoices based on its business location.

Code Structure:
1. An interface with limited methods.
2. Client class who is aware of all the list of business location codes
3. All the business location classes and respective business logic (all business classes must implement the interface)
4. A factory class who takes input from the client and return the requested business location code object

Benefits:
Using this design pattern, number of objects created by the client is limited and controlled.
Any new businesses added to the client can be handled easily and make changes with out disturbing other businesses
