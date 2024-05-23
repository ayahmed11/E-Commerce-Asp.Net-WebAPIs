# E-commerce API

## Overview
The E-commerce API is designed to support online shopping activities by providing functionalities for managing user carts, orders, products, categories, and user authentication. It is structured using an N-tier architecture to separate concerns into different layers, ensuring a clean and maintainable codebase.

## Features
- **User Management**: Users can register and log in to the system.
- **Shopping Cart**: Users can add, remove, update items, and clear their shopping cart.
- **Order Management**: Users can place orders and view their order history.
- **Product and Category Management**: Users can view all products, details of specific products, and all categories.
- **Admin Features**: Admins can perform CRUD operations on products and add new categories.

## Project Structure
The project is divided into three main layers:

1. **Data Access Layer (DAL)**:
   - **Models**: Entity Framework Core data models.
   - **Context**: Database context for Entity Framework Core.
   - **Repositories**: Repositories for accessing different entities.

2. **Business Logic Layer (BL)**:
   - **Managers**: Responsible for implementing business logic for various functionalities.

3. **API Layer**:
   - **Controllers**: Define RESTful endpoints for client interactions.

## Technologies Used
- **ASP.NET Core**: Framework for building web APIs.
- **Entity Framework Core**: ORM for database interactions.
- **Identity Framework**: For user authentication and authorization.
- **Dependency Injection**: Promotes loose coupling by managing dependencies.
- **Postman**: For API documentation and testing.

## Controllers
### CartController
Manages user shopping cart operations.

- **Endpoints**:
  - `GET /api/cart`: Retrieve the user's cart.
  - `POST /api/cart/{productId}/{quantity}`: Add a product to the cart.
  - `DELETE /api/cart/{productId}`: Remove a product from the cart.
  - `PUT /api/cart/{productId}/{quantity}`: Update the quantity of a product in the cart.
  - `DELETE /api/cart`: Clear the cart.
- **Authorization**: Requires user authentication.

### OrderController
Handles order-related operations.

- **Endpoints**:
  - `POST /api/orders/place-order`: Place an order.
  - `GET /api/orders/order-history`: Retrieve the user's order history.
- **Authorization**: Requires user authentication.

### ProductsController
Manages product-related operations, including image handling.

- **Endpoints**:
  - `GET /api/products`: Retrieve products, optionally filtered by category or name.
  - `GET /api/products/{id}`: Retrieve details of a specific product.
  - `POST /api/products`: Add a new product with image upload functionality.
  - `PUT /api/products/{id}`: Update an existing product with image upload functionality.
  - `DELETE /api/products/{id}`: Delete a product.
- **Authorization**: Add, update, and delete operations require admin privileges.

### UsersController
Handles user authentication and registration.

- **Endpoints**:
  - `POST /api/users/login`: User login and obtain an access token.
  - `POST /api/users/register`: User registration.
- **Authorization**: No authorization required for these endpoints.

### CategoryController
Manages category-related operations.

- **Endpoints**:
  - `GET /api/category`: Retrieve all categories.
  - `POST /api/category`: Add a new category.
- **Authorization**: Adding a category requires admin privileges.

