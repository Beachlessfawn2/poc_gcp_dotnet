#! /bin/bash
apt-get update
apt-get -y upgrade
apt-get -y install sshpass
sshpass -p 'haai' sftp -o StrictHostKeyChecking=accept-new -P 5151 -oBatchMode=no -b - TestU@server << !
   cd documents
   put /workspace/MessageUtil/bin/Release/netcoreapp3.1/win10-x64/messageutil-win10-x64.tar.gz
   bye
!
