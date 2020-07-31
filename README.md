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

## Bugs

No bugs

## Tech used

* C#
* .NET

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Spencer Moody
