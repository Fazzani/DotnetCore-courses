# TODO

* [ ] [Scrutor][scrutor] : Assembly scanning and decoration extensions for Microsoft.Extensions.DependencyInjection
* [ ] InMemmory for database with seed default data
* [ ] [orleans][orleans] or [akka.net][akka.net] for concurrent & distributed applications
* [ ] SourceLink
* [ ] [ML.net][ml.net]
* [ ] c# (7.3, ref, fixed, stackalloc, _, local functions, StartUpFilter, SetCompatibilityVersion)
* [ ] [IHostedService][ihostservice]
* [ ] [Onion][onion]
* [ ] [Prometheus.net][prometheus]
* [ ] [Faker][faker]
* [ ] Ui testing
* [ ] Ab testing
* [ ] Features flipping
* [ ] [MessagePack][messagepack]
* [x] dotnet script
* [x] [CLSCompliant](#CLSCompliant)
* [x] [.editorconfig][editorconfig]
* [x] [Heap/Stack][heapstack]

https://github.com/dotnet-architecture/eShopOnContainers/blob/features/net21rc1/src/Services/Basket/Basket.API/Startup.cs
https://docs.microsoft.com/en-us/previous-versions/msp-n-p/dn600223(v%3dpandp.10)

## CLSCompliant <a name="CLSCompliant"></a>

You mark classes with the CLSCompliant attribute when you want to make sure it can be used by any other .NET language. These are the basic rules:

* Unsigned types should not be part of the public interface of the class. What this means is public fields should not have unsigned types like uint or ulong, public methods should not return unsigned types, parameters passed to public function should not have unsigned types. However unsigned types can be part of private members.
* Unsafe types like pointers should not be used with public members. However they can be used with private members.
* Class names and member names should not differ only based on their case. For example we cannot have two methods named MyMethod and MYMETHOD.
* Only properties and methods may be overloaded, Operators should not be overloaded.

## Archi Microservices

* [S.O.L.I.D][solid]
* DDD
* CQRS
* [Sagas][sagas] Patterns for long-running processes

[solid]: https://scotch.io/bar-talk/s-o-l-i-d-the-first-five-principles-of-object-oriented-design
[editorconfig]: https://docs.microsoft.com/fr-fr/visualstudio/ide/create-portable-custom-editor-options
[heapstack]: https://www.gribblelab.org/CBootCamp/7_Memory_Stack_vs_Heap.html
[ml.net]: https://www.microsoft.com/net/learn/apps/machine-learning-and-ai/ml-dotnet/get-started/windows
[sagas]: https://docs.particular.net/nservicebus/sagas/
[scrutor]: https://github.com/khellang/Scrutor
[prometheus]: https://blog.developershelf.com/2018/01/09/asp-net-core-metrics/
[orleans]: https://github.com/dotnet/orleans
[akka.net]: https://getakka.net/
[messagepack]: https://msgpack.org/
[faker]: https://github.com/bchavez/Bogus
[ihostservice]:https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/multi-container-microservice-net-applications/background-tasks-with-ihostedservice
[onion]: https://dzone.com/articles/onion-architecture-is-interesting
