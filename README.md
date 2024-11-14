## Hotel Checkout System
This is a Homework assignment for the Desk Clerk to initiate the checkout process with the HotelSystem. The Clerk will retrieve the Customer information, display the bill, process payment via the Bank, print the receipt, and update the room status.


CS5373- Fall 2024- Homework

This homework assignment requires each team of two students to collaborate and complete a dynamic interaction model for a specific use case in a Hotel Information System.

The use case you’ll be working on is called “Check-out.” It involves a customer paying the bill and checking out of the hotel. Here’s a breakdown of the steps involved:

1. The desk clerk selects the checkout option from the system.
2. The desk clerk inputs the customer’s room number.
3. The system retrieves the customer’s information.
4. The system displays the total bill to the clerk.
5. The desk clerk enters the customer’s credit card details.
6. The system requests the bank to charge the fee.
7. If the payment is successful, the bank returns a confirmation number to the system.
8. The desk clerk selects a printing option to print the receipt.
9. The system prints the receipt.
10. The system updates the room status to “available.”
11. The system updates the number of available rooms displayed at the front desk for other customers.

Now, let’s talk about the requirements for this assignment:

1. Develop the interaction diagram (communication or sequence) for the Check-out use case using draw.io or Lucidchart. Hand-drawn diagrams are not accepted.
2. Identify all the necessary classes, including entities, interfaces, control, and application logic objects, if required.
3. Ensure that all interactions between the identified classes are correctly shown in the diagram.

Here’s a breakdown of the rubric for this assignment:

- Correct identification of classes (2.5 points)
- Correct interactions shown in the diagram (2.5 points)

Remember to submit your completed interaction diagram using draw.io or Lucidchart. Good luck with your assignment!
Requirement 2: Implement the Check-out use case using an object-oriented programming language (e.g., Java, C++, or C#) as modeled in your interaction diagram.

Note: Ensure that your code executes without any errors. Submit a zip file containing the code file and the program’s output. Your code should replicate the model you developed in requirement 1. It’s advisable to create separate classes for each class identified in requirement 1, and your program should have at least 6-8 classes, including the main class. Please include proper comments while implementing them for better understanding.

Rubric:

- All classes mentioned in requirement 1: 2 points
- Executed without any errors: 1 point
- All interactions are implemented (flow of the program matches the given use case): 3 points
- Correctness of code (using the details provided for payment, fee, updating the count, etc.): 2 points
- Outputs being displayed correctly: -2 points

For simplicity, consider the following while implementing:

- Each class in your developed interaction model must be a class in the programming language.
- There should be 6-8 classes in your program code, including the main class.
- There’s no need to use databases for entity classes. Instead, create separate entity classes and store the required information in them.
- Card Number: 1234 5678 9000
- PIN: 1234
- Confirmation number: 989898
- Alternatives should be implemented as well.
- When a bank receives a different PIN number/CC number than the ones provided above, the bank should deny the transaction.
- Room number: 5373
- Total rooms available: 10
- Available rooms initially: 5 (when the customer checks out, this count is updated to 6)
- Customer information should include your name and a random address of your choice.
- Assume that the customer stayed for two days, and the bill for two days is $250.
- Printing the receipt means simply displaying the details of the receipt on the computer screen.
- Clearly state any assumptions you make.

## Sample Output
**Checkout Process Initiated**

Please enter the room number of the customer: 5373

**Total Bill:** $250.00

Please enter the customer’s credit card number: 123456789000

Please enter the PIN: 1234

**Payment Successful**

**Available Rooms:** 6

**Select a printing option to print the receipt (Y/N):** Y

**Printing Receipt…**

——— Receipt ———

**Customer Name:** John Doe
**Address:** 123 Main St
**Amount Paid:** $250.00
**Confirmation Number:** 989898

———————————
