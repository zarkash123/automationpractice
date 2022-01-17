@ECHO OFF
ECHO Demo Automation Execution Started.



set testcategory=SignIn
set dllpath=C:\Users\kashizar\source\repos\automation_practice\automationpractice\automationpractice\bin\Debug\automationpractice.dll
set trxerpath=C:\Users\kashizar\source\repos\automation_practice\automationpractice\automationpractice\bin\Debug
set reportpath=C:\Users\kashizar\source\repos\automation_practice\automationpractice\automationpractice\report
set vsCmdRunner=C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat



call "%vsCmdRunner%"
VSTest.Console.exe "%dllpath%" /TestCaseFilter:"TestCategory=%testcategory%" /Logger:"trx;LogFileName=%reportpath%\Test1.trx"



cd "%trxerpath%"
TrxerConsole.exe "%reportpath%"\Test1.trx



PAUSE