echo | call 1_DeleteDir.bat
echo | call 1_DeleteFile.bat

@echo on
timeout 5

rem echo | 3_BuildLibsAtOtherRepos.bat
echo | 3_BuildLibsAtOtherReposInTimeOfDev.bat

@echo on
timeout 5

rem echo | 4_BuildLibsAtOtherRepos.bat
echo | 4_BuildLibsAtOtherReposInTimeOfDev.bat

@echo on
timeout 5

echo | 10_MultiPurposeAuthSiteCore.bat

@echo on
timeout 5
