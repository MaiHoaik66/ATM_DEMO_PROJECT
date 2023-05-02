# ATM_PROJECT 

### MEMBERS:
- Mai
- Hoài

### LANGUGAE
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)

### DATABASE (NAME = "BankDB")
![MicrosoftSQLServer](https://img.shields.io/badge/Microsoft%20SQL%20Server-CC2927?style=for-the-badge&logo=microsoft%20sql%20server&logoColor=white)

### Test account:
- CardID: 4122-8934-5678-9010
- PIN: 654321

### Encryption Algorithm: RSA

### Description:
- This is a project containing Client app made by WINFORM (C#) and Server app made by ASP.NET CORE, both using .NET 6.

- Client makes some transaction with Server and data transferred between them are encrypted using RSA algorithm (PKCS#1 format)

### REQUIREMENT TO RUN PROJECT
- ASP.NET CORE 6
- NET 6 SDK
- SQL SERVER

### STEP TO RUN APP

#### Step 1

- Run the following command in powershell or cmd or other shells in other OS to download "dotnet ef" tool

```
dotnet tool install --global dotnet-ef
```

#### Step 2

- Open the Server project and run the latest migration by entering this command in shell to create the BankDB database with the latest data
```
dotnet ef database update
```

#### Step 3
- Start the Server project

#### Step 4
- Start the Client project

#### Step 5
- Login using the test account in the client app

#### step 6
- Test the app
---

## HAVE A GOOD DAY 💖💖

