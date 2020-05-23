#! /bin/bash
apt-get update
apt-get -y upgrade
apt-get -y install sshpass
export SSHPASS='temp'
sshpass -e sftp -P 5151 -oBatchMode=no -b - KenzieC@213.119.34.127 << !
   put /workspace/MessageUtil/bin/Release/netcoreapp3.1/win10-x64/messageutil-win10-x64.tar.gz
   bye
!
