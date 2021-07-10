Setting up directory
cd then path to your directory, use forward slash
=================================================

Setting up Project link
Git clone [git link]
===============================================================

Change directory to project directory
cd [directory with project] (use forward slash)
===================================================================

to add files to local staging branch 
git add [file name].[file type] (you could just use add for all of them, as well as .txt for all text files)
========================================================================================================

To update your files
Git pull
===============================================================

To send local to staging
git commit -m "[your message here] to commit your changes to be ready to sent to the staging branch
===================================================
To save to server
git push
========================================
To create a branch 
git checkout -b [branchname]
========================================
To change to a branch
git checkout [branchname]
=====================================
To list all the branches
git branch
=========================================
To merge a branch with your active branch.
git merge [branchname]
=========================================
Git pull leading to error : please enter a commit message to explain why this merge is necessary
To solve this:
press "i"
write your merge message(can be blank).
press "esc"
write ":wq"
then press enter.
