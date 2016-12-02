# NorthwestLabs
INTEX Web Mockup

Group 1-1 
Members: Carsen Beyer, Kate Cousineau, Joe Isabell, Kaitlyn Whipple


Northwest Labs Pharmaceutical 
ASP.NET MVC Project 

Our site helps to show what our vision is for the system we have created for Northwest Labs. We have styled the page with how we wanted it to look like. Most of the functions actually work but all the data is dummy data. 

There is a navigable landing page that helps to show what Northwest Labs does as a company. 

------------------------------
HOW TO NAVIGATE!!
------------------------------

FROM LANDING PAGE YOU MUST CLICK LOG IN IN THE TOP RIGHT HAND CORNER
    Then you must choose 1 of 3 options:
    login as client
    login as ceo
    login as employee
Those options will take you to the dashboard depending on which login you chose.
you can change your view by clicking on view site as in the top left corner.

If you login as a client you have the following options:

Home        -> dashboard
Assays      -> tests in progress (TestStatus.cshtml)
            -> view work orders (ClientWorkOrders.cshtml)
Invoices    -> pay invoice (PayInvoice.cshtml)

If you login as a ceo or an employee you have the following options:

Home        -> dashboard (different for ceo and employee) ceo.cshtml, client.cshtml
Assays      -> View Work Orders (WorkOrders.cshtml)
Schedule    -> view work order schedule (Schedule.cshtml)
            -> schedule new work order (ScheduleTest.cshtml)
Resources   -> quote estimator (CreateQuote.cshtml)

TO GET BACK TO THE LANDING PAGE YOU CAN CLICK THE NORTHWEST LOGO IN THE TOP LEFT CORNER OF ANY PAGE.

------------------------------
EXPLANATION OF EACH VIEW 
------------------------------

The webpage has different views for the various use cases we chose to showcase. 
We have included views in the dashboard folder:

ScheduleTest.cshtml
    This view shows how an employee can upload the Excel program that decides which compound should be included when an assay is run. Once they have uploaded the file they can then press the schedule button which leads to the schedule.cshtml view.
Schedule.cshtml
    This view shows the created schedule that is made upon pressing the schedule button in the scheduletest.cshtml view. If you press the day button in the right hand corner, you can see a day's schedule for testing.
TestStatus.cshtml
    This view shows the test status for a certain client's various compounds and tests. It shows all of their past and current tests in the system with a progress bar, a status button, and various buttons that give options to see test results, see details, and more tests. 
ClientWorkOrders.cshtml or WorkOrders.cshtml
    This view contains a searchable table that holds all of the workorders for Northwest Labs. This way an employee can see work orders that need to be finished or ones that have previously been completed.
CreateQuote.cshtml
    This view helps a sales rep estimate quotes for prospective clients. The first section has 4 common tests that would pretty much always be the same price if only one compound is chosen. The second section is a helpful price generator that the employee can slide the various gliders according to the client's needs to generate a quote. The last section is used to look at tests in the past and how much they cost to help determine prices based on similarities.
PayInvoice.cshtml
    This view has a sample invoice that the client could look at, review, download as a pdf, and a button to submit a payment
Index.cshtml
    This is the landing page. It is the homepage for Northwest Labs. To get to the client, ceo, or employee pages you must log in in the top right hand corner.

The next three views are generally similiar. They display the dashbord page depending on the user's login credentials. The CEO Page includes higher level information for reporting, the client's page shows the information about their personal information with Northwest Labs, and the employee page shows information that only the employee should see. We were going to make logins for each type of user, but didn't want to frustrate the TA's when they had to go look at our notes to get the login information.

CEO.cshtml
Client.cshtml
Employee.cshtml


