#!/bin/bash
### will generate new changes to a schema image
fileName=$1

if [ -z "$fileName" ];
then
echo "please input argv1 as file name"
return
fi

echo "generating $fileName migration"

dotnet ef migrations add $fileName
