# bridal-order-system
A Windows Forms application for managing and processing bridal orders that I made for a local company. Built using Visual Basic in Visual Studio 2022 as part of amy A-Level Computer Science coursework project.

## Features
- Login system with user management (add, edit, remove users)
- User access levels
- Side-tab main menu with navigation to all key forms
- Start new sale: capture customer, order, and payment details
- Easy filtration of customer, order and payment details
- View, add, edit, and delete:
  - Customers
  - Orders
  - Payments
  - Suppliers
- All data is stored through a connected Microsoft Access Database

## Demo
Watch a short demo of the order system by following this link
https://youtu.be/TBljnY3zZD4


## Getting Started

### Prerequisites

- Windows 10 or later
- Visual Studio 2022
- .NET Framework (typically 4.7.2 or similar)

### Build and Run

1. **Clone or download the project:**
   - Git: `git clone https://github.com/your-username/bridal-order-system.git`
   - Or download the ZIP and extract it

2. **Open the solution file:**
   - `Bridal Database.sln` in Visual Studio

3. **Build the solution:**
   - Build > Build Solution

4. **Run the app:**

5. **Admin login credentials:**
   - Username: `h`
   - Password: `h`

## Project Structure
- `Bridal Database.sln` — Solution file
- `/Bridal Database/` — Source code and forms
- `/docs/` — Coursework documentation (analysis, design, coding, evaluation)
  
## Notes
### Project Status
- The **Reports** section has not been coded yet
- I intend to add a stock list which the user can make changes to
- I intend on increasing the efficiency of my code by making use of functions etc
- I am still working with the company and aim to finish my project soon

### Slightly outdated documentation
-Since I last made changes to my documentation (in the docs folder), i have added a few features and fixed a few bugs. Therefore, my screenshots and code are slightly outdated as I have not yet updated them.

### Unblocking .resx Files (if downloaded as ZIP)
-If Visual Studio shows errors related to `.resx` files:
  - Right-click each `.resx`, click **Properties**, then check **Unblock**
  - Or run this PowerShell:
    ```powershell
    Get-ChildItem -Recurse -Filter *.resx | Unblock-File
