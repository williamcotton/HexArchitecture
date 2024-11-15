module User
    type User = { Name: string; Age: int }

    let create name age = { Name = name; Age = age }

    let getName user = user.Name

    let getAge user = user.Age

    let setName name user = { user with Name = name }

    let setAge age user = { user with Age = age }

    let print user =
        printfn "Name: %s, Age: %d" user.Name user.Age