# ePnpGui

**ePnpGui** is a Windows desktop application built using **WinForms** and **C#**, providing a graphical user interface for managing driver packages—similar to the functionality offered by the command-line tool `PnPUtil`.

## Key Features

- Add a driver package to the driver store
- Install a driver package on the system
- Delete a driver package from the driver store
- Enumerate non-inbox driver packages currently in the driver store
- Open the folder location of the selected driver
- Check for old/duplicate drivers
- Export the driver list to a `.csv` file

![Screenshot](ePnpGui.jpg)

### Requirements

- **.NET Framework** 4.5.1 or newer  
- **Windows 7** or newer  
- **Windows Server 2016** or newer  

---

### Build Instructions

To build the application:

1. Open the `ePnpGui.sln` file in **Visual Studio 2022**
2. Build the project using the **Release** configuration

---

### Installer

You can download the latest installer from the [Inno Output](./ePnpGui/Inno%20Output) folder.

---

### License

This project is provided as-is with no warranty. License information TBD.
