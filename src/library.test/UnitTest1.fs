module library.test

open NUnit.Framework

let add = Mathematics.add

[<Test>]
let can_add_2_to_3_and_get_5 () =
    let result = add 2 3
    Assert.AreEqual(5, result)


[<Test>]
let can_add_4_to_5_and_get_9 () =
    let result = add 4 5
    Assert.AreEqual(9, result)

