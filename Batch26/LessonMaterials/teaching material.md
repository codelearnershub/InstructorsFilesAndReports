---

# File Handling Basics: Read from and Write to Files in C#

File handling is a fundamental concept in programming that allows you to interact with files on your computer. In C#, you can read from and write to files using classes from the `System.IO` namespace. This guide will cover the basics of file handling in C#.

---

## Table of Contents
1. [Introduction to File Handling](#introduction-to-file-handling)
2. [Reading from a File](#reading-from-a-file)
   - [Using `StreamReader`](#using-streamreader)
   - [Reading Line by Line](#reading-line-by-line)
   - [Reading the Entire File](#reading-the-entire-file)
3. [Writing to a File](#writing-to-a-file)
   - [Using `StreamWriter`](#using-streamwriter)
   - [Appending to a File](#appending-to-a-file)
4. [Exception Handling](#exception-handling)
5. [Best Practices](#best-practices)
6. [Summary](#summary)

---

## Introduction to File Handling

File handling refers to the process of working with files stored on a disk. In C#, the `System.IO` namespace provides classes for reading from and writing to files. The most commonly used classes are:

- `StreamReader`: Reads text from a file.
- `StreamWriter`: Writes text to a file.

---

## Reading from a File

### Using `StreamReader`

The `StreamReader` class is used to read text from a file. It provides methods like `ReadLine`, `ReadToEnd`, and `Read` to read file content.

#### Example: Reading a File
```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\example\file.txt"; 

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null) // Read line by line
            {
                Console.WriteLine(line); // Print each line
            }
        }
    }
}
```

### Reading Line by Line
- Use the `ReadLine` method to read one line at a time.
- This is useful for processing large files without loading the entire file into memory.

### Reading the Entire File
- Use the `ReadToEnd` method to read the entire file as a single string.
- This is useful for small files.

```csharp
string content = reader.ReadToEnd();
Console.WriteLine(content);
```

---

## Writing to a File

### Using `StreamWriter`

The `StreamWriter` class is used to write text to a file. It provides methods like `Write`, `WriteLine`, and `Flush` to write content to a file.

#### Example: Writing to a File
```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = @"C:\example\output.txt"; 

        // Use StreamWriter to write to the file
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine("Hello, World!"); 
            writer.Write("This is a sample text.");
        }
    }
}
```

### Appending to a File
- Use the `StreamWriter` constructor with the `append` parameter set to `true` to append text to an existing file.

```csharp
using (StreamWriter writer = new StreamWriter(filePath, true))
{
    writer.WriteLine("This text will be appended.");
}
```

---

## Exception Handling

When working with files, it's important to handle exceptions to avoid crashes due to issues like missing files or permission errors.

#### Example: Handling Exceptions
```csharp
try
{
    using (StreamReader reader = new StreamReader(filePath))
    {
        string content = reader.ReadToEnd();
        Console.WriteLine(content);
    }
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File not found: " + ex.Message);
}
catch (IOException ex)
{
    Console.WriteLine("An I/O error occurred: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An unexpected error occurred: " + ex.Message);
}
```

---

## Best Practices

1. **Use `using` Statements**:
   - Always use `using` statements to ensure that file streams are properly disposed of, even if an exception occurs.

2. **Handle Exceptions**:
   - Use try-catch blocks to handle file-related exceptions gracefully.

3. **Check File Existence**:
   - Use `File.Exists` to check if a file exists before attempting to read or write.

   ```csharp
   if (File.Exists(filePath))
   {
       // Proceed with file operations
   }
   ```

4. **Avoid Hardcoding File Paths**:
   - Use relative paths or configuration files to manage file paths.

5. **Use Connection Pooling for Databases**:
   - If working with databases, use connection pooling to manage connections efficiently.

---

## Summary

- **Reading Files**: Use `StreamReader` to read text from a file. Methods like `ReadLine` and `ReadToEnd` make it easy to process file content.
- **Writing Files**: Use `StreamWriter` to write text to a file. You can overwrite or append to a file.
- **Exception Handling**: Always handle exceptions to ensure your program can recover from errors.
- **Best Practices**: Follow best practices like using `using` statements, checking file existence, and avoiding hardcoded paths.


---

