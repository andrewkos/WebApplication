namespace NiceFunctions

module helloWorld = 

    //let dir = System.IO.Directory.GetCurrentDirectory()
    //let path = dir + @"\test.txt"

    let writeMessage(serverPath:string,url:string)=
            System.IO.File.AppendAllLines(serverPath  + @"\test.txt",[|url|])

    let readMessage(serverPath:string) = System.IO.File.ReadAllText(serverPath + @"\test.txt")
