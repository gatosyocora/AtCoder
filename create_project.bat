@echo off
mkdir ABC%1
cd ABC%1
call :CreateProblemProject a
call :CreateProblemProject b
call :CreateProblemProject c
call :CreateProblemProject d
exit /b

:CreateProblemProject
mkdir %1
cd %1
dotnet new atcoder
mv atcoder.csproj %1.csproj
cd ..
exit /b