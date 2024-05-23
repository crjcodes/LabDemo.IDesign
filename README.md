# Purpose

An exploration of applying IDesign principles to a common .NET solution.

The system solves a problem for the user: how to manage and see his or her individual laboratory bloodwork results.

## Reference

1. [Design](0-Documentation/Design.md) -- includes use cases, architecture
1. Development -- details on container setup, CI-CD, etc
1. Test -- how to test, kinds of test

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

## How to Develop and Run

### Pre-Requisites

You can run the system from an IDE, from the command-line, from the Docker images, or, the usual case, through the IDE into the containers.

#### DOCKER

1. IDE 
    a. Visual Studio recommended or familiarity with dotnet commands from the command-line
    b. Instructions below are tailored to VS 2022 Community Edition v17 and the command-line

1. Install Docker for Desktop
    a. Run Docker for Desktop and accept service agreement
        i.  Docker will consume much disk space, especially if you do not clean up built images and containers as you go
        ii. You may want to install Docker for Desktop from the command-line specifying a directory
    b. Use recommended settings
    c. Continue to use without a subscription (or login, if you prefer)
    d. Add docker to the system PATH environment variable (for Windows; similar for Apple?)

#### COMMAND-LINE

Code-first database migration support:

1. Install the Entity Framework command-line tools 
    a. Reference: "[Install the Tools](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli)"
    b. I prefer the dotnet tools from a Git Bash for Windows console, but use your CLI of choice: 
        i. `dotnet tool install --global dotnet-ef`
        ii. `dotnet add package Microsoft.EntityFrameworkCore.Design`
        iii. Verified via `dotnet ef`
        iv. For updates later: `dotnet tool update --global dotnet-ef`


1. Get the latest [Postgres base container](https://www.docker.com/blog/how-to-use-the-postgres-docker-official-image/)
    a. From the Docker window, search for "postgress" and click 'Pull'
    b. Alternatively, `docker pull postgres` from the command-line
    c. Optionally confirm by `docker image ls` from the command line

1. Get a Postgres viewing tool, like pgAdmin (advanced: you can run pgadmin in a separate Docker container)

### Initial Setup

1. Clone existing repo from github
1. Create your own branch
1. Declare a system environment variable, `DOTNET_ENVIRONMENT` and set to the desired hosting environment, usually `Development`
1. Declare a system environment variable, `BUILD_TARGET` and set t, usually `Development`

### Spinning Up Entire Solution

From the command line, `docker-compuse up -d` (and `docker-compose down` to stop)

Afterwards, you can browse the container, volume, and more in the Docker Desktop.

#### Postgres Database

##### Accessing Postgres database

With the docker container, `labdemo-idesign`, running, run pgAdmin (or equivalent).


<!--- Later
Create and maintain the database using Entity Framework Tools, a model-first approach.

These are the steps previously taken:

1. Open Nuget Package Manager console
1. Execute `Add-Migration` and `Update-Database`
--->





