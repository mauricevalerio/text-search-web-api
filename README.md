# Text Search ASP.NET Core Web API

Problem statement for an entry level .NET developer job opening. 

NOTE: 
- [Front-End Repo](https://github.com/mauricevalerio/text-search-front-end)
- I did use Vue instead of Angular.
- Uses HTTP which is unsecure and recommended for development purposes.

## Software Requirements
- [Docker](https://www.docker.com/)

## Build Project
- Containerized web API application. Replace brackets with desired parameters.
    - `docker build -t [docker-image-name] [dockerfile path]`
    - `docker run -d -p [host-port]:8080 [docker-image-name]`
    - NOTE: host-port must be different from the web front-end

## Problem Description
Implement a text search web API written in Microsoft C# .NET Core deployed to in a local IIS and write the front-end in Angular 13 using Visual Studio Code. For Mac or Linux please implement the web API written in Java and deploy to Apache Tomcat and write the front-end in Angular 13 using Visual Studio Code.

### Problem Requirements
- The ability to search for text
- The ability to do a full word search
- The ability to do case sensitive search

### Inputs
- String - A sentence
- String - The text to search in the sentence
- Boolean - Full word search
- Boolean - Case sensitivity search

### Outputs
- Integer - How many times the searched word is in the sentence

### Testing
- 1st input: "Coders who code don't always eat cod. Exclaimed the coder who codes CODE."
- example 2nd input:
    - Test 1
        - Text to search: Cod
        - Full word = false
        - Case sensitive = false
            - Returns 6
    - Test 2
        - Text to search: .
        - Full word = false
        - Case sensitive = false
            - Returns 2
    - Test 3
        - Text to search: Cod
        - Full word = true
        - Case sensitivity = true
            - Returns 0
    - Test 4
        - Text to search: CODE.
        - Full word = true
        - Case sensitivity = true
            - Returns 1
    - Test 5
        - Text to search: don't always
        - Full word = true
        - Case sensitivity = true
            - Returns 1