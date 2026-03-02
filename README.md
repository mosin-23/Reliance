🏢 Reliance Store Management App
💻 Developed using C# & WinForms

🚀 A Windows Desktop Application built using C# and Windows Forms (WinForms) that simulates a product-based store system with categorized search, services information, and company details.

📌 📖 Project Description

Reliance Store Management App is designed to provide a smooth desktop experience for managing and browsing products.
The application includes category-based optimized search, company policies, and navigation across multiple pages.

🛠️ 🧰 Tech Stack

💻 C#

🪟 Windows Forms (WinForms)

🗄️ ADO.NET

🛢️ SQL Server

✨ 🚀 Features
🏠 Home Page

📄 Application description

🔗 Navigation links to other pages

📊 Dashboard-style interface

🛍️ Products Page

📦 Displays:

Product ID

Product Name

Description

Price

Category

🔎 Category Optimized Search (Single Query)

📂 Available Categories:

💻 Laptop

📱 Mobile

🎵 Music

⚡ Dynamic data loading from database

🛠️ Services Page

📜 Store policies

🔄 Return & refund policy

📋 Terms and conditions

🤝 Customer guidelines

📞 Contact Page

📧 Email details

☎️ Support information

📍 Company contact details

ℹ️ About Us Page

🏢 Company background

🎯 Mission & Vision

🌟 Organizational values

🗂️ 📊 Database Schema

Table: Product

pid (int, Primary Key)

pname (varchar)

pdesc (varchar)

price (decimal)

category (varchar)

🔍 💡 Optimized Category Search Query

SELECT * FROM Product
WHERE (@category IS NULL OR category = @category);

✔ Uses a single query for dynamic category filtering
✔ Efficient and clean database handling

🎯 🌟 Key Highlights

✔ Clean WinForms UI Design
✔ Optimized database queries
✔ Simple navigation between forms
✔ Structured and maintainable code
✔ Beginner-friendly architecture

▶️ 🚀 How to Run

1️⃣ Clone the repository
git clone https://github.com/your-username/reliance-winforms-app.git

2️⃣ Open in Visual Studio

3️⃣ Configure SQL Server connection string

4️⃣ Run the application
