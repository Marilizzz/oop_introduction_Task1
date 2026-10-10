/*1ST TASK
Console.WriteLine("Student Task Manager");
Console.WriteLine("====================");

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("What is your favorite programming language? ");
string favoriteLanguage = Console.ReadLine();

Console.Write("One reason you want to learn .NET? ");
string reason = Console.ReadLine();

Console.WriteLine();
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"Your favorite programming language is {favoriteLanguage}.");
Console.WriteLine($"One reason you want to learn .NET is {reason}.");
2ND TASK
Console.WriteLine("Student Task Manager");
Console.WriteLine("====================");

Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("How many tasks do you want to complete today? ");
int taskGoal = int.Parse(Console.ReadLine());

Console.Write("How many hours do you have available? ");
double availableHours = double.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine($"Hello {name}!");
Console.WriteLine($"Your goal is {taskGoal} tasks.");
Console.WriteLine($"You have {availableHours} hours available.");
string studentName = "Alex";
int taskCount = 5;
double studyHours = 2.5;
decimal budget = 100.50m;
bool isCompleted = false;
char grade = 'A';

const int MaxDailyTasks = 10;
const string AppName = "Student Task Manager";

Console.WriteLine($"Application: {AppName}");
Console.WriteLine($"Maximum recommended daily tasks: {MaxDailyTasks}");

Console.WriteLine("Student Task Manager");
Console.WriteLine("====================");

const int MaxTasksPerDay = 10;

Console.Write("Enter your age: ");
int age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException("Input is required."));

Console.Write("Enter your course name: ");
string courseName = Console.ReadLine() ?? throw new InvalidOperationException("Input is required.");

Console.Write("Do you already know C#? (yes/no) ");
string knowsCSharpAnswer = Console.ReadLine() ?? throw new InvalidOperationException("Input is required.");
bool knowsCSharp;
if (string.Equals(knowsCSharpAnswer, "yes", StringComparison.OrdinalIgnoreCase))
{
    knowsCSharp = true;
}
else if (string.Equals(knowsCSharpAnswer, "no", StringComparison.OrdinalIgnoreCase))
{
    knowsCSharp = false;
}
else
{
    throw new FormatException("Enter yes or no.");
}

Console.WriteLine();
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Course: {courseName}");
Console.WriteLine($"Already knows C#: {knowsCSharp}");
Console.WriteLine($"Maximum tasks allowed per day: {MaxTasksPerDay}");
3rd Task
Console.Write("How many tasks have you completed today? ");
int completedTasks = int.Parse(Console.ReadLine());

if (completedTasks == 0)
{
    Console.WriteLine("Time to get started!");
}
else if (completedTasks < 3)
{
    Console.WriteLine("Good start. Keep going!");
}
else
{
    Console.WriteLine("Great progress!");
}
Console.WriteLine();
Console.WriteLine("1. Add task");
Console.WriteLine("2. View tasks");
Console.WriteLine("3. Exit");

Console.Write("Choose an option: ");
int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("Adding a task...");
        break;

    case 2:
        Console.WriteLine("Showing tasks...");
        break;

    case 3:
        Console.WriteLine("Goodbye!");
        break;

    default:
        Console.WriteLine("Invalid option.");
        break;
}
Console.WriteLine("1. Add task");
Console.WriteLine("2. View tasks");
Console.WriteLine("3. Complete task");
Console.WriteLine("4. Remove task");
Console.WriteLine("0. Exit");

Console.Write("Choose an option: ");
int option = int.Parse(Console.ReadLine());

switch (option)
{
    case 1:
        Console.WriteLine("Adding a task...");
        break;

    case 2:
        Console.WriteLine("Showing tasks...");
        break;

    case 3:
        Console.WriteLine("Completing a task...");
        break;

    case 4:
        Console.WriteLine("Removing a task...");
        break;

    case 0:
        Console.WriteLine("Goodbye!");
        break;

    default:
        Console.WriteLine("Invalid option.");
        break;
}
4th Task
List<string> tasks = new List<string>();
tasks.Add("Review C# variables");
tasks.Add("Practice loops");
tasks.Add("Create a Console application");
Console.WriteLine($"Number of tasks: {tasks.Count}");
foreach (string task in tasks)
{
    Console.WriteLine(task);
}
for (int i = 0; i < tasks.Count; i++)
{
    Console.WriteLine($"{i + 1}. {tasks[i]}");
}
Console.Write("Enter a new task: ");
string newTask = Console.ReadLine();

tasks.Add(newTask);

Console.WriteLine("Task added.");
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            break;

        case 2:
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            break;

        case 0:
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            break;

        case 2:
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
            break;

        case 0:
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
List<string> tasks = new List<string>();
bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("0. Exit");

    Console.Write("Choose: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            tasks.Add(task);
            break;

        case 2:
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
            break;

        case 3:
            Console.Write("Task to remove: ");
            int taskNumber = int.Parse(Console.ReadLine());
            int index = taskNumber - 1;

            // Validation to make sure the user inputs a valid task number
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
            break;

        case 0:
            running = false;
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
5th Task
void ShowTitle()
{
    Console.WriteLine();
    Console.WriteLine("Student Task Manager");
    Console.WriteLine("====================");
}
void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
}
case 2:
    ShowTasks(tasks);
    break;
while (running)
{
    ShowMenu();

    Console.Write("Choose: ");
    if (!int.TryParse(Console.ReadLine(), out int option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }

    switch (option)
    {
        case 1:
            AddTask(tasks);
            break;

        case 2:
            ShowTasks(tasks);
            break;

        case 3:
            RemoveTask(tasks);
            break;

        case 0:
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}



static void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("0. Exit");
}

static void AddTask(List<string> tasks)
{
    Console.Write("Enter task: ");
    string task = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(task))
    {
        tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }
    else
    {
        Console.WriteLine("Task cannot be empty.");
    }
}

static void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
}

static void RemoveTask(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks to remove.");
        return;
    }

    ShowTasks(tasks);
    Console.Write("Task to remove: ");

    if (int.TryParse(Console.ReadLine(), out int taskNumber))
    {
        int index = taskNumber - 1;
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Task removed successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}
6th Task
enum TaskPriority
{
    Low,
    Medium,
    High
}
TaskPriority priority = TaskPriority.High;

Console.WriteLine(priority);
switch (priority)
{
    case TaskPriority.Low:
        Console.WriteLine("This task can wait.");
        break;

    case TaskPriority.Medium:
        Console.WriteLine("Try to finish this task today.");
        break;

    case TaskPriority.High:
        Console.WriteLine("Prioritize this task.");
        break;
}
const int MaxTasks = 10;
if (tasks.Count >= MaxTasks)
{
    Console.WriteLine("Maximum number of tasks reached.");
}
else
{
    // add task
}*/
using System;
using System.Collections.Generic;

List<string> tasks = new List<string>();
bool running = true;

while (running)
{
    ShowMenu();

    Console.Write("Choose: ");
    if (!int.TryParse(Console.ReadLine(), out int option))
    {
        Console.WriteLine("Invalid input. Please enter a number.");
        continue;
    }

    switch (option)
    {
        case 1:
            AddTask(tasks);
            break;

        case 2:
            ShowTasks(tasks);
            break;

        case 3:
            RemoveTask(tasks);
            break;

        case 4:
            ShowTaskCount(tasks);
            break;

        case 0:
            running = false;
            Console.WriteLine("Goodbye!");
            break;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}

// ==========================
// METHODS
// ==========================

static void ShowMenu()
{
    Console.WriteLine();
    Console.WriteLine("Student Task Manager");
    Console.WriteLine("====================");
    Console.WriteLine("1. Add task");
    Console.WriteLine("2. View tasks");
    Console.WriteLine("3. Remove task");
    Console.WriteLine("4. Show task count");
    Console.WriteLine("0. Exit");
}

static void AddTask(List<string> tasks)
{
    const int maxAllowed = 10;
    if (tasks.Count >= maxAllowed)
    {
        Console.WriteLine("Cannot add task. Maximum capacity reached!");
        return;
    }

    Console.Write("Enter task: ");
    string task = Console.ReadLine();
    if (!string.IsNullOrWhiteSpace(task))
    {
        tasks.Add(task);
        Console.WriteLine("Task added successfully!");
    }
    else
    {
        Console.WriteLine("Task cannot be empty.");
    }
}

static void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks available.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {tasks[i]}");
    }
}

static void RemoveTask(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks to remove.");
        return;
    }

    ShowTasks(tasks);
    Console.Write("Task to remove: ");

    if (int.TryParse(Console.ReadLine(), out int taskNumber))
    {
        int index = taskNumber - 1;
        if (index >= 0 && index < tasks.Count)
        {
            tasks.RemoveAt(index);
            Console.WriteLine("Task removed successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input.");
    }
}

static void ShowTaskCount(List<string> tasks)
{
    int maxAllowed = 10;
    int currentCount = tasks.Count;
    int remaining = maxAllowed - currentCount;

    Console.WriteLine($"You currently have {currentCount} tasks.");
    Console.WriteLine($"Maximum allowed: {maxAllowed}");
    Console.WriteLine($"Remaining capacity: {remaining}");
}