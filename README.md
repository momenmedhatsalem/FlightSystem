# ✈️ FlightSystem

A Windows Forms–based **flight reservation and management system** developed in C# using .NET Framework. This project supports admins and users in handling aircrafts, bookings, and reports — all backed by a SQL Server database.

---

### 📂 Project Structure

* `FlightSystem.sln` – Visual Studio solution file
* `FlightSystem/` – Main application source:

  * UI forms like `AdminHome`, `UserLogin`, `Booking`, `AddFlight`, etc.
  * Aircraft/Flight CRUD management
  * Embedded image resources
* `crebas.sql` – SQL schema to initialize the backend database

---

### 💡 Key Features

✅ **Admin Panel**

* Add/edit/delete flights and aircrafts
* View reports and user data
* Admin signup/login system

✅ **User System**

* Sign up / Log in
* Book flights, view details
* Update personal info

✅ **Booking & Management**

* Real-time form-based booking UI
* Ticket generation logic
* Flight selection and filtering

✅ **Database Integration**

* SQL Server–powered backend (via `crebas.sql`)
* Booking history, flight schedules, user management stored persistently

---

### ⚒️ Tech Stack

| Layer        | Technology    |
| ------------ | ------------- |
| Language     | C# (.NET)     |
| UI Framework | WinForms      |
| Database     | SQL Server    |
| IDE          | Visual Studio |

---

### 🚀 Getting Started

1. **Clone the repo:**

   ```bash
   git clone https://github.com/momenmedhatsalem/FlightSystem.git
   cd FlightSystem
   ```

2. **Open the solution** in Visual Studio:

   * Open `FlightSystem.sln`

3. **Set up the database:**

   * Run `crebas.sql` in SQL Server to generate required tables

4. **Build and run the app:**

   * Press `F5` or use the `Start` button in Visual Studio

---

### 📸 Screenshots (Optional)

You can add images from:

```
FlightSystem/Resources/*.png
```

to show the UI (e.g. `home.png`, `flight.png`, `ticket.png`, etc.)

---

### 👤 Author

**Momen Medhat Salem**
A Computer Science student with experience in Django, C#, Python, SQL, and full-stack app development.

---

### 📄 License

*This project currently has no license. Consider adding one (MIT, GPL, etc.) if needed.*

---

### ✅ To-Do (Optional)

* [ ] Add multi-language support
* [ ] Improve UI responsiveness
* [ ] Export tickets as PDFs
* [ ] Implement unit tests

---

### 📅 Contributors

> Add below your name and GitHub profile (you can edit this!):

* **Momen Medhat Salem** - [@momenmedhatsalem](https://github.com/momenmedhatsalem)
* **Ziad Mohammad Abdelhakam** - [@ZiadEisa](https://github.com/ZiadEisa)
* **Sayed Reda** - [@SayedReda1](https://github.com/SayedReda1)
* **Ahmed A.** - [@AhmedA005](https://github.com/AhmedA005)

---

## 💬 Final Word

> From database schema to pixel-perfect WinForms — this project flies high and lands smooth.
> Just like the best systems, it’s built to move fast and stay grounded.
