# Smart Corporate Workspace Management System

## Overview
Smart Corporate Workspace Management System is a Windows Forms application developed using C# and SQL Server to manage corporate hubs, workspaces, members, equipment, and reservations.

The system provides a complete management solution with CRUD operations, search functionality, validation, and relational database handling.

---

## Features

### Hubs Management
- Add new hubs
- Update hub information
- Delete hubs with related workspace handling
- Search hubs by:
  - Hub ID
  - Location
  - Layout

### Workspaces Management
- Add and update workspaces
- Assign workspaces to hubs
- Search workspaces
- Automatic hub information loading
- Delete workspace reservations automatically before deleting workspace

### Members Management
- Add and update members
- Search members by:
  - ID
  - Name
- Delete member reservations automatically before deleting member

### Reservations Management
- Create and update reservations
- Link reservations with:
  - Members
  - Workspaces
  - Equipment
- Automatic workspace and hub information loading
- Equipment selection using ComboBox

### Equipment Management
- Add and update equipment
- Delete equipment with reservation dependency handling

---

## Technologies Used

- C#
- Windows Forms (WinForms)
- SQL Server
- ADO.NET
- 3-Tier Architecture

---

## Project Structure

```text
SmartCorporate/
│
├── Data_Access_Layer/
│   ├── ClsDataAccessSettings.cs
│   ├── ClsHubsData.cs
│   ├── ClsMembersData.cs
│   ├── ClsWorkspacesData.cs
│   ├── ClsReservationsData.cs
│   └── ClsEquipmentData.cs
│
├── Business_Layer/
│   ├── ClsHubs.cs
│   ├── ClsMembers.cs
│   ├── ClsWorkspaces.cs
│   ├── ClsReservations.cs
│   └── ClsEquipment.cs
│
├── Presentation_Layer/
│   │
│   ├── Hubs/
│   │   ├── frmAddEditHub.cs
│   │   ├── frmListHubs.cs
│   │   └── frmHubInfo.cs
│   │
│   ├── Members/
│   │   ├── frmAddEditMember.cs
│   │   ├── frmListMembers.cs
│   │   └── frmMemberInfo.cs
│   │
│   ├── Workspaces/
│   │   ├── frmAddEditWorkspace.cs
│   │   ├── frmListWorkspaces.cs
│   │   └── frmWorkspaceInfo.cs
│   │
│   ├── Reservations/
│   │   ├── frmAddEditReservation.cs
│   │   ├── frmListReservations.cs
│   │   └── frmReservationInfo.cs
│   │
│   ├── Equipments/
│   │   ├── frmAddEditEquipment.cs
│   │   ├── frmListEquipments.cs
│   │   └── frmEquipmentInfo.cs
│   │
│   ├── Recourses/
│   │
│   └── frmMain.cs
│
├──  SmartCorporate.sql
│
├──  Smart Corporate Workspace.sln
│
└── README.md
```

---

## Database Relations

The system uses relational database constraints between:
- Hubs → Workspaces
- Workspaces → Reservations
- Members → Reservations
- Equipment → Reservations

Deletion operations are handled carefully to preserve database integrity.

---

## Main Functionalities

- CRUD Operations
- Dynamic Searching
- Data Validation
- Foreign Key Constraint Handling
- Delegate/Event Communication Between Forms
- Automatic Related Data Loading

---

## Author
Developed as a Smart Corporate Management Desktop Application Project using C# WinForms and SQL Server.
