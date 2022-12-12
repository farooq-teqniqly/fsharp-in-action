let addDays days =
    let newDays = System.DateTime.Today.AddDays days
    printfn $"You gave me {days} days and I gave you {newDays}."
    newDays

let addSeveralDays () =
    ignore (addDays 3)
    ignore (addDays 5)
    addDays 7
    
ignore (addSeveralDays ())



let drive gas distance =
    if distance = "far" then gas / 2.0
    elif distance = "medium" then gas / 10.0
    else gas - 1.0
    
let gas = 100
let firstState  = drive gas "far"
let secondState  = drive firstState "medimu"
let finalState  = drive secondState "short"

let drive2 gas distance =
    if distance > 50.0 then gas / 2.0
    elif distance > 25.0 then gas / 10.0
    elif distance > 0.0 then gas - 1.0
    else gas
    
let gas = 100.0
let firstState  = drive2 gas 51.0
let secondState  = drive2 firstState 26.0
let thirdState  = drive2 secondState 1.0
let finalState  = drive2 thirdState 0.0