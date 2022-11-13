using System;

public class FileIO
{
	public FileIO()
	{
	}

	/* Reads from a given file and returns a string array containing file contents */
	public static dynamic readFile(string filename)
	{
		string[] file_values = new string[] {};

        var file_lines = File.ReadAllLines(filename);
		for (int i = 0; i < file_lines.Length; i++)
		{
            file_values = file_lines[i].Split(",");
        }
		return file_values;
	}

	/* Creates a file, writes given content, and saves it to examArchives folder */
	public static void createFile(string filename, string[] content)
	{
		string data_to_write = "";

		foreach (string line in content)
		{
			data_to_write += line + "\n";
		}
		File.WriteAllText(@"examArchives\" + filename, data_to_write);
	}
}