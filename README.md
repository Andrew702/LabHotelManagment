🏨 Hotel Manager
A Windows Forms desktop application for managing hotel operations — built for front desk staff to manage guests, rooms, and reservations, and for kitchen staff to track meal delivery.

Tech Stack
LayerTechnologyUIWindows Forms (.NET)ORMEntity Framework CoreQuery LayerDapperDatabaseSQL ServerLanguageC#

Features
Front Desk

Guest Management — register and update guests with full details (name, phone, date of birth, gender)
Room Management — manage rooms by type (Single, Double, Triple) and floor number
Reservation Management — create, update, and delete reservations with check-in/check-out dates
Room Availability Check — prevents double-booking by validating date ranges before confirming
Food Option — flag reservations as with or without food service
Billing — finalize and process guest bills from the reservation screen

Kitchen

Meal Delivery Tracking — view all active reservations with food service
Meal Confirmation — mark meals as delivered per reservation per meal time
Missed Meal Logging — at each new meal time, any undelivered meals are automatically logged to MealsMissed.txt with guest name, phone, room number, and missed time
Meal Time Reset — resets all delivery flags at the start of each new meal time


Database Schema
Guests
├── ID (PK, Identity)
├── Fname          nvarchar(20)
├── Lname          nvarchar(20)
├── BDay           datetime2 (nullable)
├── PhoneNo        nvarchar(20)
└── Gender         int (enum: Male / Female)

Rooms
├── RoomNumber (PK, manual)
├── Type           int (enum: Single / Double / Triple)
└── Floor          int

Logins
├── Username (PK)  nvarchar(20)
├── Password       nvarchar(20)
└── AccType        int (enum: FrontDesk / Kitchen)

Reservations
├── ReservationID (PK, Identity)
├── GuestID        (FK → Guests, cascade delete)
├── RoomNumber     (FK → Rooms, cascade delete)
├── withFood       bit
├── From           datetime2
├── To             datetime2
└── MealDeliveredFlag  bit

Architecture
The app uses a hybrid data access pattern:

Dapper handles all read queries — fast, lightweight SQL for loading guests, rooms, and reservations into memory
Entity Framework Core handles all write operations — insert, update, and delete

This gives the read performance of raw SQL while keeping EF's change tracking for writes.
The kitchen form uses EF exclusively with eager loading since it works with a filtered live view of reservations (withFood == true).

Application Flow
Login
  ├── Front Desk → frmFrontend
  │     ├── View / Edit reservations and guest info
  │     ├── Add new reservation → frmNewReservation
  │     └── Finalize bill → frmPayment
  │
  └── Kitchen → frmKitchen
        ├── View all food reservations
        ├── Mark meals as delivered
        └── New meal time → log missed meals → reset flags

Getting Started
Prerequisites

Windows 10/11
.NET 6 or later
SQL Server (local or remote)

Setup

Clone the repository

bash   git clone https://github.com/yourusername/hotel-manager.git

Update the connection string in HotelContext.cs

csharp   options.UseSqlServer("your_connection_string_here");

Apply migrations

bash   dotnet ef database update

Run the application

bash   dotnet run

Project Structure
LabHotelManagment/
├── Context/
│   └── HotelContext.cs              # EF DbContext
├── Entities/
│   ├── Guest.cs
│   ├── Room.cs
│   ├── Reservation.cs
│   └── Login.cs
├── Managers/
│   ├── ReservationManager.cs        # Dapper queries
│   └── RoomManager.cs               # Dapper queries
├── Forms/
│   ├── frmFrontend.cs               # Front desk — reservations & guests
│   ├── frmNewReservation.cs         # New reservation form
│   ├── frmPayment.cs                # Billing form
│   └── frmKitchen.cs                # Kitchen meal delivery tracking
├── Migrations/
│   └── ...                          # EF migration history
└── Helpers/
    └── ListDisplay.cs               # Display helper for list controls

Missed Meals Log
Every time kitchen staff clicks New Meal Time, the system logs all undelivered meals to MealsMissed.txt in the application directory:
Name: James Wilson, Phone: +1-555-0101, RoomNo: 101, Meal Missed at: 12/01/2024 09:00:00
Name: Sarah Johnson, Phone: +1-555-0102, RoomNo: 203, Meal Missed at: 12/01/2024 09:00:00
