// See https://aka.ms/new-console-template for more information
using Methods;


AutoCar myCar = new AutoCar  { Model = "Renault", Year = 2004 };

PathInfo pathInfo = new PathInfo("Directory", "File", "Extansion");
{
    // Example 1: Deconstructing declaration and assignment.
    (string directoryName, string fileName, string extension) = pathInfo;
    string path = directoryName + fileName + extension;
}

{
    string directoryName, fileName, extension = null;
    // Example 2: Deconstructing assignment.
    (directoryName, fileName, extension) = pathInfo;
}

{
    // Example 3: Deconstructing declaration and assignment with var.
    var (directoryName, fileName, extension) = pathInfo;
    string path = directoryName + fileName + extension;
}

{
    // Example 3: Deconstructing declaration and assignment with var.
    var (_, fileName, extension) = pathInfo;
    string path =   fileName + extension;
}


InstanceProgression progression = new InstanceProgression(3, 1);
var a10 = progression.An(10);
var sum10 = progression.SumA1UpAn(10);

a10 = StaticProgression.An(3, 1, 10);
sum10 = StaticProgression.SumA1UpAn(3, 1, 10);

pathInfo.A(45);
