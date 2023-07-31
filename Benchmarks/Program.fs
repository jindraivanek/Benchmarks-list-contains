module ListBenchmarks

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
type MyRecord = { Id: int; Name: string }

module List =
    let containsByExists x xs = List.exists ((=) x) xs
    let inline containsByExistsInline x xs = List.exists ((=) x) xs

    let inline containsMutable value (source: list<_>) =
        let mutable xs = source
        let mutable state = false

        while (not state && not xs.IsEmpty) do
            state <- value = xs.Head
            xs <- xs.Tail

        state

    let inline containsTryFind value (source: list<_>) =
        source |> List.tryFind (fun x -> value = x) |> Option.isSome

let inline test xs f =
    for i in xs do
        f i xs |> ignore

[<MemoryDiagnoser>]
type ListTests() =

    let listOfInts = [ 1..1000 ]
    let listOfStrings = listOfInts |> List.map (fun i -> i.ToString())
    let listOfRecords =
        listOfInts |> List.map (fun i -> { Id = i; Name = i.ToString() })

    [<Benchmark(Description = "int - List.exists")>]
    member _.IntListExists() =
        test listOfInts (fun i -> List.exists (fun item -> item = i)) 

    [<Benchmark(Description = "int - List.contains")>]
    member _.IntListContains() =
        test listOfInts List.contains

    [<Benchmark(Description = "int - List.containsByExists")>]
    member _.IntListContainsByExists() =
        test listOfInts List.containsByExists

    [<Benchmark(Description = "int - List.containsByExistsInline")>]
    member _.IntListContainsByExistsInline() =
        test listOfInts List.containsByExistsInline

    [<Benchmark(Description = "int - List.containsMutable")>]
    member _.IntListcontainsMutable() =
        test listOfInts List.containsMutable

    [<Benchmark(Description = "int - List.containsTryFind")>]
    member _.IntListContainsTryFind() =
        test listOfInts List.containsTryFind

    [<Benchmark(Description = "string - List.exists")>]
    member _.StringListExists() =
        test listOfStrings (fun i -> List.exists (fun item -> item = i))

    [<Benchmark(Description = "string - List.contains")>]
    member _.StringListContains() =
        test listOfStrings List.contains

    [<Benchmark(Description = "string - List.containsByExists")>]
    member _.StringListContainsByExists() =
        test listOfStrings List.containsByExists

    [<Benchmark(Description = "string - List.containsByExistsInline")>]
    member _.StringListContainsByExistsInline() =
        test listOfStrings List.containsByExistsInline

    [<Benchmark(Description = "string - List.containsMutable")>]
    member _.StringListcontainsMutable() =
        test listOfStrings List.containsMutable

    [<Benchmark(Description = "string - List.containsTryFind")>]
    member _.StringListContainsTryFind() =
        test listOfStrings List.containsTryFind

    [<Benchmark(Description = "record - List.exists")>]
    member _.RecordListExists() =
        test listOfRecords (fun i -> List.exists (fun item -> item.Id = i.Id))

    [<Benchmark(Description = "record - List.contains")>]
    member _.RecordListContains() =
        test listOfRecords (fun i -> List.contains i)

    [<Benchmark(Description = "record - List.containsByExists")>]
    member _.RecordListContainsByExists() =
        test listOfRecords (fun i -> List.containsByExists i)

    [<Benchmark(Description = "record - List.containsByExistsInline")>]
    member _.RecordListContainsByExistsInline() =
        test listOfRecords (fun i -> List.containsByExistsInline i)

    [<Benchmark(Description = "record - List.containsMutable")>]
    member _.RecordListcontainsMutable() =
        test listOfRecords (fun i -> List.containsMutable i)

    [<Benchmark(Description = "record - List.containsTryFind")>]
    member _.RecordListContainsTryFind() =
        test listOfRecords (fun i -> List.containsTryFind i)

module Array =
    let containsByExists x xs = Array.exists ((=) x) xs
    let inline containsByExistsInline x xs = Array.exists ((=) x) xs

[<MemoryDiagnoser>]
type ArrayTests() =

    let arrayOfInts = [| 1..1000 |]
    let arrayOfStrings = arrayOfInts |> Array.map (fun i -> i.ToString())
    let arrayOfRecords =
        arrayOfInts |> Array.map (fun i -> { Id = i; Name = i.ToString() })

    [<Benchmark(Description = "int - Array.exists")>]
    member _.IntArrayExists() =
        test arrayOfInts (fun i -> Array.exists (fun item -> item = i)) 

    [<Benchmark(Description = "int - Array.contains")>]
    member _.IntArrayContains() =
        test arrayOfInts Array.contains

    [<Benchmark(Description = "int - Array.containsByExists")>]
    member _.IntArrayContainsByExists() =
        test arrayOfInts Array.containsByExists

    [<Benchmark(Description = "int - Array.containsByExistsInline")>]
    member _.IntArrayContainsByExistsInline() =
        test arrayOfInts Array.containsByExistsInline

    [<Benchmark(Description = "string - Array.exists")>]
    member _.StringArrayExists() =
        test arrayOfStrings (fun i -> Array.exists (fun item -> item = i))

    [<Benchmark(Description = "string - Array.contains")>]
    member _.StringArrayContains() =
        test arrayOfStrings Array.contains

    [<Benchmark(Description = "string - Array.containsByExists")>]
    member _.StringArrayContainsByExists() =
        test arrayOfStrings Array.containsByExists

    [<Benchmark(Description = "string - Array.containsByExistsInline")>]
    member _.StringArrayContainsByExistsInline() =
        test arrayOfStrings Array.containsByExistsInline

    [<Benchmark(Description = "record - Array.exists")>]
    member _.RecordArrayExists() =
        test arrayOfRecords (fun i -> Array.exists (fun item -> item.Id = i.Id))

    [<Benchmark(Description = "record - Array.contains")>]
    member _.RecordArrayContains() =
        test arrayOfRecords (fun i -> Array.contains i)

    [<Benchmark(Description = "record - Array.containsByExists")>]
    member _.RecordArrayContainsByExists() =
        test arrayOfRecords (fun i -> Array.containsByExists i)

    [<Benchmark(Description = "record - Array.containsByExistsInline")>]
    member _.RecordArrayContainsByExistsInline() =
        test arrayOfRecords (fun i -> Array.containsByExistsInline i)

module Seq =
    let containsByExists x xs = Seq.exists ((=) x) xs
    let inline containsByExistsInline x xs = Seq.exists ((=) x) xs

[<MemoryDiagnoser>]
type SeqTests() =

    let seqOfInts = seq { 1..1000 }
    let seqOfStrings = seqOfInts |> Seq.map (fun i -> i.ToString())
    let seqOfRecords =
        seqOfInts |> Seq.map (fun i -> { Id = i; Name = i.ToString() })

    [<Benchmark(Description = "int - Seq.exists")>]
    member _.IntSeqExists() =
        test seqOfInts (fun i -> Seq.exists (fun item -> item = i)) 

    [<Benchmark(Description = "int - Seq.contains")>]
    member _.IntSeqContains() =
        test seqOfInts Seq.contains

    [<Benchmark(Description = "int - Seq.containsByExists")>]
    member _.IntSeqContainsByExists() =
        test seqOfInts Seq.containsByExists

    [<Benchmark(Description = "int - Seq.containsByExistsInline")>]
    member _.IntSeqContainsByExistsInline() =
        test seqOfInts Seq.containsByExistsInline

    [<Benchmark(Description = "string - Seq.exists")>]
    member _.StringSeqExists() =
        test seqOfStrings (fun i -> Seq.exists (fun item -> item = i))

    [<Benchmark(Description = "string - Seq.contains")>]
    member _.StringSeqContains() =
        test seqOfStrings Seq.contains

    [<Benchmark(Description = "string - Seq.containsByExists")>]
    member _.StringSeqContainsByExists() =
        test seqOfStrings Seq.containsByExists

    [<Benchmark(Description = "string - Seq.containsByExistsInline")>]
    member _.StringSeqContainsByExistsInline() =
        test seqOfStrings Seq.containsByExistsInline

    [<Benchmark(Description = "record - Seq.exists")>]
    member _.RecordSeqExists() =
        test seqOfRecords (fun i -> Seq.exists (fun item -> item.Id = i.Id))

    [<Benchmark(Description = "record - Seq.contains")>]
    member _.RecordSeqContains() =
        test seqOfRecords (fun i -> Seq.contains i)

    [<Benchmark(Description = "record - Seq.containsByExists")>]
    member _.RecordSeqContainsByExists() =
        test seqOfRecords (fun i -> Seq.containsByExists i)

    [<Benchmark(Description = "record - Seq.containsByExistsInline")>]
    member _.RecordSeqContainsByExistsInline() =
        test seqOfRecords (fun i -> Seq.containsByExistsInline i)


BenchmarkRunner.Run<ListTests>()
BenchmarkRunner.Run<ArrayTests>()
BenchmarkRunner.Run<SeqTests>()

//BenchmarkRunner.Run([| typeof<ListTests>; typeof<ArrayTests>; typeof<SeqTests> |])

