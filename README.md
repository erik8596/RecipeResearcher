# RecipeResearcher

**C# / .NET 8 / Windows Forms — ingredient inventory and recipe selection**

RecipeResearcher is an academic desktop application prototype for managing a personal ingredient inventory and exploring recipes from a locally stored dataset. The project demonstrates C# application development with Windows Forms, file I/O, interfaces, and several object-oriented design patterns.

Users can navigate between ingredient and recipe screens, add or remove inventory items, optionally record expiration dates, and select recipe categories such as **Regular**, **Vegan**, **Keto**, and **Gluten-Free**.

> **Development snapshot:** This repository contains the source code for a Windows Forms project, but some included source files are unfinished or inconsistent, and the checked-in project is **not confirmed to compile as-is**. See [Known Limitations](#known-limitations) before attempting to run it.

## Features Represented in the Code

- **Windows Forms interface:** Multiple screens for navigation, ingredient inventory, recipe browsing, and recipe preferences.
- **Ingredient management:** Add ingredients from a predefined list, prevent duplicate entries, optionally record an expiration date, and remove entries from a local text file.
- **Recipe category selection:** Choose Regular, Vegan, Keto, or Gluten-Free recipes and a desired result count.
- **Local recipe dataset:** Select recipes from a bundled text resource rather than a web API.
- **Recipe selection:** The corresponding recipe classes randomly select from their category and write results to `UnfilteredRecipes.txt`.
- **Ingredient comparison:** Identify missing ingredients by comparing a saved ingredient list against each recipe's ingredient list.
- **Formatted recipe display:** Prepare recipe text for the UI, including marked-up missing ingredients.
- **File watching:** Code for observing inventory-file changes and refreshing the recipe display.

These points describe the intent and implementation present in the source; they are **not** claims that the current checkout runs end to end without changes.

## Technology Stack

| Technology | Use |
| --- | --- |
| **C#** | Application logic, interfaces, and data handling |
| **.NET 8 (Windows)** | Target framework: `net8.0-windows` |
| **Windows Forms** | Desktop graphical interface |
| **Visual Studio** | Solution and project organization |
| **File I/O / embedded resources** | Store ingredient selections and read the bundled recipe dataset |
| **LINQ** | Select, filter, and shuffle recipe records |
| **FileSystemWatcher** | Observe changes to a local inventory file |
| **async/await and Task** | Recipe selection methods run asynchronously |

**No external recipe API, database server, or AI model is integrated in the published code.** The included recipe links point to illustrative `example.com` addresses.

## Application Flow

~~~text
MainScreen (welcome screen)
         |
         v
SelectOption (navigation)
    |        |          |
    |        |          +--> AddIngredients
    |        |                    |
    |        +--------------------+--> MyIngredients
    |
    +--> MyRecipes --> EnterPreferences
             |                |
             |                v
             |        RecipeFactory chooses type
             |                |
             |                v
             |        Embedded recipesDB.txt
             |                |
             |                v
             |        UnfilteredRecipes.txt
             |
             +--> Compare recipes with MyIngredients.txt
                      |
                      v
                 Recipe list UI
~~~

The recipe-generation classes select from prewritten local recipes; the application does **not** generate original recipe instructions.

## Architecture and Design Patterns

### Factory Method–style object creation

`RecipeFactory.cs` chooses a `RecipeIF` implementation based on a recipe category:

- `RegularRecipe.cs`
- `VeganRecipe.cs`
- `KetoRecipe.cs`
- `GlutenFreeRecipe.cs`

Each implementation reads `recipesDB.txt` and writes a selection of recipes to a local output file.

### Observer pattern concepts

`FileWatcher.cs` wraps .NET's `FileSystemWatcher` and allows observers to register for file change notifications through the `FileObserver` interface. `MyRecipes.cs` contains code intended to refresh the recipe list when the ingredient inventory file changes.

### Filtering and decoration concepts

`IngredientAvailabilityPullFilter.cs` compares a recipe's ingredients against the user's saved inventory. `FilteredRecipes.cs` prepares display strings and marks missing ingredients for red rendering in the recipe list UI. Additional wrapper and decorator classes explore object-oriented structure, though some are incomplete.

## Project Layout

~~~text
RecipeResearcher/
├── FinalProjectGUI.sln                 # Visual Studio solution
└── RecipeResearcher/
    ├── FinalProjectGUI.csproj          # .NET 8 Windows Forms project
    ├── Program.cs                      # Application entry point
    ├── MainScreen.cs                   # Initial form
    ├── SelectOption.cs                 # Main navigation screen
    ├── AddIngredients.cs               # Add ingredients and expiration dates
    ├── MyIngredients.cs                # Display and remove inventory entries
    ├── MyRecipes.cs                    # Display recipe results
    ├── EnterPreferences.cs             # Dietary preference and count controls
    ├── RecipeFactory.cs                # Selects a recipe category implementation
    ├── *Recipe.cs                      # Recipe types and models
    ├── *PullFilter.cs                  # Ingredient filtering components
    ├── FileWatcher.cs                  # Change notifications
    ├── ingredientDB.txt                # Predefined ingredient names
    └── recipesDB.txt                   # Bundled sample recipe data
~~~

The repository also contains Windows Forms Designer and resource files associated with its screens.

## Development Environment

The solution targets **Windows** and **.NET 8 Windows Forms**, so it is intended to be developed on a Windows system with Visual Studio and the **.NET desktop development** workload installed.

To inspect the project:

~~~bash
git clone https://github.com/erik8596/RecipeResearcher.git
~~~

On Windows, open `FinalProjectGUI.sln` in Visual Studio.

**Important:** The current published source has incomplete classes and interface definitions; opening the solution is useful for inspecting the code, but building or running the application is not guaranteed. The development snapshot needs source fixes first.

## Local Data

- `ingredientDB.txt` — embedded list used to populate the ingredient selection dropdown.
- `recipesDB.txt` — embedded sample recipes with category labels, ingredient lists, and placeholder URLs.
- `MyIngredients.txt` — runtime ingredient-inventory text file written or read by the interface.
- `UnfilteredRecipes.txt` — runtime selection file written by the recipe-category classes and read by the recipe-view code.

The runtime files may not be created automatically in every startup path; their expected locations should be standardized as part of future maintenance.

## Known Limitations

- **Incomplete C# source:** `RecipeInventoryListBoxFuture.cs` contains unfinished class code and references types not defined in this repository. This is an apparent compilation blocker.
- **Interface inconsistencies:** `AbstractRecipeInventoryListBoxIF.cs` contains a nested interface declaration, while other classes use the outer interface as though it exposes `Display()`. `MyIngredients.cs` also declares `FileObserver` without implementing its `Update()` method. These need correction before claiming a working build.
- **Recipe filtering:** The current `IngredientAvailabilityPullFilter` returns recipes with **at least one missing ingredient**, rather than all recipes sorted by ingredient availability. Display behavior may not match user expectations.
- **Recipe URLs:** The bundled URLs are placeholder `example.com` links rather than validated recipe pages.
- **Expiration dates:** The inventory form can record expiration dates, but the `ExpirationDatePullFilter` is not implemented.
- **UI and navigation:** Some event handlers and planned object-oriented components are placeholders.
- **Testing:** No automated tests or CI workflow are included. The application was not executed for this documentation update.

## Possible Next Steps

1. Fix the incomplete classes and interfaces so the solution builds.
2. Standardize paths and initialize runtime text files on first launch.
3. Refine filtering to show recipes by available/missing ingredients and verify display behavior.
4. Implement expiration-date filtering and add input validation.
5. Add automated unit tests for recipe selection, file parsing, and filters.
6. Capture screenshots of the Windows Forms interface once a runnable build is available.

## Project Purpose

RecipeResearcher illustrates the design of a desktop application that combines a GUI, local data, file I/O, and object-oriented concepts. It is most useful as a **C#/.NET learning and software-design portfolio project**, with its current implementation limitations noted above.
