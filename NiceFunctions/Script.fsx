
let dir = System.IO.Directory.GetCurrentDirectory()
let path = dir + @"\test.txt"
System.IO.File.AppendAllLines(path,[|"tester"|])

let readfile = System.IO.File.ReadAllText(path)
