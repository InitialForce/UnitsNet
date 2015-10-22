@echo off
SET ROOT=%~dp0..
set LogDir=%ROOT%\Artifacts\Logs
set TestsBinDir=%ROOT%\Artifacts\Bin\Tests\AnyCPU_Release
mkdir %LogDir%

%ROOT%\Tools\NUnit\nunit-console.exe "%TestsBinDir%\UnitsNet.Tests.dll" /framework="net-4.0" /xml:%LogDir%\UnitsNet.Tests.xml
%ROOT%\Tools\NUnit\nunit-console.exe "%TestsBinDir%\UnitsNet.Serialization.JsonNet.Tests.dll" /framework="net-3.5" /xml:%LogDir%\UnitsNet.Serialization.JsonNet.Tests.xml