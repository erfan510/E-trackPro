Project Overview: E-TrackPro
E-TrackPro is a Windows-based application developed using C#. The primary purpose of this project is to connect to an API, retrieve data, and present it in a user-friendly interface for visualization and interaction.

The API used in this project is intended solely for testing purposes, and the data source is DummyJSON.
DummyJSON is a free and open-source tool that provides mock data in JSON format. It simulates real-world API responses, making it ideal for testing applications without relying on a live database or production data.

Project Purpose
The goal of this project is to demonstrate how to:

Send and handle various API requests.

Process and display simple data structures.

Integrate different API endpoints in a working application.

Test PATCH Requests: The application allows updating user data (such as name, age, or gender) by entering the user ID, modifying the desired fields, and sending the updated data back to the server using a PATCH request.

Data Storage
This project uses in-memory caching (C# memory storage) to temporarily store and manipulate data during runtime. This approach improves responsiveness and simulates real-world scenarios where local caching is used before syncing with a remote server.

Documentation
This repository includes two documentation files:

One in English (filename ends with _EN)

One in Swedish (filename ends with _SV)

Each file provides detailed explanations of how the application works and how the code is structured.

API Endpoints Used
The following endpoints from DummyJSON are utilized:

/products – for product-related data

/users – for user profiles and information

/posts – for user-generated posts

/comments – for comments on posts

Additional relevant endpoints as needed

Example Use Cases
Product/User Review System
Combines the /products, /users, and /comments endpoints to allow users to leave and view reviews on products.

Social Media Dashboard
Uses the /users, /posts, and /comments endpoints to create a simple dashboard showing user profiles along with their posts and related comments.

E-commerce Inventory and Price Monitoring
Utilizes /products and /users to monitor product inventory levels and track price changes, mimicking a basic e-commerce backend system.

User Data Update Feature (PATCH Test)
From the Update tab (as shown in the interface), users can enter a user ID, modify specific details such as name, age, or gender, and save the changes. These updates are sent back to the server using a PATCH request, testing the update functionality effectively.