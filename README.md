
# **UFARClassroom**

The **UFARClassroom** is a comprehensive application designed to help students effectively manage their academic tasks. Powered by Azure AI, the platform enables users to track deadlines, manage exams, and generate personalized daily schedules (e.g., study, coding, etc.). The project leverages modern technologies like Blazor, .NET 8, and Azure services to provide a seamless and interactive user experience.

---

## **Features**

### **Core Functionalities**

- **AI-Powered Scheduling**:  
  Leverages Azure OpenAI to provide personalized recommendations and daily plans.  
- **File Uploads**:  
  Upload documents (e.g., assignments, notes) using Azure Blob Storage for secure storage and retrieval.  
- **Sign In/Sign Up**:  
  Secure authentication system for user registration and login to access personalized features.  

### **Interactive UI**  

- AI interaction page featuring intuitive feedback, copy-to-clipboard, and clear input options.  
- **Feedback System**:  
  Users can provide feedback on AI recommendations, improving future interactions.

---

## **Tech Stack**

- **Frontend**:  
  - Blazor targeting .NET 8  
  - Razor components for UI logic and interactivity  

- **Backend**:  
  - ASP.NET Core Web API for data handling  
  - Entity Framework Core for database access  
  - Azure OpenAI for personalized AI recommendations  

- **Database**:  
  - Azure SQL for secure and scalable data storage  

- **Tools**:  
  - Visual Studio 2022  
  - GitHub for version control  
  - Swagger for API testing  

---

## **Live Deployment**

The backend application is live and hosted on Azure. You can access the API documentation [here](https://classroombackend.azurewebsites.net/swagger/index.html).

---

## **Setup Instructions**

Follow these steps to set up the project locally:

### **Prerequisites**

1. Install [Visual Studio 2022](https://visualstudio.microsoft.com/).  
2. Install the [.NET 8 SDK](https://dotnet.microsoft.com/download).  
3. Set up an [Azure account](https://azure.microsoft.com/).  
4. Clone this repository using:  

   ```bash
   git clone <repository-url>
   ```

### **Backend Setup**

1. Open the solution file (`UFAR.Classroom.sln`) in Visual Studio.  
2. Run the following commands to apply migrations and update the database:  

   ```bash
   dotnet ef database update
   ```

3. Configure your Azure SQL connection string in `appsettings.json`.  

### **Frontend Setup**

1. Navigate to the `UI` project folder.  
2. Restore dependencies using:  

   ```bash
   dotnet restore
   ```

3. Run the frontend project using:  

   ```bash
   dotnet run
   ```

---

## **Usage**

1. Access the application in your browser at `https://localhost:<port>` (for local testing) or at the live deployment URL.  
2. Use the following features:  
   - **AI Interaction**: Use the **AI Page** to interact with Azure AI for scheduling recommendations.  
   - **Upload Files**: Use the **File Upload** page to securely upload related documents.  
   - **Sign In/Sign Up**: Register and log in to access personalized features such as AI recommendations and schedule management.

---

## **Contributing**

We welcome contributions to improve this project!  
1. Fork the repository.  
2. Create a feature branch:  

   ```bash
   git checkout -b feature/your-feature-name
   ```

3. Commit your changes:  

   ```bash
   git commit -m "Add your message here"
   ```

4. Push to your fork:  

   ```bash
   git push origin feature/your-feature-name
   ```

5. Open a pull request.  

---

## **License**

This project is licensed under the MIT License. See the `LICENSE` file for details.

---

## **Acknowledgments**

- **Université Française en Arménie (UFAR)** for supporting this project.  
- **Microsoft Azure** for providing AI and storage solutions.
```

