# Hair Salon

#### Latest version date 2020/07/31

#### By Spencer Moody

## Description
This application uses MySQL and Entity to create a webpage that allows the user to add stylists and each of their clients along with details that might be pertinent. All information added is stored in a database and will have the option to either edit or delete.

## Specifications

1. **Behavior:** The user is welcomed with a splash page and given the option to view Stylists or view Clients.
* **Input Example:** "View Stylists" or "View Clients"
* **Output Example:** /Stylists or /Clients 

2. **Behavior:** The user can add a new stylist with their specialty.
* **Input Example:** "Add a Stylist"
* **Output Example:** /Stylists/Create

3. **Behavior:** The user can add a new client to a specific stylist.
* **Input Example:** "Add new Client"
* **Output Example:** /Clients/Create

4. **Behavior:** The user can edit existing stylist information
* **Input Example:** "Edit Stylist Info"
* **Output Example:** /Stylists/Edit/{StylistId}

5. **Behavior:** The program will allow the user to delete a stylist.
* **Input Example:** "Delete Stylist"
* **Output Example:** /Stylists/Delete/{StylistId}

5. **Behavior:** The program will allow the user to delete a client.
* **Input Example:** "Delete Client"
* **Output Example:** /Clients/Delete/{ClientId}

4. **Behavior:** The user can edit existing client information
* **Input Example:** "Edit Client Info"
* **Output Example:** /Clients/Edit/{ClientId}

## Setup and Installation

Software Requirements
1. .NET framework
2. A code editor (Visual Studio Code, Atom, etc.)

Acquire The Repo:
1. Click the 'Clone or Download Button
2. Alternately, Clone via Bash/GitBash: `git clone {repo}`

Editting the Code Base:
1. Open the project in your code editor; with Bash, this is done by navigating to the project directory, then `code .`
2. If you wish to run testing, you'll need the testing packages: navigate into the .Tests folder, and run `dotnet restore`

Running the program:
1. To run the program, you'll need to compile the code: `dotnet build`. This will create a compiled application in the bin/ folder.
2. Alternately, you can run the program directly with `dotnet run`.

## MySQL Installation and Setup

1. Download the MySQL Web Installer from the [MySQL Downloads re](https://dev.mysql.com/downloads/file/?id=484914) with the "No thanks, just start my download" link.
2. Follow along with the installer:
* Click "Yes" if prompted to update.
* Accept license terms.
* Choose Custom setup type.
* When prompted to Select Products and Features, choose the following:
  * MySQL Server 8.0.19 (This will be under "MySQL Servers > MySQL Server > MySQL Server 8.0")
  * MySQL Workbench 8.0.19 (This will be under "Applications > MySQL Workbench > MySQL Workbench 8.0")
* Select "Next", then "Execute". Wait for download and installation. (This can take a few minutes.)
* Advance through Configuration as follows:
  * High Availability set to "Standalone".
  * "Defaults are OK" under Type and Networking.
  * Authentication Method set to Use Legacy Authentication Method.
  * Set password to epicodus. You can use your own if you want but epicodus will be assumed in the lessons.
  * Defaults are OK under Windows Service. Make sure that checkboxes are checked for the options "Configure MySQL Server as a Windows Service" and "Start the MySQL Server at System Startup". Under Run Windows Service as..., the "Standard System Account" should be selected.
* Complete Installation process.

Create a local database:
1. Open MySQL WorkBench and the click on Local Insstance 3306.
2. Click the plus symbol in the top left corner of the window "Create a new SQL tab for executing queries"
3. Then copy and pase the following code into the window to create your database.

```
DROP DATABASE IF EXISTS `spencer_moody`;
CREATE DATABASE `spencer_moody`;

DROP TABLE IF EXISTS `clients`;
CREATE TABLE `clients` (
  `ClientId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `ContactInfo` varchar(255) DEFAULT NULL,
  `StylistId` int DEFAULT '0',
  PRIMARY KEY (`ClientId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `stylists`;
CREATE TABLE `stylists` (
  `StylistId` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `Specialty` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
```


## Bugs

No bugs

## Tech used

* C#
* .NET

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Spencer Moody
