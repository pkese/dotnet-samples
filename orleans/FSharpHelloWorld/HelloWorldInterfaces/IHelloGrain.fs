namespace HelloWorldInterfaces

open System.Threading.Tasks
open Orleans

type IHelloGrain =
    inherit IGrainWithIntegerKey
    abstract member SayHello : message:string -> ValueTask<string>
