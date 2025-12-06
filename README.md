Recursive Fibonacci Sequence – C# Console App

📌 Overview

This C# console application generates and prints the Fibonacci sequence up to n terms using a recursive function.
It is a simple example that shows how recursion works in mathematical sequences.


---

🧮 How It Works

The user enters a number n.

The program uses the recursive function:

Fibonacci(n) = Fibonacci(n-1) + Fibonacci(n-2)

Base cases:

Fibonacci(0) = 0

Fibonacci(1) = 1


A loop runs from 0 to n-1 and prints each Fibonacci number using the recursive method.



---

🧩 Features

Pure recursive implementation

Prints the Fibonacci sequence

Simple and beginner-friendly

Demonstrates recursion clearly



---

▶️ Example Input/Output

Enter a number: 6
Fibonacci sequence:
0 1 1 2 3 5


---

🛠 Technologies Used

C#

.NET Console Application



---

📄 Code Snippet

static int Fibonacci(int n)
{
    if (n == 0)
        return 0;
    else if (n == 1)
        return 1;
    else
        return Fibonacci(n - 1) + Fibonacci(n - 2);
}
