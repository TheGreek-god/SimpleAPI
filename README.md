# SimpleAPI

**SimpleAPI** is a lightweight **ASP.NET Core Web API** project used for demonstration and learning purposes.  
This guide includes steps to test, build, run, and containerize the API using Docker.

---

## 🚀 Quick Start

### Prerequisites
- Docker Desktop
- .NET 9.0 SDK for local development (Optional) 

### Run with Docker
```bash
# Build the Docker image
docker build -t simpleapi .

# Run the container
docker run -d -p 8080:8080 --name simpleapi-container simpleapi

# Test the API
curl http://localhost:8080/api/values
```

## 📡 API Endpoints

| Method | Endpoint                  | Description           | Sample Response                  |
|--------|---------------------------|---------------------|---------------------------------|
| GET    | /api/values               | Returns all values   | `["full-name", "nickname"]`     |
| GET    | /api/values/full-name     | Returns full name    | `"Okeke Tochukwu Finbarr"`      |
| GET    | /api/values/nickname      | Returns nickname     | `"The Greek-god"`               |
| GET    | /api/values/{id}          | Returns formatted ID | `"You requested ID: {id}"`     |

## 🧪 Testing

Run Tests
```bash
# Build and run tests in Docker
docker build -t simpleapi-test -f Dockerfile.test .
docker run --rm simpleapi-test

# Or run tests locally (if .NET SDK is installed)
dotnet test