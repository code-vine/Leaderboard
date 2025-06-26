# 🎮 Secure Leaderboard API

A full-stack.NET Core designed to display and manage a dynamic top-score leaderboard with secure token-based submission, featuring MVC, Identity integration, and role-restricted endpoints.

## ✨ Features

- 🏆 Display the top 10 leaderboard entries
- 🔐 Admin-exclusive score submission through a JWT-protected API
- 🧾 Custom `/token` endpoint for issuing secure access tokens
- 🛡️ Role-based authorization with `client_id` claim validation- 💾 Data storage backed by SQL Server and Entity Framework Core
- 🧪 Test-ready API design compatible with Postman

 🧰 Tech Stack

- ASP Core MVC
- Entity Core with Identity
- JWT Authentication
 SQL Server SQLite (urable)
- Bootstrap for user interface styling

## 🚀 Getting Started

### 1. Clone the Repository

```bash
git clone https://.com/your-username/secure-leaderboard-api.git
cd secure-leader-api
```

### 2. Configure AppSettings

Update the `settings.json` file with your custom secrets:
```json
"Jwt": {
  "Issuer "API",
  "Audience": "LeaderboardClient",
  "Key": "super-secret-key-12345"
},
"ClientAuth": {
  "ClientId": "my-trusted-client",
  "ClientSecret": "supa-secret-67890"
}
```

🔑 Ensure to use a secure, random key in production environments.

### 3. Migrations

 the following command to apply database migrations:
```bash
dotnet ef database update
```

### 4. Launch the Application

Run the application using:
```bash
dot run```

Submit via a POST request to `/api/LeaderboardApi/submit` using a valid token### 🔐 Token Generation

Generate a token by sending a POST request to `/api/tokenenerate` with the following:
```json
clientId": "my-trusted-client",
 "clientSecret": "supa-67890"
}
```

Include the returned JWT in Authorization header for subsequent requests:
```
Authorization: Bearer <your-token>
```

📦 Deployment: Update connection and JWT values as required for production environments.


🙌 Author
Built by code-vine: an aspiring software engineer focused on real-world solutions, security, and polish.


