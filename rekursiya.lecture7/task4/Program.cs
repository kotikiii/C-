

string path = "/Users/robiya/Desktop/gb.new/seminar1/seminar1_classwork/classwork_task_1";
DirectoryInfo di = new DirectoryInfo(path);
Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}