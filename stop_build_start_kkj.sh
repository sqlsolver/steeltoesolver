#/bin/bash
#Stop Kestrel, rebuild kkj and start Kestrel
systemctl stop kestrel-kkj-mvc.service
dotnet publish -c Release -r ubuntu.16.04-x64 --self-contained
systemctl start kestrel-kkj-mvc.service
echo Rebuild of kkj complete.
