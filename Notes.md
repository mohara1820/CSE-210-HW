Basic commands in git 
    - Git status 
        will tell you the status of the code you have writen. 

    - git restore 
        can restore anything prior to anything you have commited, note you will need to be specific on the folder route to restore it, so keep files simple
        Example: git restore --staged sandbox/Sandbox/Program.cs
        you have to be specific on caplitalization

    - git add
        this is the command that you use to add/prepare to commit, you have to be specific in  the route and type the route
        Example:
            git add sandbox/Sandbox/Program.cs

    - git commit - m "insert the mesage here"
        MAKE SURE TOO DO THIS, github want you to leave a message on what stuff you have eddited and keep track of it. if do not type a message you will run into a error

    - git commit
        the command that preps the file to be uploaded but dosen't uploaded it yet.

    - :q!
        the comand that allows you to quit the error and cancels you commit if you only typed commit

    - git push
        the command that uploads the actually file to get hub