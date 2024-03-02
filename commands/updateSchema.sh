#!/bin/bash
### Apply new changes to your database

dotnet clean
dotnet build
dotnet ef database update
