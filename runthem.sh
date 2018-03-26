if [ $( ls /monads/*.exe 2>/dev/null | wc -l ) -ne 0 ];then
  rm /monads/*.exe
fi                
mcs /monads/main.cs;
mono /monads/main.exe;
