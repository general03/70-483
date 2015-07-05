# Scope thread

A thread has its own call stack that stores all the methods that are executed. 
Local variables are stored on the call stack and are private to the thread.

# Example : StaticVariable.cs

In this example, with [ThreadStatic] the value is 20 but without it, it becomes 40. Indeed by default the value is shared by all the thread.

# Variables

* private => bool stopped
* static => [ThreadStatic]
* local => ThreadLocal<int>