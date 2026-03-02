# 🏢 Reliance Store Management App
### 💻 Developed using C# & WinForms

![Language](https://img.shields.io/badge/Language-C%23-blue?logo=csharp)
![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey?logo=windows)
![IDE](https://img.shields.io/badge/IDE-Visual%20Studio-purple?logo=visualstudio)

> 🚀 A Windows Desktop Application built using **C#** and **Windows Forms (WinForms)** that simulates a product-based store system with categorized search, services information, and company details.

---

## 📖 Project Description

**Reliance Store Management App** is designed to provide a smooth desktop experience for managing and browsing products.  
The application includes category-based optimized search, company policies, and easy navigation across multiple pages.

---

## 🧰 Tech Stack

| Technology | Purpose |
|---|---|
| 💻 C# | Core programming language |
| 🪟 Windows Forms (WinForms) | UI Framework |
| 🗄️ ADO.NET | Database connectivity |
| 🛢️ SQL Server | Database |

---

## ✨ Features

### 🏠 Home Page
- 📄 Application description
- 🔗 Navigation links to other pages
- 📊 Dashboard-style interface

![Home Page](500.png)

### 🛍️ Products Page
- 📦 Displays product details:
  - Product ID
  - Product Name
  - Description
  - Price
  - Category
- ⚡ Dynamic data loading from database

![Products Page](502.png)

### 🔎 Category Optimized Search
- 🔎 **Category Optimized Search** (Single Query)
- 📂 Available Categories:
  - 💻 Laptop
  - 📱 Mobile
  - 🎵 Music

![Category Search](501.png)

### 🧾 Bill
- 🧾 Auto-generated billing for selected products
- 💰 Displays itemized product costs and total amount

![Bill](504.png)

### 🛠️ Services Page
- 📜 Store policies
- 🔄 Return & refund policy
- 📋 Terms and conditions
- 🤝 Customer guidelines

![Services Page](507.png)

### 📞 Contact Page
- 📧 Email details
- ☎️ Support information
- 📍 Company contact details

![Contact Page](506-Contact.png)

### ℹ️ About Us Page
- 🏢 Company background
- 🎯 Mission & Vision
- 🌟 Organizational values

![About Us Page](505-About.png)

---

## 📊 Database Schema

### Table: `Product`

| Column | Type | Constraint |
|---|---|---|
| `pid` | int | Primary Key |
| `pname` | varchar | — |
| `pdesc` | varchar | — |
| `price` | decimal | — |
| `category` | varchar | — |

---

## 💡 Optimized Category Search Query

```sql
SELECT * FROM Product
WHERE (@category IS NULL OR category = @category);
