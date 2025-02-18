# Cloud-Based-Expense-Tracker-Azure-C-
Cloud-Based Expense Tracker (Azure + C#) 
expense-tracker/  
├── backend/                  # Azure Functions (C#)  
│   ├── ExpenseTracker.Api/  
│   │   ├── Functions/        # HTTP Triggers  
│   │   │   └── CreateExpense.cs  
│   │   ├── Models/           # Data Models  
│   │   │   └── Expense.cs  
│   │   ├── local.settings.json  
│   │   └── host.json  
│   └── ExpenseTracker.Api.csproj  
├── frontend/                 # React.js  
│   ├── src/  
│   │   └── App.js  
│   └── package.json  
├── infra/                    # Terraform  
│   ├── main.tf  
│   └── variables.tf  
├── .github/                  # GitHub Actions  
│   └── workflows/  
│       └── deploy.yml  
└── README.md  
