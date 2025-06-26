# 🎮 Secure Leaderboard API

A full-stack ASP.NET Core application that displays and manages a dynamic top-score leaderboard with secure token-based submission. Built with MVC architecture, Identity integration, and role-restricted endpoints.

## ✨ Features

- 🏆 View top 10 leaderboard entries
- 🔐 Admin-only score submission via JWT-protected API
- 🧾 Custom `/token` endpoint for issuing secure access tokens
- 🛡️ Role-based authorization and `client_id` claim validation
- 💾 SQL Server-backed data storage with Entity Framework Core
- 🧪 Postman/test-ready API design

## 🧰 Tech Stack

- ASP.NET Core MVC
- Entity Framework Core + Identity
- JWT Authentication
- SQL Server / SQLite (configurable)
- Bootstrap for UI styling

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/secure-leaderboard-api.git
cd secure-leaderboard-api

### 2. Configure AppSettings

Update appsettings.json with your custom secrets:
"Jwt": {
  "Issuer": "LeaderboardAPI",
  "Audience": "LeaderboardClient",
  "Key": "super-secret-key-12345"
},
"ClientAuth": {
  "ClientId": "my-trusted-client",
  "ClientSecret": "supa-secret-67890"
}

🔑 Use a secure, random key in production.

### 3. Run Migrations

dotnet ef database update

### 4. Launch the App

dotnet run

Submit scores via POST /api/LeaderboardApi/submit with a valid token.

🔐 Token Generation
Use POST /api/token/generate:

{
  "clientId": "my-trusted-client",
  "clientSecret": "supa-secret-67890"
}

Then send the returned JWT in the Authorization header:
Authorization: Bearer <your-token>

📦 Deployment

Supports deployment to Azure App Service or Docker. 
Update connection strings and JWT values as needed for production environments.


🙌 Author
Built by code-vine: an aspiring software engineer focused on real-world solutions, security, and polish.


