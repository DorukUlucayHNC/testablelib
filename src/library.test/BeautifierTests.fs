module library.BeautifierTests

open NUnit.Framework

[<Test>]
let given_2_3_5_returned_2_3_5 () =
    let result = StringBeautifier.beautifyAdd 2 3 5
    Assert.AreEqual("2 + 3 = 5", result)

[<Test>]
let given_2_3_999_returned_2_3_999 () =
    let result = StringBeautifier.beautifyAdd 2 3 999
    Assert.AreEqual("2 + 3 = 999", result)
