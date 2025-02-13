
---

### Assignment Questions on File Handling in C#

#### **Question 1: Reading a File**
Write a C# program that reads a text file named `input.txt` and displays its contents line by line on the console. If the file does not exist, display an appropriate error message.

**Requirements:**
- Use `StreamReader` to read the file.
- Handle the `FileNotFoundException` exception.
- Ensure the program closes the file properly after reading.

---

#### **Question 2: Writing to a File**
Write a C# program that takes user input (e.g., their name and age) and writes it to a file named `output.txt`. Each input should be written on a new line.

**Requirements:**
- Use `StreamWriter` to write to the file.
- Ensure the program overwrites the file if it already exists.
- Handle any potential I/O exceptions.

---

#### **Question 3: Appending to a File**
Modify the program from **Question 2** to append new user input to the existing content of `output.txt` instead of overwriting it. Ensure the program does not delete the previous content of the file.

**Requirements:**
- Use the `StreamWriter` constructor with the `append` parameter set to `true`.
- Handle exceptions appropriately.

---

#### **Question 4: File Statistics**
Write a C# program that reads a text file named `data.txt` and calculates the following statistics:
- Total number of lines.
- Total number of words.
- Total number of characters.

**Requirements:**
- Use `StreamReader` to read the file.
- Display the results on the console.
- Handle exceptions if the file does not exist or cannot be read.

---

#### **Question 5: File Encryption**
Write a C# program that reads a text file named `secret.txt`, encrypts its content using a simple encryption algorithm (e.g., shifting each character by 1 in the ASCII table), and writes the encrypted content to a new file named `encrypted.txt`.

**Requirements:**
- Use `StreamReader` to read the file and `StreamWriter` to write the encrypted content.
- Ensure the program handles exceptions, such as missing files or permission issues.
- Provide a decryption option to reverse the encryption process.

---
