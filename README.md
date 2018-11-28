

Mid-Term Exam Two: ASP.NET Core

This exam asks that you create an ASP.NET Form, handle the POST data and show a result

Exam Activities

    Create an ASP.NET MVC Core application
    Create a Model Class called "MathOperation" with the following properties:
        LeftOperand (will be a decimal)
        Right Operand (will be a decimal)
        Operator (will be Addition, Subtraction, Multiplication, Division)
        Result (will be a decimal)
    Create a Controller called "MathController"
        Will have an ActionMethod called "DoCaclucation" which responds to HttpGet request
        Will create and send to the view as a model an instance of the "MathOperation" class to be bound to your form elements using ASP.NET Core tag helpers
        Will have an ActionMethod called "ShowCalculationResults" which responds to the HttpPost you would return form data binding the model to the form
    Use Bootstrap to create each Razor Template (a view for DoCalculation - which contains the form - and a view for ShowCalculationResults - which contains the results of the calculation)
        Don't forget that you need to create the model in the contoller and pass it to the view
        You need to specify the use of the model in the View using the @model directive in the View
        You need to use tag helpers in the form to specify which controller and view will be handling the POST data from the form
    Wire up the MathLibrary you've completed for a previous assignment to this ASP.NET MVC project in order to perform the required calcuations

How to submit this work
Create or add to an existing repository at Github and push your final solution to that repository.  Please then submit the URL to your repo here.
Also, ZIP up the repo and submit here to this dropbox.


