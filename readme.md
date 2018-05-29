# TODO

- [ ] [Scrutor][Scrutor] : Assembly scanning and decoration extensions for Microsoft.Extensions.DependencyInjection
- [ ] SourceLink
- [ ] [ML.net][ml.net]
- [ ] c# (7.3, ref, fixed, stackalloc)
- [x] dotnet script
- [x] [CLSCompliant](#CLSCompliant)
- [x] [.editorconfig][editorconfig]
- [x] [Heap/Stack][heapStack]

## CLSCompliant <a name="CLSCompliant"></a>

You mark classes with the CLSCompliant attribute when you want to make sure it can be used by any other .NET language. These are the basic rules:

- Unsigned types should not be part of the public interface of the class. What this means is public fields should not have unsigned types like uint or ulong, public methods should not return unsigned types, parameters passed to public function should not have unsigned types. However unsigned types can be part of private members.
- Unsafe types like pointers should not be used with public members. However they can be used with private members.
- Class names and member names should not differ only based on their case. For example we cannot have two methods named MyMethod and MYMETHOD.
- Only properties and methods may be overloaded, Operators should not be overloaded.

## Archi Microservices

- SOLID
- DDD
- CQRS
- [Sagas][Sagas] Patterns for long-running processes

[editorconfig]:https://docs.microsoft.com/fr-fr/visualstudio/ide/create-portable-custom-editor-options
[heapStack]:https://www.gribblelab.org/CBootCamp/7_Memory_Stack_vs_Heap.html
[ml.net]:https://www.microsoft.com/net/learn/apps/machine-learning-and-ai/ml-dotnet/get-started/windows
[Sagas]:https://docs.particular.net/nservicebus/sagas/
[Scrutor]:https://github.com/khellang/Scrutor
