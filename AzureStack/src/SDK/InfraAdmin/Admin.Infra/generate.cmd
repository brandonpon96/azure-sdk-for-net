@echo off

set OUTPUT=Generated
set CONF=infra.md

IF EXIST %OUTPUT% (
    rd %OUTPUT% /Q /S
 ) 

autorest %CONF% --verbose --debug