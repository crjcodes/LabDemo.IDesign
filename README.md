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

### Technical Details

The user app is a standalone React SPA based on the Visual Studio 2022 template to expedite getting this demo up and running.

## Deployable Plan

Currently, 
1.  The user app will be spun up as its own web app, a SPA React app
1.  The thin minimal api client into the managers downward to the accessors will be a stand-alone service
1.  The database will be its own standalone deployable, but the entities will be shared with the accessors in the api client

This will result in three deployables running in different processes on the local host.

Eventually, these three can be containerized separately or in some combination together

Alternatives also exists, with a little rewriting, of running the user app and the API within the same container or even process, using internal messaging inside the process instead of the API approach.




