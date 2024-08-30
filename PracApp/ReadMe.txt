User
    1. Signup// account create
    http://localhost:5204/api/User/Signup

    2. Login
    http://localhost:5204/api/User/Login

Product
    1. show
    http://localhost:5204/api/Product/GetProduct

    2. Add product
    http://localhost:5204/api/Product/Add_Product

    3. Update Product
    http://localhost:5204/api/Product/ProductUpdated

    4. Delete
    http://localhost:5204/api/Product/ProductDeleted

Project Guidelines:
    1. Routing is a mechanism to convert component into URL known as route.
    2. Then we apply route-navigation to navigate from one route to another
    3. this shows that we don't need single page application(DOM).
    4. Routes is a class in angular to make a route table available in router module package.


3rd August
Agenda:
1. Design the application in angular to communicate with service, so that we can able to save the record in backend.
2. In last session, we have seen HTTPCLIENT class plays a major role to communicate with service.
3. HTTPCLIENT is a injectable class to support DI(no need to allocate memory of HttpClient).
4. We need to pass class name in constructor parameter to achieve dependency injection.
5. Angular runs in browser and service runs on server side, so we need to apply security policy otherwise frontend like react, angular
    cannot communicate to service.
6. CORS(Cross Origin Resource Sharing) needs to enable in core web API, then frontend like react, angular can communicate.

Important Questions:

1. Can you write the syntax to enable the CORS in core web api?
2. Please explain complete steps how frontend like angular communicate to service.
3. How to deploy the fullstack application on cloud(Azure).

5th August, 2024
---------------------------------------------------
Finally we are moving end of fullstack
    1. Agenda
    a. We have to take a data from angular providing to end point in core webapi with the help of HttpClient.
    b. Angular runs in browser whereas core webapi runs on server so we need to define the policy for CROSS application
    c. We need to include CORS in program.cs file to define the policy then frontend like angular can communicate with the service.

builder.Services.AddCors(opt =>
{
    opt.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:4200")

            .AllowAnyHeader()

            .AllowAnyMethod();
    });
});

-----------------------------------------------------
Now finally register.component.ts is able to send the data to service layer and service layer after subscribe post the
data to backend

once record is saved in the backend why not we can redirect to login.component.html and similarly login to dashboard.

Solution:
a. Router is a class in angular to navigate one component to another component
b. "Navigate()" is a function in Router class
c. Router is an inbuilt injectable class, we need to support DI
--------------------------------------------

Question: Difference between Routes and Router class?

6th August,2024
-------------------------------------------------
1. State Management
2. Introduction to AuthGuard **(Authentication and Authorization)
3. How to handle the exception in Angular.
4. Pipe


