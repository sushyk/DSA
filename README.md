# DSA Practice

Data structures and algorithms practice problems, written in C#.

Each problem is a single, self-contained `.cs` file. These are .NET 10 **file-based apps**, so there is no `.csproj`, no solution file, and no `Main` method. You run the `.cs` file directly.

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download) or later

Check your version:

```bash
dotnet --version   # should be 10.0.x or higher
```

## Running a problem

Run a file with `dotnet run <file>.cs`. You can also use the shorter `dotnet <file>.cs`:

```bash
dotnet run MoveZeroesToStart.cs
dotnet MoveZeroesToStart.cs
```

Most filenames contain spaces, so **put the path in quotes**:

```bash
dotnet run "TakeUForward/Step 3/Lec 1/2 - SecondLargestElement.cs"
dotnet run "Algomap/Two Pointers/1 - SquaresOfSortedArray.cs"
```

You can run a file from any directory. Just give its path.

### Notes

- **The first run is slower.** The SDK compiles the file and caches the build output in a temp folder. Later runs of an unchanged file start much faster.
- **Each file runs on its own.** Running one file compiles only that file, so the other `.cs` files in the same folder don't interfere.
- **Some files print nothing.** Those files only define a solution function and have no test calls yet. To try one, add a call at the top of the file, for example:
  ```csharp
  Console.WriteLine(MissingNumber([3, 0, 1]));
  ```
- **Passing arguments:** `dotnet run "<file>.cs" -- arg1 arg2`. Inside the file, read them with `args`.
- **Debugging in VS Code:** with the C# Dev Kit extension installed, open a `.cs` file and use **Run / Debug**.

### File layout

In C# with top-level statements, the code at the top of a file runs first. Each file is laid out like this:

```csharp
// 1. Test calls (these run when you execute the file)
Console.WriteLine(MissingNumber([3, 0, 1]));

// 2. Solution functions
static int MissingNumber(int[] nums) { ... }

// 3. Helper types (if any) go last, e.g. a linked-list node
class ListNode { ... }
```

### Turning a file into a full project

If a file grows beyond a single-file app, you can convert it:

```bash
dotnet project convert "Algomap/Arrays/7 - SummaryRanges.cs"
```

This creates a folder with a `.csproj` and the source file.

## Repository structure

```
.
├── Algomap/               # Algomap roadmap problems (Arrays, Linked Lists, Two Pointers)
├── TakeUForward/          # Striver's A2Z DSA sheet, organized by Step / Lecture
├── InterviewQuestions/    # Miscellaneous interview problems
├── MoveZeroesToStart.cs   # Move all zeros to the front of an array
├── MaxAverageSubarray.cs  # Maximum average subarray of length k
└── Archive/               # Original Python solutions (same folder layout)
```

Files are numbered in the order they appear in each course, e.g. `3 - IsSubsequence.cs`.

## Archive

`Archive/` holds the original Python versions of these solutions. Run one with:

```bash
python "Archive/TakeUForward/Step 1/Lec 4/GCD.py"
```

Several bugs that are still in the Python versions were fixed in the C# versions. Each fix is marked with a `// fixed:` or `NOTE` comment in the `.cs` file.
