# ODIS API

## Overview
ODIS API is a RESTful web service built using ASP.NET Core, designed for managing addresses, persons, and session authentication. The API offers various endpoints for creating, updating, retrieving, and managing these entities.

## Technologies Used
- **ASP.NET Core**: Web framework for building the API.
- **Entity Framework Core**: ORM for data access.
- **Swagger**: API documentation tool.
- **JWT (JSON Web Tokens)**: Used for secure user authentication.
- **Redis**: Optional caching mechanism.

## API Testing with Postman

You can test the API using the Postman collection provided in this repository.

### Importing the Collection

1. Download the Postman collection from the repository: [OdisAPI.postman_collection.json](postman-collections/OdisAPI.postman_collection.json).
2. Open Postman and go to the **Collections** tab.
3. Click on **Import** and upload the downloaded `.json` file.
4. Set the environment variables such as `baseUrl` and `jwtToken` before making requests.

### Environment Variables

- `baseUrl`: Set this to `https://localhost:5001` (or the base URL where your API is running).
- `jwtToken`: Set this to the token you receive after logging in.
  
## Project Structure
- **Controllers**: Contains the API controllers handling HTTP requests and responses.
- **Models**: Defines the data models and DTOs used in the API.
- **Services**: Implements the business logic and interfaces for managing entities.
- **Configuration**: Includes environment-specific settings such as `appsettings.json`.

## API Endpoints

### Authentication
- **POST /api/dms/token**
  - Authenticates a user and returns a JWT token.
  - **Request Body**:
    ```json
    {
      "username": "user1",
      "password": "password1"
    }
    ```
  - **Response**:
    ```json
    {
      "token": "jwt-token-string"
    }
    ```

### Address Management
- **GET /api/dms/addresses/{addressId}**
  - Retrieves an address by its ID.
  - **Response**:
    ```json
    {
      "payload": {
        "addressId": "address-id",
        "street": "123 Main St",
        "city": "Sample City",
        "state": "Sample State",
        "zipCode": "12345"
      },
      "success": true,
      "message": null
    }
    ```
- **POST /api/dms/addresses**
  - Creates or updates an address.
  - **Request Body**:
    ```json
    {
      "street": "123 Main St",
      "city": "Sample City",
      "state": "Sample State",
      "zipCode": "12345"
    }
    ```
  - **Response**:
    ```json
    {
      "payload": {
        "addressId": "new-address-id"
      },
      "success": true,
      "message": null
    }
    ```

### Person Management
- **GET /api/dms/persons/{personId}**
  - Retrieves a person by their ID.
  - **Response**:
    ```json
    {
      "payload": {
        "id": "person-id",
        "firstName": "John",
        "surname": "Doe"
      },
      "success": true,
      "message": null
    }
    ```
- **POST /api/dms/persons**
  - Creates or updates a person.
  - **Request Body**:
    ```json
    {
      "firstName": "John",
      "surname": "Doe",
      "ageRange": "30-40",
      "cityOfBirth": "Sample City"
    }
    ```
  - **Response**:
    ```json
    {
      "payload": {
        "id": "new-person-id"
      },
      "success": true,
      "message": null
    }
    ```

## Setup and Running the Project

### Prerequisites
- .NET Core SDK 6.0+
- Redis (optional, if using caching)
- Postman (for testing API endpoints)

### Running the API
1. Clone the Repository:
   ```sh
   git clone https://github.com/your-repo/odis-api.git
   cd odis-api
   ```
2. Install Dependencies:
   ```sh
   dotnet restore
   ```
3. Update `appsettings.json`:
   Ensure the `JwtSettings` and `ConnectionStrings` are correctly configured for your environment.

4. Run the API:
   ```sh
   dotnet run
   ```
   The API will be available at `https://localhost:5001` by default.

## Testing with Postman
1. **Import Postman Collection**:
   Import the `OdisAPI.postman_collection.json` file into Postman to access predefined requests.

2. **Set Environment Variables**:
   - Set `baseUrl` to `https://localhost:5001`.
   - Set `jwtToken` to the token received after a successful login.

3. **Use Endpoints**:
   You can now use the imported collection to interact with the API endpoints.

## Documentation
- **Swagger**: Navigate to `/swagger` after running the API to view the Swagger documentation.

## License
This project is licensed under the MIT License.
