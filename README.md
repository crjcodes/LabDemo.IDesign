# Purpose

An exploration of applying IDesign principles to a common .NET solution.

The system solves a problem for the user: how to manage and see his or her individual laboratory bloodwork results.

## Use Cases

1. User can enter labwork data
2. User can see labwork history visually
3. User can export the labwork data

## Architecture and Design

1. Clients
    - User app
2. Managers
    a. Entry Manager
        - POST endpoints to save labwork data
        - Includes a validation enginer
    b. Data Reporter Manager
        - GET endpoints to retrieve historical data
3. Accessors
    a. Save labwork
    b. Get individual lab marker
    c. Get labwork series
4. Resources
    a. First option: SQL Server database
    b. Second option: Postgres



