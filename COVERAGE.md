# Test Code Coverage

Test Code Coverage was generated using OpenCover and ReportGenerator
for .NET Framework 4.8 and MSTest.

## Tools
- OpenCover (portable)
- ReportGenerator (portable)

## Steps
1. Build solution in Visual Studio (Debug):
   - Build -> Clean Solution
   - Build -> Build Solution

2. Run OpenCover:
   OpenCover.Console.exe is used together with vstest.console.exe.

3. Generate HTML report using ReportGenerator.

The resulting report is available as:
coverage/report/index.html

Coverage was calculated only for the main project (calcu1),
test assemblies were excluded.