﻿open System


let add a b =
    Mathematics.add a b


let a = 3
let b = 5
let t = add 3 5

let p = StringBeautifier.beautifyAdd a b t

Console.WriteLine(p)

//this file or project should not be covered by any tests.