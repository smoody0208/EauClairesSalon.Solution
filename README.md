# Best Restaurants

#### Latest version date 2020/07/29

#### By Spencer Moody, Christine Augustine, and Allison Sadin

## Description
This application uses MySQL and Entity to create a webpage that allows the user to view different restaurants based on cuisines.

## Specifications

1. **Behavior:** The user is welcomed with a splash page and given the option to view Cuisines or view Restaurants.
* **Input Example:** "View Cuisines" or "Add a new Cuisine"
* **Output Example:** /Cuisines or /Restaurants 

2. **Behavior:** When the user navigates to "View Cuisines" a list of all Cuisines will be displayed, if there are no Cuisines the message "There are currently no Cuisines listed" and given the option to "Add a Cuisine".
* **Input Example:** "Add a Cuisine"
* **Output Example:** /Cuisines/Create

3. **Behavior:** If the user navigates to "Add a Cuisine" the program will allow the user to add a new Cuisine and then be directed to Cuisines.
* **Input Example:** "Add new Cuisine"
* **Output Example:** /Cuisines

4. **Behavior:** The program will allow the user to click on a Cuisine.
* **Input Example:** "Italian"
* **Output Example:** /Cuisines/Details/{CuisinesId}

5. **Behavior:** The program will allow the user to view all Restaurants.
* **Input Example:** "View Restaurants"
* **Output Example:** /Restaurants

6. **Behavior:** The program will allow the user to add a new Restaurant to a specific Cuisine.
* **Input Example:** "Add a Resturant"
* **Output Example:** /Restaurants/Create

7. **Behavior:** The program will allow the user to view Restaurant details.
* **Input Example:** "Johnnys Subs"
* **Output Example:** /Restaurants/Details/{RestaurantsId}

8. **Behavior:** The program will allow the user to edit Restaurant details.
* **Input Example:** "Edit This Restaurant"
* **Output Example:** /Restaurants/Edit/{RestaurantsId}

9. **Behavior:** The program will allow the user to edit Cuisine details.
* **Input Example:** "Edit This Cuisine"
* **Output Example:** /Cuisines/Edit/{CuisinesId}

10. **Behavior:** The program will allow the user to delete Cuisine details.
* **Input Example:** "Delete This Cuisine"
* **Output Example:** /Cuisines/Delete/{CuisinesId}

10. **Behavior:** The program will allow the user to delete Restaurant details.
* **Input Example:** "Delete This Restaurant"
* **Output Example:** /Restaurants/Delete/{RestaurantsId}

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

Copyright (c) 2020 Spencer Moody, Christine Augustine, Allison Sadin
